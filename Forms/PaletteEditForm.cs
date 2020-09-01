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
using System.Collections.Generic;
using GoldenAxeEditor.Data;
using GoldenAxeEditor.Controls;

namespace GoldenAxeEditor.Forms
{
    public partial class PaletteEditForm : Form
    {
        // Fields
        private MainForm _parent = null;
        private Palette _palette = null;

        // Properties
        private bool HasData { get { return _parent != null && _parent.HasData; } }
        private RomData RomData { get { return _parent.RomData; } }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="parent"></param>
        public PaletteEditForm(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadData();
        }

        /// <summary>
        /// Palette selection changed
        /// </summary>
        private void lstPalettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || lstPalettes.SelectedItem == null)
                return;

            _palette = RomData.Palettes.Find(x => x.ID == (lstPalettes.SelectedItem as ObjectID).ID);
            List<Color> palette = _palette.HasEdits ? _palette.ColorEdits : _palette.Colors;
            pnlPaletteEdit.SetPalette(palette);
        }

        /// <summary>
        /// Palette color picker click
        /// </summary>
        private void pnlColorPicker_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ImageControl) || _palette == null)
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
                List<Color> palette = _palette.HasEdits ? _palette.ColorEdits : _palette.Colors;
                pnlPaletteEdit.SetPalette(palette);
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
        /// Loads various data
        /// </summary>
        private void LoadData()
        {
            if (!HasData)
                return;

            foreach (ListBox lst in new List<ListBox>() { lstPalettes })
            {
                lst.Items.Clear();
                foreach (ObjectID obj in RomData.Palettes)
                    lst.Items.Add(obj);
            }
            foreach (ListBox lst in new List<ListBox>() { lstPalettes })
                if (lst.Items.Count > 0)
                    lst.SelectedIndex = 0;
        }
    }
}
