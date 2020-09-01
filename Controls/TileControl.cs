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
    public partial class TileControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        List<byte> _pixels = new List<byte>();
        List<Color> _palette = new List<Color>();

        /// <summary>
        /// Properties
        /// </summary>
        public List<byte> Pixels {  get { return _pixels; } set { _pixels = value; UpdateBackBuffer(); } }
        public List<Color> Palette { get { return _palette; } set { _palette = value; UpdateBackBuffer(); } }

        /// <summary>
        /// 
        /// </summary>
        public TileControl()
        {
            InitializeComponent();
            UseCanvas = true;
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            DrawPixels(gfx);
        }

        /// <summary>
        /// Draws a grid based on grid size
        /// </summary>
        private void DrawPixels(Graphics gfx)
        {
            if (_pixels.Count <= 0)
                return;

            Size snap = new Size(ClientSize.Width / 8, ClientSize.Height / 8);
            int index = 0;
            int cols = (int)Math.Floor(ClientSize.Width / (double)(snap.Width));
            int rows = (int)Math.Floor(ClientSize.Height / (double)(snap.Height));
            Rectangle cell = new Rectangle(0, 0, snap.Width, snap.Height);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    using (SolidBrush brush = new SolidBrush(_palette[_pixels[index]]))
                    {
                        cell.X = col * snap.Width;
                        cell.Y = row * snap.Height;
                        gfx.FillRectangle(brush, cell);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Draws tile indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (_pixels.Count <= 0)
                return;

            int index = 0;
            Size snap = new Size(ClientSize.Width / 8, ClientSize.Height / 8);
            Font black = new Font("Segoe UI", 9, FontStyle.Bold);
            Font white = new Font("Segoe UI", 7, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (index < _pixels.Count)
                    {
                        Point point = new Point((col * snap.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * snap.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (snap.Width + 1) * ImageScale, (snap.Height + 1) * ImageScale);
                        gfx.DrawString(_pixels[index].ToString(), black, Brushes.Black, rect, format);
                        gfx.DrawString(_pixels[index].ToString(), white, Brushes.White, rect, format);
                    }
                    index++;
                }
            }
        }
    }
}
