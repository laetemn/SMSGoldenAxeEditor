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
    public partial class ColorEditControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event ColorShiftedHandler ColorShifted;
        public delegate void ColorShiftedHandler();
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
        public Color SelectedColor { get { return _selected == null ? Color.Black : _selected.BackColor; } }
        public byte[] ShiftedIndexes { get; private set; } = new byte[] { 0, 0 };

        /// <summary>
        /// Constructors
        /// </summary>
        public ColorEditControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnShift_Click(object sender, EventArgs e)
        {
            if (_selected == null || !(sender is Button))
                return;

            int shift = 0;
            Button button = sender as Button;
            if (button.Name == btnLeft.Name && _index > 0)
                shift = -1;
            else if (button.Name == btnRight.Name && _index < 15)
                shift = 1;

            if (shift == 0)
                return;

            int source = _index;
            Color sourceColor = _selected.BackColor;
            _index += shift;
            ImageControl target = Controls.Find("pnlColor" + _index, true)[0] as ImageControl;
            _selected.BackColor = target.BackColor;
            target.BackColor = sourceColor;
            ShiftedIndexes = new byte[] { (byte)source, (byte)_index };
            pnlColor_Click(target, EventArgs.Empty);
            ColorShifted?.Invoke();
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
            _index = Convert.ToInt32(_selected.Tag);
            SelectedColorChanged?.Invoke();
        }

        /// <summary>
        /// Sets the palette control's color palette
        /// </summary>
        /// <param name="palette"></param>
        public void SetPalette(List<Color> import, Bitmap palette)
        {
            if (_selected != null)
            {
                _selected.Selected = false;
                _selected = null;
            }
            if (import.Count < 16)
                for (int i = import.Count - 1; i < 16; i++)
                    import.Add(Color.Transparent);

            for (int i = 0; i < 16; i++)
                (Controls.Find("pnlColor" + i, true)[0] as Panel).BackColor = import[i];

            pnlTargetPalette.Image = palette;
        }

        /// <summary>
        /// Sets the selected panel's coclor
        /// </summary>
        /// <param name="color">The color to set for the selected panel</param>
        public void SetColor(Color color)
        {
            if (_selected != null)
                _selected.BackColor = color;
        }
    }
}
