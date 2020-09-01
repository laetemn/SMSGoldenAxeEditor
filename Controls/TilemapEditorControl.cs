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

namespace GoldenAxeEditor.Controls
{
    public partial class TilemapEditControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileChangedHandler TileChanged;
        public delegate void TileChangedHandler();
        private bool _useGrid = true;
        private bool _indexed = false;
        private int _columns = 0;
        private int _rows = 0;
        private List<Tile> _tiles = new List<Tile>();

        /// <summary>
        /// Properties
        /// </summary>
        public List<Tile> Tiles
        {
            get
            {
                List<Tile> tiles = new List<Tile>();
                foreach (Tile tile in _tiles)
                    tiles.Add(tile.Clone());
                return tiles; 
            }
        }
        public int TileID { private get; set; } = -1;
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool Indexed
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                MinimumScale = _indexed ? 3 : 1;
                ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                ImageAlpha = _indexed ? 0.5F : 1F;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public TilemapEditControl()
        {
            InitializeComponent();
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
            if (Image == null || _tiles.Count <= 0)
                return;

            DrawGrid(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || _tiles.Count <= 0 || TileID < 0)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            int x = (e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height;
            Rectangle selection = new Rectangle(new Point(x, y), SnapSize);
            int cols = Image.Width / SnapSize.Width;
            int col = selection.X / SnapSize.Width;
            int row = selection.Y / SnapSize.Height;
            int index = (row * cols) + col;
            if (index >= _tiles.Count)
                return;

            _tiles[index].TileID = TileID;
            TileChanged?.Invoke();
        }

        /// <summary>
        /// Draw grid cells
        /// </summary>
        private void DrawGrid(Graphics gfx, Point origin)
        {
            if (!UseGrid || Image == null || _tiles.Count <= 0)
                return;

            int cols = (int)Math.Floor(Image.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Floor(Image.Height / (double)(SnapSize.Height));
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
            if (!Indexed || Image == null || _tiles.Count <= 0)
                return;

            int index = 0;
            Font font = new Font("Segoe UI", 5 + ImageScale, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    if (index < _tiles.Count && _tiles[index] != null)
                    {
                        Point point = new Point((col * SnapSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                        gfx.DrawString(_tiles[index].TileID.ToString(), font, Brushes.Black, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Sets the tile map data
        /// </summary>
        /// <param name="tilemap">The tile map data to set</param>
        public void SetTilemap(List<Tile> tiles, int cols, int rows)
        {
            _columns = cols;
            _rows = rows;
            _tiles = tiles;
            UpdateBackBuffer();
        }
    }
}
