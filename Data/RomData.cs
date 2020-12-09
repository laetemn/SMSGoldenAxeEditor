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
using System.Collections;
using System.Collections.Generic;

namespace GoldenAxeEditor.Data
{
    [Serializable]
    public class RomData
    {
        /// <summary>
        /// Fields
        /// </summary>
        private readonly Dictionary<byte, byte> _colorValues = new Dictionary<byte, byte> { { 0, 0 },  { 1, 85 }, { 2, 170 },  { 3, 255 } };

    /// <summary>
    /// Properties
    /// </summary>
    public List<byte> Data = new List<byte>();
        public List<Sprite> Sprites = new List<Sprite>();
        public List<Palette> Palettes = new List<Palette>();
        public List<Tileset> Tilesets = new List<Tileset>();
        public List<Tilemap> Tilemaps = new List<Tilemap>();
        public List<ByteWrite> ByteWrites = new List<ByteWrite>();

        /// <summary>
        /// Constructors
        /// </summary>
        public RomData() { }
        public RomData(string path)
        {
            Data.AddRange(File.ReadAllBytes(path));
            LoadTilemapData();
            LoadPaletteData();
            LoadTilesetData();
            LoadSpriteData();
        }

        /// <summary>
        /// Loads palette data
        /// </summary>
        private void LoadPaletteData()
        {
            // Palette data stored as enumerations
            foreach (PaletteType e in Enum.GetValues(typeof(PaletteType)))
                Palettes.Add(new Palette(e));

            foreach (Palette palette in Palettes)
            {
                byte[] data = Data.GetRange(palette.ID, palette.Length).ToArray();
                palette.Colors.AddRange(GetColors(data));
                if (palette.Colors.Count < 32)
                {
                    for (int i = palette.Colors.Count; i < 32 - palette.Offset; i++)
                        palette.Colors.Add(Color.Black);

                    for (int j = 0; j < palette.Offset; j++)
                        palette.Colors.Insert(0, Color.Black);
                }
            }

            // Insert offset palette colors if any
            foreach (Palette palette in Palettes)
            {
                Palette source = Palettes.Find(x => x.ID == palette.OffsetID);
                if (palette.OffsetID <= 0 || source == null)
                    continue;

                palette.Colors.RemoveRange(0, palette.Offset);
                palette.Colors.InsertRange(0, source.Colors.GetRange(0, palette.Offset));
            }
        }

        /// <summary>
        /// Loads tileset data
        /// </summary>
        private void LoadTilesetData()
        {
            // Tileset data stored as enumerations
            foreach (TilesetType e in Enum.GetValues(typeof(TilesetType)))
                Tilesets.Add(new Tileset(e));

            foreach (Tileset tileset in Tilesets)
            {
                //if (tileset.TilesetType == TilesetType.Tileset4FEEF)
                //{
                    byte[] data = Data.GetRange(tileset.ID, tileset.Length).ToArray();
                    //string hex = string.Empty;
                    //foreach (byte b in data)
                    //    hex += " " + b.ToString();
                    data = Decompress(tileset.Compression, data);
                    tileset.DecompressedLength = data.Length;
                    byte[] row = new byte[4];
                    for (int i = 0; i < data.Length; i += 4)
                    {
                        for (int j = 0; j < 4; j++)
                            if (i + j < data.Length)
                                row[j] = data[i + j];
                            else
                                break;

                        for (int k = 7; k > -1; k--)
                        {
                            byte pixel = GetPixel(row, k);
                            if (tileset.Masked)
                                pixel = pixel == 1 ? (byte)0 : (byte)(pixel / 2);
                            tileset.Pixels.Add(pixel);
                        }
                    }
                //}
            }
        }

        /// <summary>
        /// Loads tilemap data
        /// </summary>
        private void LoadTilemapData()
        {
            // Tilemap data stored as enumerations
            foreach (TilemapType e in Enum.GetValues(typeof(TilemapType)))
                Tilemaps.Add(new Tilemap(e));

            foreach (Tilemap tilemap in Tilemaps)
            {
                if (tilemap.ID < 0)
                    tilemap.SetSequentialTiles();
                else
                {
                    byte[] data = Data.GetRange(tilemap.ID, tilemap.Length).ToArray();
                    data = Decompress(tilemap.Compression, data);
                    tilemap.DecompressedLength = data.Length;
                    if (tilemap.UseFlags)
                    {
                        for (int i = 0; i < data.Length; i += 2)
                        {
                            byte b1 = data[i];
                            byte b2 = data[i + 1];
                            Tile tile = new Tile
                            {
                                FlipX = (b2 & (1 << 1)) != 0,
                                FlipY = (b2 & (1 << 2)) != 0,
                                PaletteIndex = (b2 & (1 << 3)) != 0 ? 1 : 0,
                                Priority = (b2 & (1 << 4)) != 0,
                                Flags = GetTileFlags(b2),
                                TileID = GetTileID(b1, b2)
                            };
                            tilemap.Tiles.Add(tile);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            byte b1 = data[i];
                            Tile tile = new Tile { TileID = b1 };
                            tilemap.Tiles.Add(tile);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Loads sprite data (tileset, palette, and tilemap data required)
        /// </summary>
        private void LoadSpriteData()
        {
            // Sprite data stored as enumerations
            foreach (SpriteType e in Enum.GetValues(typeof(SpriteType)))
                Sprites.Add(new Sprite(e));
        }

        /// <summary>
        /// Exports the edit data into a .sms file
        /// </summary>
        /// <param name="path">The file path to export to</param>
        public void ExportData(string path)
        {
            List<byte> data = new List<byte>();
            data.AddRange(Data.ToArray());
            foreach (Palette palette in Palettes)
            {
                if (!palette.HasEdits)
                    continue;

                data.RemoveRange(palette.ID, palette.Length);
                byte[] bytes = palette.GetEditData();
                data.InsertRange(palette.ID, bytes);
            }
            foreach (Tileset tileset in Tilesets)
            {
                if (!tileset.HasEdits || tileset.Compression != CompressionType.None)
                    continue;

                data.RemoveRange(tileset.ID, tileset.Length);
                byte[] bytes = tileset.GetEditData();
                data.InsertRange(tileset.ID, bytes);
            }
            foreach (Tilemap tilemap in Tilemaps)
            {
                if (!tilemap.HasEdits || tilemap.ID < 0 || tilemap.Compression != CompressionType.None)
                    continue;

                if ((EnumMethods.GetColumns(tilemap.TilemapType) != tilemap.Columns || EnumMethods.GetRows(tilemap.TilemapType) != tilemap.Rows) && tilemap.Compression == CompressionType.None)
                {
                    data[tilemap.ID - 2] = (byte)tilemap.Rows;
                    data[tilemap.ID - 1] = (byte)tilemap.Columns;
                }
                data.RemoveRange(tilemap.ID, tilemap.Length);
                byte[] bytes = tilemap.GetEditData();
                data.InsertRange(tilemap.ID, bytes);
            }

            File.WriteAllBytes(path, data.ToArray());
        }

        /// <summary>
        /// Decompresses the given bytes using the given compression type
        /// </summary>
        /// <param name="type">The type of compression algorithm</param>
        /// <param name="data">The data to decompress</param>
        /// <returns>Decompressed tileset</returns>
        private byte[] Decompress(CompressionType type, byte[] data)
        {
            switch (type)
            {
                case CompressionType.Planar: return ObjectID.DecompressPlanar(data);
                case CompressionType.Linear: return ObjectID.DecompressLinear(data);
                default: return data;
            }
        }

        /// <summary>
        /// Gets a pixel color index (4bpp planar)
        /// </summary>
        /// <param name="bitPlanes">The bit planes to combine into a color index</param>
        /// <param name="bit">The bit we're combining</param>
        /// <returns>A single pixel color index</returns>
        private byte GetPixel(byte[] bitPlanes, int bit)
        {
            bool[] bits = new bool[4];
            bits[0] = (bitPlanes[0] & (1 << bit)) != 0 ? true : false;
            bits[1] = (bitPlanes[1] & (1 << bit)) != 0 ? true : false;
            bits[2] = (bitPlanes[2] & (1 << bit)) != 0 ? true : false;
            bits[3] = (bitPlanes[3] & (1 << bit)) != 0 ? true : false;
            byte[] result = new byte[1];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0];
        }

        /// <summary>
        /// Gets the tile id from the given bytes (9 bit value)
        /// </summary>
        /// <param name="byte1">The upper byte</param>
        /// <param name="byte2">The lower byte</param>
        /// <returns></returns>
        private int GetTileID(byte byte1, byte byte2)
        {
            bool[] bits = new bool[9];
            bits[0] = (byte1 & (1 << 0)) != 0 ? true : false;
            bits[1] = (byte1 & (1 << 1)) != 0 ? true : false;
            bits[2] = (byte1 & (1 << 2)) != 0 ? true : false;
            bits[3] = (byte1 & (1 << 3)) != 0 ? true : false;
            bits[4] = (byte1 & (1 << 4)) != 0 ? true : false;
            bits[5] = (byte1 & (1 << 5)) != 0 ? true : false;
            bits[6] = (byte1 & (1 << 6)) != 0 ? true : false;
            bits[7] = (byte1 & (1 << 7)) != 0 ? true : false;
            bits[8] = (byte2 & (1 << 0)) != 0 ? true : false;
            byte[] result = new byte[2];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0] + result[1];
        }

        /// <summary>
        /// Gets tile attribute flags (0 = false, 1 = true)
        /// </summary>
        /// <param name="b1">The byte to retrieve flag bits from</param>
        /// <returns>A string representation of the tile data</returns>
        private string GetTileFlags(byte b1)
        {
            string flags = "";
            flags += (b1 & (1 << 1)) != 0 ? "1" : "0"; // X flip
            flags += (b1 & (1 << 2)) != 0 ? "1" : "0"; // Y flip
            flags += (b1 & (1 << 3)) != 0 ? "1" : "0"; // Palette index
            flags += (b1 & (1 << 4)) != 0 ? "1" : "0"; // Priority
            return flags == "0000" ? string.Empty : flags;
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        private List<Color> GetColors(byte[] data)
        {
            List<Color> colors = new List<Color>();
            foreach (byte b in data)
                colors.Add(GetColor(b));
            return colors;
        }

        /// <summary>
        /// Gets a color from the given byte 00BBGGRR 2 bits per color channel (6 bit, first 2 bits are ignored)
        /// </summary>
        /// <param name="b">Color byte value</param>
        /// <returns>A .net color</returns>
        private Color GetColor(byte b)
        {
            List<byte> rgb = new List<byte>();
            for (int i = 0; i < 6; i +=2)
            {
                byte[] channel = new byte[1];
                bool[] bits = new bool[2];
                bits[0] = (b & (1 << i)) != 0 ? true : false;
                bits[1] = (b & (1 << (i + 1))) != 0 ? true : false;
                BitArray arr = new BitArray(bits);
                arr.CopyTo(channel, 0);
                rgb.Add(channel[0]);
            }
            return Color.FromArgb(_colorValues[rgb[0]], _colorValues[rgb[1]], _colorValues[rgb[2]]);
        }
    }
}
