﻿using System;
using Trite.Cement.Utility;
using Trite.Cement.Link;
using Trite.Cement.Formats;
using Trite.Cement.Layouts.Generation;

namespace Trite.Cement.Layouts
{
    [ManuallyLinked]
    public class AutomaticLayoutSerializer : TypeSerializer<object>
    {
        #region Fields
        private static readonly Cache<Type, ILayoutElement> cache = new Cache<Type, ILayoutElement>(new LayoutGenerator()); 
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticLayoutSerializer"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public AutomaticLayoutSerializer(Type type)
        {
            this.Type = type;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the type.
        /// </summary>
        public Type Type { get; private set; }
        #endregion

        #region Overrides of TypeSerializer<object>
        /// <summary>
        /// Reads a value out of the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public override object Read(IFormatReader reader)
        {
            object instance = Activator.CreateInstance(this.Type, true);
            cache.Get(this.Type).Read(reader, instance);

            return instance;
        }
        /// <summary>
        /// Writes the specified value.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        public override void Write(IFormatWriter writer, object value)
        {
            cache.Get(this.Type).Write(writer, value);
        }
        #endregion
    }
}
