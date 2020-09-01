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
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace GoldenAxeEditor.Data
{
    public static class EnumMethods
    {
        public static string[] GetEnumDescriptions(Type enumType)
        {
            List<string> descriptions = new List<string>();
            foreach (object value in Enum.GetValues(enumType))
            {
                object[] attributes = enumType.GetMember(value.ToString()).First().GetCustomAttributes(typeof(DescriptionAttribute), false);
                descriptions.Add((attributes[0] as DescriptionAttribute).Description);
            }
            return descriptions.ToArray();
        }

        public static string GetDescription(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false).Length <= 0)
                return "";
            return (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false)[0] as DescriptionAttribute).Description;
        }

        public static int GetLength(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(LengthAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(LengthAttribute), false)[0] as LengthAttribute).Length;
        }

        public static CompressionType GetCompression(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(CompressionAttribute), false).Length <= 0)
                return CompressionType.None;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(CompressionAttribute), false)[0] as CompressionAttribute).Compression;
        }

        public static int GetColumns(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(ColumnsAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(ColumnsAttribute), false)[0] as ColumnsAttribute).Columns;
        }

        public static int GetRows(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(RowsAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(RowsAttribute), false)[0] as RowsAttribute).Rows;
        }

        public static int GetPaletteID(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(PaletteIDAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(PaletteIDAttribute), false)[0] as PaletteIDAttribute).PaletteID;
        }

        public static int GetTilesetID(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(TilesetIDAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(TilesetIDAttribute), false)[0] as TilesetIDAttribute).TilesetID;
        }

        public static int GetOffset(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(OffsetAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(OffsetAttribute), false)[0] as OffsetAttribute).Offset;
        }

        public static int GetOffsetID(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(OffsetIDAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(OffsetIDAttribute), false)[0] as OffsetIDAttribute).OffsetID;
        }

        public static bool GetUseFlags(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(UseFlagsAttribute), false).Length <= 0)
                return false;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(UseFlagsAttribute), false)[0] as UseFlagsAttribute).UseFlags;
        }

        public static int GetFrames(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(FramesAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(FramesAttribute), false)[0] as FramesAttribute).Frames;
        }

        public static List<int> GetTilemapIDs(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(TilemapIDsAttribute), false).Length <= 0)
                return new List<int>();
            return (type.GetMember(name).First().GetCustomAttributes(typeof(TilemapIDsAttribute), false)[0] as TilemapIDsAttribute).TilemapIDs; ;
        }

        public static bool GetMasked(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(MaskedAttribute), false).Length <= 0)
                return false;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(MaskedAttribute), false)[0] as MaskedAttribute).Masked;
        }

        public static int GetPaletteIndex(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(PaletteIndexAttribute), false).Length <= 0)
                return 0;
            return (type.GetMember(name).First().GetCustomAttributes(typeof(PaletteIndexAttribute), false)[0] as PaletteIndexAttribute).PaletteIndex;
        }
    }

    /// <summary>
    /// Length attribute
    /// </summary>
    public sealed class LengthAttribute : Attribute
    {
        public int Length { get; set; }

        public LengthAttribute(int length)
        {
            Length = length;
        }
    }

    /// <summary>
    /// Crompression attribute
    /// </summary>
    public sealed class CompressionAttribute : Attribute
    {
        public CompressionType Compression { get; set; }

        public CompressionAttribute(CompressionType compression)
        {
            Compression = compression;
        }
    }

    /// <summary>
    /// Columns attribute
    /// </summary>
    public sealed class ColumnsAttribute : Attribute
    {
        public int Columns { get; set; }

        public ColumnsAttribute(int columns)
        {
            Columns = columns;
        }
    }

    /// <summary>
    /// Rows attribute
    /// </summary>
    public sealed class RowsAttribute : Attribute
    {
        public int Rows { get; set; }

        public RowsAttribute(int rows)
        {
            Rows = rows;
        }
    }

    /// <summary>
    /// Palette ID attribute
    /// </summary>
    public sealed class PaletteIDAttribute : Attribute
    {
        public int PaletteID { get; set; }

        public PaletteIDAttribute(int paletteID)
        {
            PaletteID = paletteID;
        }
    }

    /// <summary>
    /// Tileset ID attribute
    /// </summary>
    public sealed class TilesetIDAttribute : Attribute
    {
        public int TilesetID { get; set; }

        public TilesetIDAttribute(int tilesetID)
        {
            TilesetID = tilesetID;
        }
    }

    /// <summary>
    /// Use flags attribute
    /// </summary>
    public sealed class UseFlagsAttribute : Attribute
    {
        public bool UseFlags { get; set; }

        public UseFlagsAttribute(bool useFlags)
        {
            UseFlags = useFlags;
        }
    }

    /// <summary>
    /// Offset attribute
    /// </summary>
    public sealed class OffsetAttribute : Attribute
    {
        public int Offset { get; set; }

        public OffsetAttribute(int offset)
        {
            Offset = offset;
        }
    }

    /// <summary>
    /// Offset ID attribute
    /// </summary>
    public sealed class OffsetIDAttribute : Attribute
    {
        public int OffsetID { get; set; }

        public OffsetIDAttribute(int offsetID)
        {
            OffsetID = offsetID;
        }
    }

    /// <summary>
    /// Frames attribute
    /// </summary>
    public sealed class FramesAttribute : Attribute
    {
        public int Frames { get; set; }

        public FramesAttribute(int frames)
        {
            Frames = frames;
        }
    }

    /// <summary>
    /// Tilemap IDs attribute
    /// </summary>
    public sealed class TilemapIDsAttribute : Attribute
    {
        public List<int> TilemapIDs { get; set; } = new List<int>();

        public TilemapIDsAttribute(int[] tilemapIDs)
        {
            TilemapIDs.AddRange(tilemapIDs);
        }
    }

    /// <summary>
    /// Masked attribute
    /// </summary>
    public sealed class MaskedAttribute : Attribute
    {
        public bool Masked { get; set; } = false;

        public MaskedAttribute(bool masked)
        {
            Masked = masked;
        }
    }

    /// <summary>
    /// Palette Index attribute
    /// </summary>
    public sealed class PaletteIndexAttribute : Attribute
    {
        public int PaletteIndex { get; set; } = 0;

        public PaletteIndexAttribute(int paletteIndex)
        {
            PaletteIndex = paletteIndex;
        }
    }
}
