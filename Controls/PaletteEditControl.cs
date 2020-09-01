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

namespace GoldenAxeEditor.Controls
{
    public partial class PaletteEditControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event SelectedColorChangedHandler SelectedColorChanged;
        public delegate void SelectedColorChangedHandler();
        private int _index = 0;
        private ColorControl _selected = null;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> Colors
        {
            get
            {
                List<Color> colors = new List<Color>();
                for (int i = 0; i < 16; i++)
                    colors.Add((Controls.Find("pnlColor" + _index, true)[0] as Control).BackColor);

                return colors;
            }
        }
        public int SelectedIndex { get { return _selected == null ? -1 : Convert.ToInt32(_selected.Tag); } }
        public Color SelectedColor { get { return _selected == null ? Color.White : _selected.BackColor; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public PaletteEditControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Color click
        /// </summary>
        private void pnlColor_Click(object sender, EventArgs e)
        {
            if (_selected != null)
                _selected.Selected = false;

            _selected = sender as ColorControl;
            _selected.Selected = true;
            SelectedColorChanged?.Invoke();
        }

        /// <summary>
        /// Sets the palette control's color palette
        /// </summary>
        /// <param name="palette"></param>
        public void SetPalette(List<Color> palette)
        {
            if (_selected != null)
            {
                _selected.Selected = false;
                _selected = null;
            }
            if (palette.Count < 32)
                for (int i = palette.Count - 1; i < 32; i++)
                    palette.Add(Color.Black);

            for (int i = 0; i < 32; i++)
                (Controls.Find("pnlColor" + i, true)[0] as Panel).BackColor = palette[i];
        }
    }
}
