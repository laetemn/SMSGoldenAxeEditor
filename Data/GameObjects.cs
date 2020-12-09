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
using System.Collections;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace GoldenAxeEditor.Data
{
    /// <summary>
    /// Inherited game object id
    /// </summary>
    [Serializable]
    public class ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public CompressionType Compression { get; set; } = CompressionType.None; // Compression used for this object, if any
        public int ID { get; set; } = -1; // Usually the byte location in the ROM, negative number if not part of the original ROM data, but needs to be displayed for edit
        public string Name { get; set; } = ""; // The name of the object, typically the type name followed by the hex value of the ID
        public int DataStart { get; set; } = 0; // The starting byte location of the object in the ROM
        public int DataEnd { get; set; } = 0; // The ending byte location of the object in the ROM
        public int Length { get; set; } = 0; // The size, in bytes of the object in the ROM (Compressed or otherwise)
        public bool Override { get; set; } = false; // Overrides the data length safe guard when exporting to an .sms
        public int DecompressedLength { get; set; } = 0; // The length of the data when decompressed
        public string DataStartString { get { return DataStart.ToString("X") + " (" + DataStart + ")"; } } // Quality of life string for data start
        public string DataEndString { get { return DataEnd.ToString("X") + " (" + DataEnd + ")"; } } // Quality of life string for data end

        /// <summary>
        /// Constructors
        /// </summary>
        public ObjectID() { }
        public ObjectID(int id, string name) { ID = id; Name = name; }

        /// <summary>
        /// Makes sure the given bytes (For export) are either truncated by the original ROM length, 
        /// padded if not enough bytes, or overridden if the length is bigger than the original ROM length
        /// </summary>
        /// <param name="bytes">The bytes to inspect</param>
        /// <returns>A ROM safe array of bytes, unless overridden</returns>
        public byte[] GetVerifiedBytes(List<byte> bytes)
        {
            //if (Compression == CompressionType.PhantasyStarRLE)
            //{
            //    byte[] compressed = PSRLECompress(bytes.ToArray());
            //    bytes.Clear();
            //    bytes.AddRange(compressed);
            //}

            if (bytes.Count < Length)
            {
                int pad = Length - bytes.Count;
                for (int i = 0; i < pad; i++)
                    bytes.Add(0);
            }
            else if (bytes.Count > Length && !Override)
                bytes = bytes.GetRange(0, Length);

            return bytes.ToArray();
        }

        /// <summary>
        /// Phantasy Star RLE compression Refer to: https://www.smspower.org/Development/Compression
        /// </summary>
        /// <param name="data">The bytes to compress</param>
        /// <returns>A compressed byte array of bytes</returns>
        public static byte[] CompressPlanar(byte[] data)
        {
            List<byte> compressed = new List<byte>();
            List<byte>[] bitPlanes = new List<byte>[4];
            for (int j = 0; j < bitPlanes[0].Count; j++)
                for (int k = 0; k < 4; k++)
                    if (j < bitPlanes[k].Count)
                        bitPlanes[k][j] = data[j];


            //List<byte> compressed = new List<byte>();
            //for (int i = 0; i < 4; i++)
            //{
            //    int index = i;
            //    while (index < data.Length)
            //    {
            //        int similarByteCount = 1;
            //        int uniqueByteCount = 1;
            //        byte uniqueByte = 0;
            //        List<byte> uniqueBytes = new List<byte>();
            //        for (int j = 0; j < data.Length; j++)
            //        {
            //            if (uniqueByteCount > 1)
            //            {
            //                if ((data[i] == data[i - 4]) && (i + 4 < data.Length) && (data[i] == data[i + 4]) || (uniqueByteCount == 127))
            //                {
            //                    uniqueByteCount--;
            //                    uniqueBytes.RemoveAt(uniqueBytes.Count - 1);
            //                    i--;
            //                    break;
            //                }
            //                else
            //                {
            //                    uniqueByteCount++;
            //                    uniqueBytes.Add(data[i]);
            //                }
            //            }
            //            else if (similarByteCount > 1)
            //            {
            //                if (data[i] != data[i - 4] || similarByteCount == 127)
            //                {
            //                    i--;
            //                    break;
            //                }
            //                else
            //                    similarByteCount++;
            //            }
            //            else
            //            {
            //                if (data[i] == data[i - 4])
            //                {
            //                    uniqueByteCount = 0;
            //                    similarByteCount = 2;
            //                    uniqueByte = data[i];
            //                }
            //                else
            //                {
            //                    uniqueByteCount = 2;
            //                    similarByteCount = 0;
            //                    uniqueBytes.Add(data[i - 4]);
            //                    uniqueBytes.Add(data[i]);
            //                }
            //            }
            //        }

            //        if (similarByteCount > 1)
            //        {
            //            compressed.Add((byte)similarByteCount);
            //            compressed.Add(uniqueByte);
            //            index += similarByteCount * 4;
            //        }
            //        else
            //        {
            //            compressed.Add((byte)(uniqueByteCount + 128));
            //            for (int j = 0; j < uniqueBytes.Count; j++)
            //                compressed.Add(uniqueBytes[j]);

            //            index += uniqueByteCount * 4;
            //        }
            //    }
            //    compressed.Add(0);
            //}
            return compressed.ToArray();
        }

        /// <summary>
        /// Phantasy Star RLE decompression, data arranged in bit planes
        /// Refer to: https://www.smspower.org/Development/Compression
        /// </summary>
        /// <param name="data">The bytes to decompress</param>
        /// <returns>A decompressed byte array of bytes</returns>
        public static byte[] DecompressPlanar(byte[] data)
        {
            int index = 0;
            int count;
            byte value;
            List<byte>[] bitPlanes = new List<byte>[4];
            for (int i = 0; i < 4; i++)
            {
                bitPlanes[i] = new List<byte>();
                while (index < data.Length && data[index] != 0)
                {
                    if (data[index] < 128)
                    {
                        count = data[index];
                        index++;
                        value = data[index];
                        index++;
                        for (int j = 0; j < count; j++)
                            bitPlanes[i].Add(value);
                    }
                    else
                    {
                        count = data[index] - 128;
                        index++;
                        for (int j = 0; j < count; j++)
                        {
                            value = data[index];
                            bitPlanes[i].Add(value);
                            index++;
                        }
                    }
                }
                index++;
            }
            List<byte> decompressed = new List<byte>();
            for (int j = 0; j < bitPlanes[0].Count; j++)
                for (int k = 0; k < 4; k++)
                    if (j < bitPlanes[k].Count)
                        decompressed.Add(bitPlanes[k][j]);

            return decompressed.ToArray();
        }

        /// <summary>
        /// Phantasy Star RLE decompression, data arranged in linear fashion
        /// Refer to: https://www.smspower.org/Development/Compression
        /// </summary>
        /// <param name="data">The bytes to compress</param>
        /// <returns>A linear compressed byte array</returns>
        public static byte[] CompressLinear(byte[] data)
        {
            List<byte> compressed = new List<byte>();
            int index = 0;
            int count;
            byte value;
            while (index < data.Length && data[index] != 0)
            {
                if (data[index] < 128)
                {
                    count = data[index];
                    index++;
                    value = data[index];
                    index++;
                    for (int j = 0; j < count; j++)
                        compressed.Add(value);
                }
                else
                {
                    count = data[index] - 128;
                    index++;
                    for (int j = 0; j < count; j++)
                    {
                        value = data[index];
                        compressed.Add(value);
                        index++;
                    }
                }
            }
            return compressed.ToArray();
        }

        /// <summary>
        /// Phantasy Star RLE decompression, data arranged in linear fashion
        /// Refer to: https://www.smspower.org/Development/Compression
        /// </summary>
        /// <param name="data">The bytes to decompress</param>
        /// <returns>A linaer decompressed byte array</returns>
        public static byte[] DecompressLinear(byte[] data)
        {
            List<byte> decompressed = new List<byte>();
            int index = 0;
            int count;
            byte value;
            while (index < data.Length && data[index] != 0)
            {
                if (data[index] < 128)
                {
                    count = data[index];
                    index++;
                    value = data[index];
                    index++;
                    for (int j = 0; j < count; j++)
                        decompressed.Add(value);
                }
                else
                {
                    count = data[index] - 128;
                    index++;
                    for (int j = 0; j < count; j++)
                    {
                        value = data[index];
                        decompressed.Add(value);
                        index++;
                    }
                }
            }
            return decompressed.ToArray();
        }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns>Custom name for this object</returns>
        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// Object that contains bytes to write
    /// </summary>
    [Serializable]
    public class ByteWrite : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public byte[] Bytes { get; set; } = null; // The bytes to write to the .sms export file
        public bool UseHex { get; set; } = false; // If displaying the byte values in hex
        public bool Disable { get; set; } = false; // If disabling this byte write on .sms export (May want to temporarily disable writing during testing or the such)
    }

    /// <summary>
    /// Utility class that combines palettes, tilesets, and tilemaps, as they are represented within the game
    /// </summary>
    [Serializable]
    public class Sprite : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int PaletteID { get; set; } = 0; // Palette ID for this Sprite (Currently only one per Sprite)
        public int TilesetID { get; set; } = 0; // Tileset ID for this Sprite (Currently only one per Sprite)
        public int PaletteIndex { get; set; } = 0; // Palette index used for the Sprite: 0 = Background palette, 1 = Sprite palette
        public List<int> TilemapIDs { get; set; } = new List<int>(); // Tilemaps for the Sprite, in otherwords, frames of animation

        /// <summary>
        /// Consrtuctors
        /// </summary>
        public Sprite() { }
        public Sprite(SpriteType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(type);
            PaletteID = EnumMethods.GetPaletteID(type);
            TilesetID = EnumMethods.GetTilesetID(type);
            TilemapIDs = EnumMethods.GetTilemapIDs(type);
            PaletteIndex = EnumMethods.GetPaletteIndex(type);
        }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Sprite copy/returns>
        public Sprite Clone()
        {
            return (Sprite)MemberwiseClone();
        }

        /// <summary>
        /// Gets object information
        /// </summary>
        /// <param name="tilemapIndex">Selected tilemap</param>
        /// <returns>Information string</returns>
        public string GetInfo(int tilemapIndex)
        {
            string tilemap = TilemapIDs[tilemapIndex] < 0 ? "Custom" : "0x" + TilemapIDs[tilemapIndex].ToString("X") + " (" + TilemapIDs[tilemapIndex] + ")";
            return "Palette: 0x" + PaletteID.ToString("X") + " (" + PaletteID + ") | " + "Tileset: 0x" + TilesetID.ToString("X") + " (" + TilesetID + ") | " +
                "Tilemap: " + tilemap;
        }

        /// <summary>
        /// Gets an image of the sprite
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from</param>
        /// <param name="tilemap">The tilemap for the layout of the tiles</param>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the sprite</returns>
        public static Bitmap GetImage(Tileset tileset, Tilemap tilemap, List<Color> palette)
        {
            int tileSize = 8;
            int width = tilemap.Columns * tileSize;
            int height = tilemap.Rows * tileSize;
            int[] tiles = new int[width * height];
            List<Tile> tileList = tilemap.HasEdits ? tilemap.TileEdits : tilemap.Tiles;
            using (Bitmap tilesBmp = tileset.GetImage(255, palette, tileset.HasEdits))
            {
                for (int row = 0; row < tilemap.Rows; row++)
                {
                    for (int col = 0; col < tilemap.Columns; col++)
                    {
                        int index = (tilemap.Columns * row) + col;
                        if (index >= tileList.Count)
                            break;

                        int tileID = tileList[index].TileID - tilemap.Offset;
                        Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                        if (src.X + tileSize > tilesBmp.Width || src.X < 0)
                            break;

                        int[] tile = Tileset.GetPixels(tilesBmp, src);
                        for (int y = 0; y < src.Height; y++)
                            for (int x = 0; x < src.Width; x++)
                                tiles[(y * width + (row * width * tileSize)) + ((col * tileSize) + x)] = tile[(y * src.Width) + x];
                    }
                }
                return Tileset.PixelsToBitmap(tiles, width, height);
            }
        }

        /// <summary>
        /// Gets an image strip of the sprite, using all of the given tilemaps
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from</param>
        /// <param name="tilemaps">The tilemaps for the layout of the tiles</param>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the sprite with all of the tilemaps laid out linear</returns>
        public static Bitmap GetImageStrip(Tileset tileset, List<Tilemap> tilemaps, List<Color> palette)
        {
            int cols = 0;
            int rows = 0;
            foreach (Tilemap tilemap in tilemaps)
            {
                cols += tilemap.Columns;
                if (tilemap.Rows > rows)
                    rows = tilemap.Rows; 
            }
            int index = 0;
            Bitmap image = new Bitmap(cols * 8, rows * 8);
            using (Graphics gfx = Graphics.FromImage(image))
            {
                foreach (Tilemap tilemap in tilemaps)
                {
                    using (Bitmap temp = GetImage(tileset, tilemap, palette))
                    {
                        gfx.DrawImageUnscaled(temp, new Point(index, image.Height - temp.Height));
                        index += temp.Width;
                    }
                }
            }
            return image;
        }
    }

    /// <summary>
    /// Tileset object that holds the raw pixel data making up a graphic, represented by 8 x 8 tiles.
    /// Note: When tileset pixel data is imported, it is represented by a whole byte in this object.
    /// The typical format of a single pixel for SMS is stored as 4bpp (Nibble 0BGR). Although 
    /// technically 3bpp, the first bit is still read, but not used. An 8 x 8 tile is stored in the 
    /// ROM as 32 bytes, versus the 64 bytes it becomes when imported. The data is exported correctly, however.
    /// </summary>
    [Serializable]
    public class Tileset : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public TilesetType TilesetType { get; private set; } // The defined tileset ROM data (The tileset data when loading the ROM)
        public bool HasEdits { get { return PixelEdits != null && PixelEdits.Count > 0; } } // If the tileset has been edited
        public bool Masked { get; set; } = false; // If the pixel data is stored in a masked format, this is for the tile overlap technique
        public int TileCount { get { return Pixels.Count <= 0 ? 0 : Pixels.Count / 64; } } // The number of 8 x 8 tiles the tileset has, without offset tiles
        public int TileCountEdit { get { return PixelEdits.Count <= 0 ? 0 : PixelEdits.Count / 64; } } // The number of edited 8 x 8 tiles the tileset has, without offset tiles
        public int Offset { get; set; } = 0; // The number of empty tiles prefixed to the tileset (Needed for tileset data with no empty tile, but makes one on the fly when playing the game)
        public List<byte> Pixels { get; set; } = new List<byte>(); // The raw pixel data, the byte value will be an index of 0 - 15 (16 colors)
        public List<byte> PixelEdits { get; set; } = new List<byte>(); // The edited pixel data

        /// <summary>
        /// Constructors
        /// </summary>
        public Tileset() { }
        public Tileset(TilesetType type)
        {
            TilesetType = type;
            ID = (int)type;
            Name = "Tileset " + ID.ToString("X");
            DataStart = ID;
            Length = EnumMethods.GetLength(type);
            DataEnd = DataStart + Length;
            Compression = EnumMethods.GetCompression(type);
            Offset = EnumMethods.GetOffset(type);
            Masked = EnumMethods.GetMasked(type);
            int pixels = 64 * Offset;
            for (int i = 0; i < pixels; i++)
                Pixels.Add(0);
        }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Tileset copy/returns>
        public Tileset Clone()
        {
            return (Tileset)MemberwiseClone();
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            return TileCount - Offset + " tiles | Offset Tiles: " + Offset + " | 0x" + DataStartString + " - 0x" + DataEndString + " | " + Length + " bytes | Compressed: " + 
                (Compression == CompressionType.None ? "No" : "Yes");
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id. 
        /// Note: Will return edited data, if the tileset has been edited
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <returns>A tile's worth of pixel data</returns>
        public List<byte> GetTilePixels(int tileID)
        {
            return HasEdits ? PixelEdits.GetRange(tileID * 64, 64) : Pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <param name="pixels">The list of pixels to get the pixel data from</param>
        /// <returns>A tile's worth of pixel data</returns>
        public static List<byte> GetTilePixels(int tileID, List<byte> pixels)
        {
            return pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Gets an image of the tileset using a single row of tiles
        /// </summary>
        /// <param name="palette">The color palette used</param>
        /// <param name="useEdit">If using the edited version of the tileset</param>
        /// <returns>An image of the tileset</returns>
        public Bitmap GetImage(byte alpha, List<Color> palette, bool useEdit)
        {
            return GetImage(alpha, palette, useEdit, TileCount);
        }

        /// <summary>
        /// Gets an image of the tileset using custom amount of columns
        /// </summary>
        /// <param name="palette">The color palette used</param>
        /// <param name="useEdit">If using the edited version of the tileset</param>
        /// <returns>An image of the tileset</returns>
        public Bitmap GetImage(List<Color> palette, bool useEdit, int columns)
        {
            return GetImage(255, palette, useEdit, columns);
        }

        /// <summary>
        /// Gets an image of the tileset
        /// </summary>
        /// <param name="palette">The color palette used</param>
        /// <param name="useEdit">If using the edited version of the tileset</param>
        /// <param name="columns">The width, in columns of the image</param>
        /// <returns>An image of the tileset</returns>
        public Bitmap GetImage(byte alpha, List<Color> palette, bool useEdit, int columns)
        {
            int tileID = 0;
            int pixel = 0;
            int tileSize = 8;
            int rows = (int)Math.Ceiling(TileCount / Convert.ToDouble(columns));
            Bitmap bmp = new Bitmap((int)columns * tileSize, rows * tileSize);
            List<byte> pixels = useEdit ? PixelEdits : Pixels;
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            for (int y = 0; y < tileSize; y++)
                            {
                                for (int x = 0; x < tileSize; x++)
                                {
                                    if (pixel >= pixels.Count)
                                        break;
                                    if (pixels[pixel] < palette.Count)
                                    {
                                        brush.Color = Color.FromArgb(alpha, palette[pixels[pixel]]);
                                        gfx.FillRectangle(brush, (col * tileSize) + x, (row * tileSize) + y, 1, 1);
                                    }
                                    pixel++;
                                }
                            }
                            if (tileID >= pixels.Count / 64)
                                break;

                            tileID++;
                        }
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets an image of a tileset, based on the pixels given
        /// </summary>
        /// <param name="pixels">The raw tileset pixel data to create a tileset image from</param>
        /// <param name="alpha">The amount of transparency (0 - 255)</param>
        /// <param name="palette">The color palette used</param>
        /// <param name="columns">The width, in columns of the image</param>
        /// <returns>An image of the tileset</returns>
        public static Bitmap GetImage(List<byte> pixels, byte alpha, List<Color> palette, int columns)
        {
            int tileID = 0;
            int pixel = 0;
            int tileSize = 8;
            int count = pixels.Count / 64;
            int rows = (int)Math.Ceiling(count / Convert.ToDouble(columns));
            Bitmap bmp = new Bitmap(columns * tileSize, rows * tileSize);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            for (int y = 0; y < tileSize; y++)
                            {
                                for (int x = 0; x < tileSize; x++)
                                {
                                    if (pixel >= pixels.Count)
                                        break;
                                    if (pixels[pixel] < palette.Count)
                                    {
                                        brush.Color = Color.FromArgb(alpha, palette[pixels[pixel]]);
                                        gfx.FillRectangle(brush, (col * tileSize) + x, (row * tileSize) + y, 1, 1);
                                    }
                                    pixel++;
                                }
                            }
                            if (tileID >= pixels.Count / 64)
                                break;

                            tileID++;
                        }
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Compares to tiles bytes to an empty tile (Palette index of 0)
        /// </summary>
        /// <param name="tile">The tile to compare</param>
        /// <returns>If the tile is empty</returns>
        public static bool CompareTiles(byte[] tile)
        {
            byte[] compare = new byte[tile.Length];
            for (int i = 0; i < tile.Length; i++)
                compare[i] = 0;
            return CompareTiles(tile, compare);
        }

        /// <summary>
        /// Compares bytes of two tiles, returns whether they match or not
        /// </summary>
        /// <param name="tile1">The first tile to compare</param>
        /// <param name="tile2">The second tile to compare</param>
        /// <returns>If the tiles match</returns>
        public static bool CompareTiles(byte[] tile1, byte[] tile2)
        {
            for (int i = 0; i < tile1.Length; i++)
                if (tile1[i] != tile2[i])
                    return false;
            return true;
        }

        /// <summary>
        /// Compares 32 bit integers of two tiles, returns whether they match or not
        /// </summary>
        /// <param name="tile1">The first tile to compare</param>
        /// <param name="tile2">The second tile to compare</param>
        /// <returns>If the tiles match</returns>
        public static bool CompareTiles(int[] tile1, int[] tile2)
        {
            for (int i = 0; i < tile1.Length; i++)
                if (tile1[i] != tile2[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Cuts up an image into 8 x 8 tile pixel arrays of 32 bit color data, all unique
        /// </summary>
        /// <param name="image">The source image to get unique pixel tile data from</param>
        /// <returns>A list of unique tile pixel data, in 32 bit format</returns>
        public static List<int[]> GetPixelTiles(Bitmap image, int transparentColor, bool offset)
        {
            List<int[]> pixelTiles = new List<int[]>();
            if (offset)
            {
                int[] empty = new int[64];
                for (int i = 0; i < 64; i++)
                    empty[i] = transparentColor;
                pixelTiles.Add(empty);
            }
            int cols = image.Width / 8;
            int rows = image.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    bool match = false;
                    int[] pixelTile = GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8));
                    for (int j = 0; j < pixelTiles.Count; j++)
                    {
                        if (CompareTiles(pixelTile, pixelTiles[j]))
                        {
                            match = true;
                            break;
                        }
                    }
                    if (!match)
                        pixelTiles.Add(pixelTile);
                }
            }
            return pixelTiles;
        }

        /// <summary>
        ///  Cuts up an image into 8 x 8 tile pixel arrays of SMS (4bpp indexed) color data
        /// </summary>
        /// <param name="image">The source image to get tile pixels data from</param>
        /// <param name="colors">The colors used for the indexing</param>
        /// <param name="allowDuplicates">If getting duplicate tile data is allowed</param>
        /// <returns>A list of tile pixel data, in SMS (4bpp indexed) format</returns>
        public static List<byte> GetSMSTiles(Bitmap image, List<Color> colors, bool allowDuplicates, bool ignoreEmpty)
        {
            List<byte[]> tiles = new List<byte[]>();
            List<byte> pixels = new List<byte>();
            int cols = image.Width / 8;
            int rows = image.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    List<byte> pixelTile = new List<byte>();
                    foreach (int pixel in GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8)))
                        pixelTile.Add((byte)colors.FindIndex(c => c.ToArgb() == pixel));

                    bool match = false;
                    for (int j = 0; j < tiles.Count; j++)
                    {
                        if (CompareTiles(pixelTile.ToArray(), tiles[j]))
                        {
                            match = true;
                            break;
                        }
                    }

                    if (match && !allowDuplicates)
                        continue;

                    if (ignoreEmpty && CompareTiles(pixelTile.ToArray()))
                        continue;

                    tiles.Add(pixelTile.ToArray());
                    pixels.AddRange(pixelTile);
                }
            }
            return pixels;
        }

        /// <summary>
        /// Gets the raw pixel data from a bitmap, 32 bit
        /// </summary>
        /// <param name="image">Bitmap to get raw pixel data from</param>
        /// <param name="rect">Region to get pixels from</param>
        /// <returns>32 bit pixel data</returns>
        public static int[] GetPixels(Bitmap image, Rectangle rect)
        {
            Color[] pallet = null;
            int bits = 4;
            switch (image.PixelFormat)
            {
                case PixelFormat.Format24bppRgb: bits = 3; break;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                case PixelFormat.Format32bppRgb: bits = 4; break;
                case PixelFormat.Format8bppIndexed: bits = 1; pallet = image.Palette.Entries; break;
                default: throw new Exception(image.PixelFormat.ToString());
            }
            int[] pixels = new int[rect.Width * rect.Height];
            BitmapData data = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);
            unsafe
            {
                int offset = data.Stride - data.Width * bits;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = new byte[4];
                        if (bits == 3)
                        {
                            pixel[0] = 255;
                            pixel[1] = imgPtr[0];
                            pixel[2] = imgPtr[1];
                            pixel[3] = imgPtr[2];
                        }
                        else if (bits == 4)
                        {
                            pixel[0] = imgPtr[0];
                            pixel[1] = imgPtr[1];
                            pixel[2] = imgPtr[2];
                            pixel[3] = imgPtr[3];
                        }
                        else if (bits == 1)
                        {
                            int index = imgPtr[0];
                            Color color = pallet[index];

                            pixel[0] = 255;
                            pixel[1] = color.R;
                            pixel[2] = color.G;
                            pixel[3] = color.B;
                        }
                        pixels[(y * rect.Width) + x] = BitConverter.ToInt32(pixel, 0);
                        imgPtr += bits;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return pixels;
        }

        /// <summary>
        /// Converts 32 bit pixel data to a bitmap (32bppArgb)
        /// </summary>
        /// <param name="pixels">The pixekls to create a bitmap from</param>
        /// <param name="width">The width of the output bitmap</param>
        /// <param name="height">The height of the output bitmap</param>
        /// <returns>A bitmap</returns>
        public static Bitmap PixelsToBitmap(int[] pixels, int width, int height)
        {
            Bitmap image = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                int offset = data.Stride - data.Width * 4;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = BitConverter.GetBytes(pixels[(y * width) + x]);
                        imgPtr[0] = pixel[0];
                        imgPtr[1] = pixel[1];
                        imgPtr[2] = pixel[2];
                        imgPtr[3] = pixel[3];
                        imgPtr += 4;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return image;
        }

        /// <summary>
        /// Gets the edit data in bytes
        /// </summary>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetEditData()
        {
            List<byte> bytes = new List<byte>();
            List<byte> pixels = new List<byte>();
            pixels.AddRange(PixelEdits.ToArray());
            int offset = Offset * 64;
            if (Masked)
            {
                for (int i = 0; i < pixels.Count; i++)
                    pixels[i] = pixels[i] == 0 ? (byte)1 : (byte)(pixels[i] * 2);
            }
            for (int i = offset; i < pixels.Count; i += 8)
            {
                List<bool[]> row = new List<bool[]>();
                for (int j = 0; j < 8; j++)
                    row.Add(GetPlaneBits(pixels[i + j]));

                for (int k = 0; k < 4; k++)
                {
                    int index = 7;
                    byte[] value = new byte[1];
                    bool[] bits = new bool[8];
                    for (int l = 0; l < 8; l++)
                    {
                        bits[l] = row[index][k];
                        index--;
                    }
                    BitArray arr = new BitArray(bits);
                    arr.CopyTo(value, 0);
                    bytes.Add(value[0]);
                }
            }

            return GetVerifiedBytes(bytes);
        }

        /// <summary>
        /// Gets bits of the given color index byte
        /// </summary>
        /// <param name="value">The color index value (0 - 15)</param>
        /// <returns>A bit array representing a color index value</returns>
        private static bool[] GetPlaneBits(byte value)
        {
            switch (value)
            {
                case 1: return new bool[] { true, false, false, false };
                case 2: return new bool[] { false, true, false, false };
                case 3: return new bool[] { true, true, false, false };
                case 4: return new bool[] { false, false, true, false };
                case 5: return new bool[] { true, false, true, false };
                case 6: return new bool[] { false, true, true, false };
                case 7: return new bool[] { true, true, true, false };
                case 8: return new bool[] { false, false, false, true };
                case 9: return new bool[] { true, false, false, true };
                case 10: return new bool[] { false, true, false, true };
                case 11: return new bool[] { true, true, false, true };
                case 12: return new bool[] { false, false, true, true };
                case 13: return new bool[] { true, false, true, true };
                case 14: return new bool[] { false, true, true, true };
                case 15: return new bool[] { true, true, true, true };
                default: return new bool[] { false, false, false, false };
            }
        }
    }

    /// <summary>
    /// Tilemap object that holds the tile data, be aware that not all tilemaps have tile attribute 
    /// data. Also, some tilemap tile ids are stored in ROM offset from 0, as they may be loaded to 
    /// a specific part of RAM when loaded by the game
    /// </summary>
    [Serializable]
    public class Tilemap : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public TilemapType TilemapType { get; private set; } // The defined tilemap ROM data (The tilemap data when loading the ROM)
        public int Count { get { return Columns * Rows; } } // The number of tiles, calculated by the number of columns and rows
        public int Columns { get; set; } = 8; // The number of columns
        public int Rows { get; set; } = 8; // The number of rows
        public int Offset { get; set; } = 0; // The numeric offset of the tile ids in the tilemap (Eg. the starting index in the ROM may be 128, this makes sure it's displayed as such)
        public bool UseFlags { get; set; } = false; // If the tilemap tiles use attribute flags, used when importing the ROM data, as not all tilemaps use them
        public bool HasEdits { get { return TileEdits != null && TileEdits.Count > 0; } } // If the tilemap has been edited
        public Size Size { get { return new Size(Columns * 8, Rows * 8); } } // The size of the tilemap in pixels
        public List<Tile> Tiles { get; set; } = new List<Tile>(); // The original ROM tiles
        public List<Tile> TileEdits { get; set; } = new List<Tile>(); // The edited tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public Tilemap() { }
        public Tilemap(TilemapType type)
        {
            TilemapType = type;
            ID = (int)type;
            Name = "Tilemap " + ID.ToString("X");
            DataStart = ID;
            Compression = EnumMethods.GetCompression(type);
            Columns = EnumMethods.GetColumns(type);
            Rows = EnumMethods.GetRows(type);
            Offset = EnumMethods.GetOffset(type);
            UseFlags = EnumMethods.GetUseFlags(type);
            Length = Compression == CompressionType.None ? Columns * Rows * (UseFlags ? 2 : 1) : EnumMethods.GetLength(type);
            DataEnd = DataStart + Length;
        }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Tilemap copy/returns>
        public Tilemap Clone()
        {
            return (Tilemap)MemberwiseClone();
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            string tilemap = ID < 0 ? " | Custom" : " | 0x" + DataStartString + " - 0x" + DataEndString;
            return Tiles.Count + " tiles | Columns: " + Columns + " tiles | Rows: " + Rows + " tiles | Offset: " + Offset + tilemap + " | " + Length + " bytes | Compressed: " + (Compression == CompressionType.None ? "No" : "Yes");
        }

        /// <summary>
        /// Sets sequential tiles for this tilemap, typically used to display the tileset, 
        /// but there is no tilemap data within the ROM, as it is generated in code on the fly
        /// </summary>
        public void SetSequentialTiles()
        {
            for (int i = 0; i < Count; i++)
                Tiles.Add(new Tile(i + Offset));
        }

        /// <summary>
        /// Creates tiles from the given 32 bit pixel tiles. Basically matches the 32 bit image 
        /// against the given array of 32 bit pixel tiles, and uses the index within that array
        /// Typically this is used on import from an image
        /// </summary>
        /// <param name="pixelTiles">A list of 8 x 8 tiles, in 32 bit color format</param>
        /// <param name="image">The 32 bit image to match against the given 32 bit pixel tiles</param>
        /// <param name="offset">The tile index offset, if any</param>
        /// <returns>A list of tiles to be used in a tilemap typically</returns>
        public static List<Tile> GetTilesFromImage(List<int[]> pixelTiles, Bitmap image, int offset)
        {
            List<Tile> tiles = new List<Tile>();
            int cols = image.Width / 8;
            int rows = image.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = 0;
                    int[] pixelTile = Tileset.GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8));
                    foreach (int[] tile in pixelTiles)
                    {
                        if (Tileset.CompareTiles(pixelTile, tile))
                            break;

                        index++;
                    }

                    tiles.Add(new Tile(index + offset));
                }
            }
            return tiles;
        }

        /// <summary>
        /// Gets all the edit data in bytes
        /// </summary>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetEditData()
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < TileEdits.Count; i++)
                if (!UseFlags)
                    bytes.Add((byte)TileEdits[i].TileID);

            return GetVerifiedBytes(bytes);
        }
    }

    /// <summary>
    /// Tile object that holds the tile id (index), flip, priority, and palette attributes
    /// </summary>
    [Serializable]
    public class Tile
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get; set; } // Tile ID, typically the index from the original ROM data
        public int PaletteIndex { get; set; } = 0; // Palette index flag, 0 = Background palette, 1 = Sprite palette
        public bool Priority { get; set; } = false; // Priority flag, 0 = drawn behind, 1 = drawn in front
        public bool FlipX { get; set; } = false; // If flipped horizontally
        public bool FlipY { get; set; } = false; // If flipped vertically
        public string Flags { get; set; } = ""; // Quality of life string, used to display the flags on a tile

        /// <summary>
        /// Constructors
        /// </summary>
        public Tile() { }
        public Tile(int tileID) { TileID = tileID; }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Tile copy/returns>
        public Tile Clone()
        {
            Tile tile = new Tile();
            tile.TileID = TileID;
            tile.PaletteIndex = PaletteIndex;
            tile.Priority = Priority;
            tile.FlipX = FlipX;
            tile.FlipY = FlipY;
            tile.Flags = Flags;
            return tile;
        }

        /// <summary>
        /// To string override
        /// </summary>
        /// <returns>The tile ID</returns>
        public override string ToString()
        {
            return TileID.ToString();
        }
    }

    /// <summary>
    /// Palette object that represents colors used by the tileset (Usually 32 colors total, 16 Background, 16 Sprite) 
    /// Some data may only have 8 colors, these are typically padded to 32 colors using black, or another palette for display
    /// </summary>
    [Serializable]
    public class Palette : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public PaletteType PaletteType { get; private set; } // The defined palette ROM data (The palette data when loading the ROM)
        public int Offset { get; set; } = 0; // Used in the editor, to emulate the position of the palette when in game (eg. palette of 8 colors, offset 8, to put in proper position)
        public int OffsetID { get; set; } = 0; // Used if the offset uses another palette to offset this one, instead of offsetting with just black
        public bool HasEdits { get { return ColorEdits != null && ColorEdits.Count > 0; } } // If the palette has been edited
        public List<Color> Colors { get; set; } = new List<Color>(); // The original ROM colors
        public List<Color> ColorEdits { get; set; } = new List<Color>(); // The edited colors

        /// <summary>
        /// Constructors
        /// </summary>
        public Palette() { }
        public Palette(int id, int length, string name, List<Color> colors)
        {
            ID = id;
            Length = length;
            Name = name;
            Colors = colors;
        }
        public Palette(PaletteType type)
        {
            PaletteType = type;
            ID = (int)type;
            Name = "Palette " + ID.ToString("X");
            DataStart = ID;
            Length = EnumMethods.GetLength(type);
            DataEnd = DataStart + Length;
            Offset = EnumMethods.GetOffset(type);
            OffsetID = EnumMethods.GetOffsetID(type);
        }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Palette copy/returns>
        public Palette Clone()
        {
            return (Palette)MemberwiseClone();
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            return Length + " colors | Offset: " + Offset + " | 0x" + DataStartString + " - 0x" + DataEndString + " | " + Length + " bytes | Compressed: " + (Compression == CompressionType.None ? "No" : "Yes");
        }

        /// <summary>
        /// Gets a blank image of palette colors
        /// </summary>
        /// <returns>An image of the palette</returns>
        public static Bitmap GetPaletteImage()
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < 32; i++)
                colors.Add(Color.Black);
            return GetPaletteImage(0, colors);
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <param name="useEdit">If using edited data</param>
        /// <returns>An image of the palette</returns>
        public Bitmap GetPaletteImage(bool useEdit)
        {
            return GetPaletteImage(0, useEdit);
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <param name="index">Starting index to get colors from</param>
        /// <param name="useEdit">If using edited data</param>
        /// <returns>An image of the palette</returns>
        public Bitmap GetPaletteImage(int index, bool useEdit)
        {
            return GetPaletteImage(index, useEdit ? ColorEdits : Colors);
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <param name="index">Starting index to get colors from</param>
        /// <param name="colors">The given colors to generate an image of</param>
        /// <returns>An image of the palette</returns>
        public static Bitmap GetPaletteImage(int index, List<Color> colors)
        {
            Bitmap bmp = new Bitmap(232, 16);
            if (index > colors.Count - 1)
                return bmp;

            if (colors.Count < 16)
                for (int i = colors.Count - 1; i < 16; i++)
                    colors.Add(Color.Black);

            int xOffset = 4;
            bmp.SetResolution(72, 72);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    foreach (Color color in colors.GetRange(index, 16))
                    {
                        brush.Color = color;
                        gfx.FillRectangle(Brushes.Black, xOffset + 1, 2, 12, 12);
                        gfx.FillRectangle(Brushes.White, xOffset + 2, 3, 10, 10);
                        gfx.FillRectangle(brush, xOffset + 3, 4, 8, 8);
                        xOffset += 14;
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets a list of unique colors from the given image (Uses unsafe method for speed)
        /// </summary>
        /// <param name="image">The image to get the colors from</param>
        /// <returns>A list of unique palette colors</returns>
        public static List<Color> GetColors(Bitmap image)
        {
            List<Color> palette = new List<Color>();
            int bits = 4;
            switch (image.PixelFormat)
            {
                case PixelFormat.Format24bppRgb: bits = 3; break;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                case PixelFormat.Format32bppRgb: bits = 4; break;
                case PixelFormat.Format8bppIndexed: palette.AddRange(image.Palette.Entries); return palette;
                default: throw new Exception(image.PixelFormat.ToString());
            }
            int[,] pixels = new int[image.Width, image.Height];
            BitmapData data = image.LockBits(new Rectangle(Point.Empty, image.Size), ImageLockMode.ReadOnly, image.PixelFormat);
            unsafe
            {
                int offset = data.Stride - data.Width * bits;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = new byte[4];
                        if (bits == 3)
                        {
                            pixel[0] = 255;
                            pixel[1] = imgPtr[0];
                            pixel[2] = imgPtr[1];
                            pixel[3] = imgPtr[2];
                        }
                        else if (bits == 4)
                        {
                            pixel[0] = imgPtr[0];
                            pixel[1] = imgPtr[1];
                            pixel[2] = imgPtr[2];
                            pixel[3] = imgPtr[3];
                        }
                        Color color = Color.FromArgb(BitConverter.ToInt32(pixel, 0));
                        if (!palette.Contains(color))
                            palette.Add(color);

                        imgPtr += bits;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return palette;
        }

        /// <summary>
        /// Gets all the edit data in bytes
        /// </summary>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetEditData()
        {
            List<byte> bytes = new List<byte>();
            foreach (Color color in ColorEdits.GetRange(Offset, Length))
            {
                byte[] value = new byte[1];
                List<bool> bgr = new List<bool>();
                bgr.AddRange(GetColorBits(color.R));
                bgr.AddRange(GetColorBits(color.G));
                bgr.AddRange(GetColorBits(color.B));
                bgr.AddRange(new bool[] { false, false });
                BitArray arr = new BitArray(bgr.ToArray());
                arr.CopyTo(value, 0);
                bytes.Add(value[0]);
            }
            return GetVerifiedBytes(bytes);
        }

        /// <summary>
        /// Gets bits of a given to bit color channel
        /// </summary>
        /// <param name="value">The color channel byte value</param>
        /// <returns>A bit array representing a value of 0, 1, 2, or 3</returns>
        private static bool[]  GetColorBits(byte value)
        {
            switch (value)
            {
                case 85: return new bool[] { true, false };
                case 170: return new bool[] { false, true };
                case 255: return new bool[] { true, true };
                default: return new bool[] { false, false };
            }
        }
    }
}