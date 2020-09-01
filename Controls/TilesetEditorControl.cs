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
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using GoldenAxeEditor.Data;

namespace GoldenAxeEditor.Controls
{
    public partial class TilesetEditControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileSelectionHandler TileSelectionChanged;
        public delegate void TileSelectionHandler();
        public event TilesChangedHandler TilesChanged;
        public delegate void TilesChangedHandler();
        private List<byte> _pixels = new List<byte>();
        private List<Color> _palette = new List<Color>();
        private Timer _antsTimer = new Timer();
        private Rectangle _selection = new Rectangle();
        private int _target = -1;
        private int _source = -1;
        private int _antOffset = 0;
        private bool _useGrid = true;
        private bool _indexed = false;

        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get { return _source; } }
        public List<byte> Pixels { get { return _pixels; } }
        public List<Color> Palette { set { _palette = value; } }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool Indexed 
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                MinimumScale = _indexed ? 3 : 1;
                ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public TilesetEditControl()
        {
            InitializeComponent();
            UseCanvas = true;
            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (_pixels == null || _pixels.Count <= 0)
                return;

            DrawTiles(gfx, origin);
            DrawGrid(gfx, origin);
            DrawSelection(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Canvas == null || _pixels.Count <= 0)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Canvas.Width * ImageScale, Canvas.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            int x = (e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height;
            Rectangle selection = new Rectangle(new Point(x, y), SnapSize);
            int cols = Canvas.Width / SnapSize.Width;
            int col = selection.X / SnapSize.Width;
            int row = selection.Y / SnapSize.Height;
            int tileID = (row * cols) + col;
            int count = _pixels.Count / (SnapSize.Width * SnapSize.Height);
            if (tileID >= count)
                return;

            _selection = selection;
            if (e.Button == MouseButtons.Right)
            {
                _source = tileID;
                TileSelectionChanged?.Invoke();
                return;
            }
            if (_source == -1)
            {
                _source = tileID;
                TileSelectionChanged?.Invoke();
            }
            else
            {
                _target = tileID;
                SwapTiles();
            }
            UpdateBackBuffer();
        }

        /// <summary>
        /// Draws the selected tiles rectangles
        /// </summary>
        private void DrawSelection(Graphics gfx, Point origin)
        {
            if (_selection == Rectangle.Empty)
                return;

            using (Pen pen = new Pen(Color.White, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 4, 4 };
                pen.DashOffset = _antOffset;
                Rectangle rect = _selection;
                rect.X += origin.X;
                rect.Y += origin.Y;
                gfx.DrawRectangle(Pens.Black, rect);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Draws all the tiles
        /// </summary>
        private void DrawTiles(Graphics gfx, Point origin)
        {
            if (_pixels.Count <= 0)
                return;

            using (Bitmap tileset = Tileset.GetImage(_pixels, (Indexed ? (byte)128 : (byte)255), _palette, 16))
            {
                gfx.DrawImage(tileset, origin);
            }
        }

        /// <summary>
        /// Draw grid cells
        /// </summary>
        private void DrawGrid(Graphics gfx, Point origin)
        {
            if (!UseGrid || _pixels.Count <= 0)
                return;

            int cols = (int)Math.Ceiling(Canvas.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Ceiling(Canvas.Height / (double)(SnapSize.Height));
            Rectangle cell = new Rectangle(0, 0, SnapSize.Width, SnapSize.Height);
            using (Pen gridPen = new Pen(Color.FromArgb(80, Color.Black)))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        cell.X = (col * SnapSize.Width) + origin.X;
                        cell.Y = (row * SnapSize.Height) + origin.Y;
                        gfx.DrawRectangle(gridPen, cell);
                    }
                }
            }
        }

        /// <summary>
        /// Draws tile indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (!Indexed || _pixels.Count <= 0)
                return;

            int index = 0;
            int count = _pixels.Count / (SnapSize.Width * SnapSize.Height);
            int size = SnapSize.Width * SnapSize.Height;
            int cols = (int)Math.Ceiling(Canvas.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Ceiling(Canvas.Height / (double)(SnapSize.Height));
            Font font = new Font("Segoe UI", 5 + ImageScale, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (index < count)
                    {
                        Point point = new Point((col * SnapSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                        gfx.DrawString(index.ToString(), font, Brushes.Black, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Swaps tiles from the selection grid
        /// </summary>
        private void SwapTiles()
        {
            if (_target == -1 || _source == -1 || _target == _source)
            {
                DeselectSelection();
                return;
            }

            int size = SnapSize.Width * SnapSize.Height;
            List<byte> source = Tileset.GetTilePixels(_source, _pixels);
            _pixels.RemoveRange(_source * size, size);
            List<byte> target = Tileset.GetTilePixels(_target, _pixels);
            _pixels.RemoveRange(_target * size, size);
            _pixels.InsertRange(_target * size, source);
            _pixels.InsertRange(_source * size, target);
            TilesChanged?.Invoke();
            DeselectSelection();
        }

        /// <summary>
        /// Resets selection variables
        /// </summary>
        public void DeselectSelection()
        {
            _target = -1;
            _source = -1;
            _selection = Rectangle.Empty;
            UpdateBackBuffer();
        }

        /// <summary>
        /// Removes selected tile
        /// </summary>
        public void RemoveSelection()
        {
            if (_pixels.Count <= 0 || _source <= -1)
                return;

            int size = SnapSize.Width * SnapSize.Height;
            _pixels.RemoveRange(_source * size, size);
            TilesChanged?.Invoke();
            DeselectSelection();
        }

        /// <summary>
        /// Marching ants timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _antOffset++;

            if (_antOffset % 8 == 0)
                _antOffset = 0;

            if (_selection != Rectangle.Empty)
                UpdateBackBuffer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pixels"></param>
        /// <param name="palette"></param>
        public void SetTileset(List<byte> pixels, List<Color> palette)
        {
            Canvas = pixels.Count < 16 * 64 ? new Size(128, 8) :  new Size(128, pixels.Count / 128);
            _palette = palette;
            _pixels = pixels;
            DeselectSelection();
            UpdateBackBuffer();
        }
    }
}
