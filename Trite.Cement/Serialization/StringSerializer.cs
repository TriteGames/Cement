﻿using System.IO;
using Trite.Cement.Formats;

namespace Trite.Cement.Serialization
{
    public class StringSerializer : TypeSerializer<string>
    {
        #region Overrides of SerializationManager<string>
        /// <summary>
        /// Reads a value out of the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public override string Read(IFormatReader reader)
        {
            return reader.ReadString("Value");
        }
        /// <summary>
        /// Writes the specified value.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        public override void Write(IFormatWriter writer, string value)
        {
            writer.WriteString("Value", value);
        }
        #endregion
    }
}
