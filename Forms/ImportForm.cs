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
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using GoldenAxeEditor.Data;

namespace GoldenAxeEditor.Forms
{
    public partial class ImportForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Bitmap _image = null;
        private Palette _palette = null;
        private List<Color> _colors = new List<Color>();
        private int _paletteIndex = 0;

        /// <summary>
        /// Properties
        /// </summary>
        public Tileset Tileset { get; set; } = null;
        public bool IgnoreEmpty { get { return chkIgnoreEmpty.Checked; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="palette"></param>
        /// <param name="importColors"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        public ImportForm(Bitmap image, Palette palette, List<Color> importColors, int offset, int paletteIndex)
        {
            InitializeComponent();
            Tileset = new Tileset();
            Tileset.Pixels = Tileset.GetSMSTiles(image, importColors, false, false);
            Tileset.Offset = offset;
            _colors = importColors;
            _image = image;
            _paletteIndex = paletteIndex;
            List<Color> colors = GetCurrentPalette(palette, paletteIndex);
            pnlTiles.Image = Tileset.GetImage(colors, false, 6);
            _palette = palette;
            pnlColorIndexes.SetPalette(importColors, palette.GetPaletteImage(paletteIndex == 0 ? 0 : 16, palette.HasEdits));
        }

        /// <summary>
        /// Ignore empties check changed
        /// </summary>
        private void chkIgnoreEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (_image == null)
                return;

            Tileset.Pixels = Tileset.GetSMSTiles(_image, _colors, false, chkIgnoreEmpty.Checked);
            pnlTiles.Image = Tileset.GetImage(_palette.Colors, false, 6);
            pnlColorIndexes.SetPalette(_colors, _palette.GetPaletteImage(_paletteIndex == 0 ? 0 : 16, _palette.HasEdits));
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            int pixels = 64 * Tileset.Offset;
            for (int i = 0; i < pixels; i++)
                Tileset.Pixels.Insert(0, 0);

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cancel button click
        /// </summary>
        private void butCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Color indexes have shifted
        /// </summary>
        private void pnlColorIndexes_ColorShifted()
        {
            byte[] shifts = pnlColorIndexes.ShiftedIndexes;
            List<int> sources = new List<int>();
            List<int> targets = new List<int>();
            for (int i = 0; i < Tileset.Pixels.Count; i++)
                if (Tileset.Pixels[i] == shifts[0])
                    sources.Add(i);

            for (int i = 0; i < Tileset.Pixels.Count; i++)
                if (Tileset.Pixels[i] == shifts[1])
                    targets.Add(i);

            foreach (int source in sources)
                Tileset.Pixels[source] = shifts[1];

            foreach (int target in targets)
                Tileset.Pixels[target] = shifts[0];

            List<Color> colors = GetCurrentPalette(_palette, _paletteIndex);
            pnlTiles.Image = Tileset.GetImage(colors, false, 6);
        }

        /// <summary>
        /// Gets the current palette based on ruleset
        /// </summary>
        /// <returns>A list of colors</returns>
        private List<Color> GetCurrentPalette(Palette palette, int paletteIndex)
        {
            List<Color> colors = new List<Color>();
            colors.AddRange(palette.HasEdits ? palette.ColorEdits.ToArray() : palette.Colors.ToArray());
            if (paletteIndex == 1)
                colors.RemoveRange(0, 16);
            return colors;
        }
    }
}
