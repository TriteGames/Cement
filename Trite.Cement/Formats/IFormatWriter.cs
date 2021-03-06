﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Trite.Cement.Formats
{
    public interface IFormatWriter : IDisposable
    {
        /// <summary>
        /// Gets the stream.
        /// </summary>
        Stream Stream { get; }
        /// <summary>
        /// Begins the specified section.
        /// </summary>
        /// <param name="tag">The tag.</param>
        IDisposable Section(string tag);
        /// <summary>
        /// Writes the specified unsigned integer value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteUnsignedInteger(string tag, uint value);
        /// <summary>
        /// Writes the specified unsigned short value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteUnsignedShort(string tag, ushort value);
        /// <summary>
        /// Writes the specified unsigned long value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteUnsignedLong(string tag, ulong value);
        /// <summary>
        /// Writes the specified integer value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteInteger(string tag, int value);
        /// <summary>
        /// Writes the specified short value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteShort(string tag, short value);
        /// <summary>
        /// Writes the specified long value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteLong(string tag, long value);
        /// <summary>
        /// Writes the specified float value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteFloat(string tag, float value);
        /// <summary>
        /// Writes the specified double value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteDouble(string tag, double value);
        /// <summary>
        /// Writes the specified decimal value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteDecimal(string tag, decimal value);
        /// <summary>
        /// Writes the specified boolean value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteBoolean(string tag, bool value);
        /// <summary>
        /// Writes the specified byte value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteByte(string tag, byte value);
        /// <summary>
        /// Writes the specified byte array value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteBytes(string tag, byte[] value);
        /// <summary>
        /// Writes the specified character value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteCharacter(string tag, char value);
        /// <summary>
        /// Writes the specified string value.
        /// </summary>
        /// <param name="tag">The tag that is used for better readability in plain text formats.</param>
        /// <param name="value">The value.</param>
        void WriteString(string tag, string value);
    }
}
