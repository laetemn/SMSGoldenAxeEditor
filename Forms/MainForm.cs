// 
// SMS Golden Axe Editor
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using GoldenAxeEditor.Data;
using GoldenAxeEditor.Controls;

namespace GoldenAxeEditor.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private int _frame = 0;
        private string _filePath = string.Empty;
        private Sprite _sprite = null;
        private Palette _palette = null;
        private Tileset _tileset = null;
        private Tilemap _tilemap = null;

        /// <summary>
        /// Properties
        /// </summary>
        public RomData RomData = null;
        public bool HasData { get { return RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open project menu click
        /// </summary>
        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SMS Golden Axe|*.smsga";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    RomData = null;
                    RomData = (RomData)formatter.Deserialize(fs);
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Open ROM menu click
        /// </summary>
        private void mnuOpenROM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Master System ROM|*.sms";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                if (RomData == null)
                {
                    RomData = new RomData(ofd.FileName);
                    LoadData();
                }
                else
                {
                    RomData romData = new RomData(ofd.FileName);
                    foreach (Palette palette in romData.Palettes)
                        if (RomData.Palettes.Find(x => x.ID == palette.ID) != null)
                            palette.ColorEdits.AddRange(RomData.Palettes.Find(x => x.ID == palette.ID).ColorEdits.ToArray());

                    foreach (Tileset tileset in romData.Tilesets)
                    {
                        if (RomData.Tilesets.Find(x => x.ID == tileset.ID) != null)
                        {
                            tileset.PixelEdits.AddRange(RomData.Tilesets.Find(x => x.ID == tileset.ID).PixelEdits.ToArray());
                            tileset.Length = RomData.Tilesets.Find(x => x.ID == tileset.ID).Length;
                        }
                    }
                    foreach (Tilemap tilemap in romData.Tilemaps)
                    {
                        if (RomData.Tilemaps.Find(x => x.ID == tilemap.ID) != null)
                        {
                            tilemap.TileEdits.AddRange(RomData.Tilemaps.Find(x => x.ID == tilemap.ID).TileEdits.ToArray());
                            tilemap.Columns = RomData.Tilemaps.Find(x => x.ID == tilemap.ID).Columns;
                            tilemap.Rows = RomData.Tilemaps.Find(x => x.ID == tilemap.ID).Rows;
                        }
                    }
 
                    // Note: create method for changed IDs, as the byte position (ID) may have been changed through the editor
                    RomData = romData;
                    LoadData();
                    MessageBox.Show("Project ROM data updated!");
                }
            }
        }

        /// <summary>
        /// Save menu click
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!HasData)
            {
                MessageBox.Show("Open a ROM (.sms) or project file (.smsga) first.");
                return;
            }
            using (SaveFileDialog form = new SaveFileDialog())
            {
                form.Filter = "SMSGA Project File (.smsga)|*.smsga";
                form.Title = "Save Project";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(form.FileName, FileMode.Create))
                    {
                        formatter.Serialize(fs, RomData);
                    }
                } 
            }
        }

        /// <summary>
        /// Export menu item click
        /// </summary>
        private void mnuExport_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem) || !HasData)
                return;

            ToolStripMenuItem menu = (sender as ToolStripMenuItem);
            if (menu.Name == mnuExportBinarySMS.Name)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Sega Master System File|*.sms";
                    dialog.FileName = "Golden Axe (USA, Europe)";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        RomData.ExportData(dialog.FileName);
                }
            }
            else if (menu.Name == mnuExportTilesetImage.Name && _sprite != null)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = _tileset.Name;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Palette palette = RomData.Palettes.Find(x => x.ID == _sprite.PaletteID);
                        Tileset tileset = RomData.Tilesets.Find(x => x.ID == _sprite.TilesetID);
                        List<Color> colors = GetCurrentPalette(palette, _sprite.PaletteIndex);
                        tileset.GetImage(colors, tileset.HasEdits, 16).Save(dialog.FileName, ImageFormat.Png);
                    }
                }
            }
            else if (menu.Name == mnuExportSpriteImage.Name && _sprite != null)
            {
                Palette palette = RomData.Palettes.Find(x => x.ID == _sprite.PaletteID);
                Tileset tileset = RomData.Tilesets.Find(x => x.ID == _sprite.TilesetID);
                List<Tilemap> tilemaps = new List<Tilemap>();
                foreach (int id in _sprite.TilemapIDs)
                    tilemaps.Add(RomData.Tilemaps.Find(x => x.ID == id));

                if (palette == null || tileset == null || tilemaps.Count <= 0)
                {
                    MessageBox.Show("Needed data was not found, the Sprite was not exported.");
                    return;
                }
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.FileName = _sprite.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    List<Color> colors = GetCurrentPalette(palette, _sprite.PaletteIndex);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap image = Sprite.GetImageStrip(tileset, tilemaps, colors))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Exit menu item click
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Data injection menu item click
        /// </summary>
        private void mnuDataInjection_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            using (DataInjectionForm dialog = new DataInjectionForm())
            {
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Palette edit menu item click
        /// </summary>
        private void mnuPaletteEdit_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            using (PaletteEditForm dialog = new PaletteEditForm(this))
            {
                dialog.ShowDialog();
                UpdateImages();
            }
        }

        /// <summary>
        /// About menu item click
        /// </summary>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm dialog = new AboutForm())
            {
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Frame button click
        /// </summary>
        private void btnFrame_Click(object sender, EventArgs e)
        {
            if (!(sender is Button) || _sprite == null || !HasData)
                return;

            Button button = (sender as Button);
            if (button.Name == btnPreviousFrame.Name)
                _frame--;
            else if (button.Name == btnNextFrame.Name)
                _frame++;

            if (_frame < 0)
                _frame = 0;

            if (_frame >= _sprite.TilemapIDs.Count)
                _frame = _sprite.TilemapIDs.Count - 1;

            _tilemap = RomData.Tilemaps.Find(x => x.ID == _sprite.TilemapIDs[_frame]);
            txtTilemapPosition.Text = _tilemap.ID < 0 ? "Custom" : _tilemap.ID.ToString();
            txtTilemapPosition.Enabled = _tilemap.ID >= 0;
            nudTilemapColumns.Value = _tilemap.Columns;
            nudTilemapRows.Value = _tilemap.Rows;
            UpdateImages();
        }

        /// <summary>
        /// Checkbox changed
        /// </summary>
        private void chkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox) || !HasData)
                return;

            CheckBox checkbox = sender as CheckBox;

            if (checkbox.Name == chkViewUneditedSprite.Name)
                UpdateImages();
            else if (checkbox.Name == chkTilesetUseGrid.Name)
                pnlTileset.UseGrid = chkTilesetUseGrid.Checked;
            else if (checkbox.Name == chkTilesUseGrid.Name)
            {
                pnlTiles.UseGrid = chkTilesUseGrid.Checked;
                pnlTilemap.UseGrid = chkTilesUseGrid.Checked;
            }
            else if (checkbox.Name == chkTilesetIndexed.Name)
                pnlTileset.Indexed = chkTilesetIndexed.Checked;
            else if (checkbox.Name == chkTilemapIndexed.Name)
            {
                pnlTiles.Indexed = chkTilemapIndexed.Checked;
                pnlTilemap.Indexed = chkTilemapIndexed.Checked;
            }
        }

        /// <summary>
        /// Sprite selection changed
        /// </summary>
        private void lstSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSprites.SelectedItem == null || !HasData)
                return;

            _frame = 0;
            _sprite = RomData.Sprites.Find(x => x.ID == (lstSprites.SelectedItem as ObjectID).ID);
            _palette = RomData.Palettes.Find(x => x.ID == _sprite.PaletteID);
            _tileset = RomData.Tilesets.Find(x => x.ID == _sprite.TilesetID);
            _tilemap = RomData.Tilemaps.Find(x => x.ID == _sprite.TilemapIDs[_frame]);
            btnPreviousFrame.Enabled = _sprite.TilemapIDs.Count > 1;
            btnNextFrame.Enabled = _sprite.TilemapIDs.Count > 1;
            txtTilesetPosition.Text = _tileset.ID.ToString();
            txtTilesetLength.Text = _tileset.Length.ToString();
            txtTilemapPosition.Text = _tilemap.ID < 0 ? "Custom" : _tilemap.ID.ToString();
            txtTilemapPosition.Enabled = _tilemap.ID >= 0;
            nudTilemapColumns.Value = _tilemap.Columns;
            nudTilemapRows.Value = _tilemap.Rows;
            UpdateImages();
            tabSpriteMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Tab selection changed
        /// </summary>
        private void tabSpriteMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab.Name == tabSprite.Name && _sprite != null)
                SetInfo(_sprite.Name, _sprite.GetInfo(_frame));
            else if (tabMain.SelectedTab.Name == tabTileset.Name && _tileset != null)
                SetInfo(_tileset.Name, _tileset.GetInfo());
            else if (tabMain.SelectedTab.Name == tabTilemap.Name && _tilemap != null)
                SetInfo(_tilemap.Name, _tilemap.GetInfo());
        }

        /// <summary>
        /// Revert button click
        /// </summary>
        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is Button))
                return;
                
            if (MessageBox.Show("Are you sure you want to revert? All changes will be lost.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Button button = sender as Button;
                if (button.Name == btnRevertSprite.Name && _palette != null && _tileset != null && _tilemap != null && _palette != null)
                {
                    _tileset.PixelEdits.Clear();
                    _tilemap.TileEdits.Clear();
                    _palette.ColorEdits.Clear();
                }
                else if (button.Name == btnRevertTileset.Name && _tileset != null)
                    _tileset.PixelEdits.Clear();
                else if (button.Name == btnRevertTilemap.Name && _tilemap != null)
                    _tilemap.TileEdits.Clear();
                else if (button.Name == btnRevertPalette.Name && _palette != null)
                    _palette.ColorEdits.Clear();

                UpdateImages();
            }
        }

        /// <summary>
        /// Import sprite button click
        /// </summary>
        private void btnImportSprite_Click(object sender, EventArgs e)
        {
            if (_sprite == null || _tileset == null || _tilemap == null)
            {
                MessageBox.Show("Select a Sprite to edit.");
                return;
            }
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG Image File|*.png";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (Bitmap image = (Bitmap)Image.FromStream(fs))
                    {
                        List<Color> importColors = Palette.GetColors(image);
                        if (importColors.Count > 16)
                        {
                            MessageBox.Show("The image has more than 16 colors, reduce the image colors and try again.");
                            return;
                        }
                        using (ImportForm form = new ImportForm(image, _palette, importColors, _tileset.Offset, _sprite.PaletteIndex))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                List<Color> colors = GetCurrentPalette();
                                _tileset.PixelEdits = form.Tileset.Pixels;
                                if ((sender as Button).Name == btnImportTileset.Name)
                                {
                                    UpdateImages();
                                    return;
                                }
                                using (Bitmap tilesetImage = _tileset.GetImage(255, colors, _tileset.HasEdits))
                                {
                                    int x = 0;
                                    List<int[]> pixelTiles = Tileset.GetPixelTiles(tilesetImage);
                                    foreach (int id in _sprite.TilemapIDs)
                                    {
                                        Tilemap tilemap = RomData.Tilemaps.Find(o => o.ID == id);
                                        if (tilemap == null)
                                            continue;

                                        if (tilemap.Size.Height > image.Height || tilemap.Size.Width + x > image.Width)
                                        {
                                            MessageBox.Show("The size of the image being imported is not valid to create all the tilemaps for this sprite. Make sure the image is the correct width and height, and try again.");
                                            break;
                                        }
                                        using (Bitmap temp = image.Clone(new Rectangle(new Point(x, image.Height - tilemap.Size.Height), tilemap.Size), PixelFormat.Format32bppArgb))
                                        {
                                            tilemap.TileEdits = Tilemap.GetTilesFromImage(pixelTiles, temp, _tilemap.Offset);
                                        }
                                        x += tilemap.Size.Width;
                                    }
                                    UpdateImages();
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Deletes the selected tile from a tileset
        /// </summary>
        private void btnDeleteTile_Click(object sender, EventArgs e)
        {
            pnlTileset.RemoveSelection();
        }

        /// <summary>
        /// Deselects the selected tile from a tileset
        /// </summary>
        private void btnDeselectTile_Click(object sender, EventArgs e)
        {
            pnlTileset.DeselectSelection();
        }

        /// <summary>
        /// Palette color picker click
        /// </summary>
        private void pnlColorPicker_Click(object sender, EventArgs e)
        {
            if (!HasData || _palette == null || !(sender is ImageControl))
                return;

            Color color = (sender as ImageControl).GetColorUnderMouse();
            color = color.A < 255 ? Color.White : color;
            pnlSelectedColor.BackColor = color;
            lblSelectedColorValues.Text = "Red: " + color.R + " Green: " + color.G + " Blue: " + color.B;
            if (pnlPaletteEdit.SelectedIndex != -1)
            {
                if (_palette.ColorEdits.Count <= 0)
                    _palette.ColorEdits.AddRange(_palette.Colors.ToArray());

                _palette.ColorEdits[pnlPaletteEdit.SelectedIndex] = color;
                UpdateImages();
            }
        }

        /// <summary>
        /// Selected palette color changed
        /// </summary>
        private void pnlPaletteEdit_SelectedColorChanged()
        {
            Color color = pnlPaletteEdit.SelectedColor;
            lblSelectedPaletteColorValues.Text = "Red: " + color.R + " Green: " + color.G + " Blue: " + color.B;
        }

        /// <summary>
        /// Tileset tile changed
        /// </summary>
        private void pnlTileset_TileChanged()
        {
            if (_tileset == null || _palette == null || !HasData)
                return;

            List<Color> palette = GetCurrentPalette();
            if (_tileset.PixelEdits.Count <= 0)
            {
                _tileset.PixelEdits.AddRange(pnlTileset.Pixels.ToArray());
                pnlTileset.SetTileset(_tileset.PixelEdits, palette);
                return;
            }

            _tileset.PixelEdits = pnlTileset.Pixels;
            UpdateImages();
        }

        /// <summary>
        /// Tileset tile selection changed
        /// </summary>
        private void pnlTileset_TileSelectionChanged()
        {
            if (pnlTileset.TileID < 0 || _tileset == null || _palette == null || !HasData)
                return;

            pnlTile.Palette = GetCurrentPalette();
            pnlTile.Pixels = _tileset.GetTilePixels(pnlTileset.TileID);
        }

        /// <summary>
        /// Tileset data update click
        /// </summary>
        private void btnTilesetDataUpdate_Click(object sender, EventArgs e)
        {
            if ( _sprite == null || _tileset == null || !HasData)
                return;

            if (int.TryParse(txtTilesetPosition.Text, out int position))
            {
                _sprite.TilesetID = position;
                _tileset.ID = position;
            }
            if (int.TryParse(txtTilesetLength.Text, out int length))
                _tileset.Length = length;
        }

        /// <summary>
        /// Tilemap data update click
        /// </summary>
        private void btnTilemapUpdate_Click(object sender, EventArgs e)
        {
            if (_sprite == null || _tilemap == null || !HasData)
                return;

            if (int.TryParse(txtTilemapPosition.Text, out int position))
            {
                _sprite.TilemapIDs[_frame] = position;
                _tilemap.ID = position;
            }

            _tilemap.Columns = (int)nudTilemapColumns.Value;
            _tilemap.Rows = (int)nudTilemapRows.Value;
            UpdateImages();
        }

        /// <summary>
        /// Replace tiles button click
        /// </summary>
        private void btnReplaceTiles_Click(object sender, EventArgs e)
        {
            using (ReplaceTilesForm form = new ReplaceTilesForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// Tile selection changed
        /// </summary>
        private void pnlTiles_TileSelectionChanged()
        {
            if (_tilemap == null || _tileset == null || !HasData)
                return;

            pnlTilemap.TileID = pnlTiles.TileID;
            lblSelectedTileIDValue.Text = pnlTiles.TileID.ToString();
        }

        /// <summary>
        /// Tilemap tile has changed
        /// </summary>
        private void pnlTilemap_TileChanged()
        {
            if (!HasData || _sprite == null || _palette == null || _tileset == null || _tilemap == null)
                return;

            if (_tilemap.TileEdits.Count <= 0)
            {
                _tilemap.TileEdits = pnlTilemap.Tiles;
                pnlTilemap.SetTilemap(_tilemap.TileEdits, _tilemap.Columns, _tilemap.Rows);
            }

            List<Color> palette = GetCurrentPalette();
            pnlSprite.Image = Sprite.GetImage(_tileset, _tilemap, palette);
            pnlTilemap.Image = Sprite.GetImage(_tileset, _tilemap, palette);
        }

        /// <summary>
        /// Loads various data
        /// </summary>
        private void LoadData()
        {
            if (!HasData)
                return;

            foreach (ListBox lst in new List<ListBox>() { lstSprites })
            {
                lst.Items.Clear();
                foreach (ObjectID obj in RomData.Sprites)
                    lst.Items.Add(obj);
            }
            foreach (ListBox lst in new List<ListBox>() { lstSprites })
                if (lst.Items.Count > 0)
                    lst.SelectedIndex = 0;

            tabSpriteMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Update image panels based on selections
        /// </summary>
        private void UpdateImages()
        {
            if (!HasData || _sprite == null || _palette == null || _tileset == null || _tilemap == null)
                return;

            List<Color> palette = GetCurrentPalette();
            pnlSprite.Image = Sprite.GetImage(_tileset, _tilemap, palette);
            pnlTilemap.Image = Sprite.GetImage(_tileset, _tilemap, palette);
            pnlTilemap.SetTilemap(_tilemap.HasEdits ? _tilemap.TileEdits : _tilemap.Tiles, _tilemap.Columns, _tilemap.Rows);
            pnlTileset.SetTileset(_tileset.HasEdits ? _tileset.PixelEdits : _tileset.Pixels, palette);
            pnlTiles.Image = _tileset.GetImage(palette, _tileset.HasEdits, 6);
            pnlTiles.TileCount = _tileset.TileCount;
            pnlTiles.Offset = _tilemap.Offset;
            pnlTilemap.TileID = pnlTiles.TileID;
            lblSelectedTileIDValue.Text = pnlTiles.TileID.ToString();
            pnlPaletteEdit.SetPalette(_palette.HasEdits ? _palette.ColorEdits : _palette.Colors);
            tabSpriteMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Sets status bar object information
        /// </summary>
        /// <param name="name">Name of the resource</param>
        /// <param name="info">The information to display</param>
        private void SetInfo(string name, string info)
        {
            tsslObjectType.Text = name + ":";
            tsslInfo.Text = info;
        }

        /// <summary>
        /// Gets the current palette based on ruleset
        /// </summary>
        /// <returns>A list of colors</returns>
        private List<Color> GetCurrentPalette()
        {
            return GetCurrentPalette(_palette, _sprite.PaletteIndex);
        }

        /// <summary>
        /// Gets the current palette based on ruleset
        /// </summary>
        /// <returns>A list of colors</returns>
        private List<Color> GetCurrentPalette(Palette palette, int index)
        {
            List<Color> colors = new List<Color>();
            colors.AddRange(palette.HasEdits ? palette.ColorEdits.ToArray() : palette.Colors.ToArray());
            if (index == 1)
                colors.RemoveRange(0, 16);
            return colors;
        }
    }
}
