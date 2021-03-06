﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;

namespace Trite.Cement.Contexts
{
    internal class FileAssemblyContext : IAssemblyContext
    {
        #region Fields
        private readonly HashSet<Assembly> _assemblies;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAssemblyContext"/> class.
        /// </summary>
        /// <param name="directory">The directory.</param>
        public FileAssemblyContext(string directory)
        {
            this._assemblies = new HashSet<Assembly>();
            this.LoadAssemblies(directory);
        }
        #endregion
        
        #region Methods
        /// <summary>
        /// Loads the assemblies out of the specified path.
        /// </summary>
        /// <param name="directory">The directory.</param>
        private void LoadAssemblies(string directory)
        {
            foreach (string fileName in Directory.GetFiles(directory))
            {
                if (Path.GetExtension(fileName) != ".dll" && Path.GetExtension(fileName) != ".exe")
                    continue;

                try
                {
                    this._assemblies.Add(Assembly.LoadFrom(fileName));
                }
                catch (Exception exception)
                {
                    // swallow exception
                }
            }

            foreach (string sub in Directory.GetDirectories(directory))
            {
                this.LoadAssemblies(sub);
            }
        }
        #endregion

        #region Implementation of IAssemblyContext
        /// <summary>
        /// Gets the assemblies.
        /// </summary>
        public IEnumerable<Assembly> Assemblies
        {
            get { return this._assemblies; }
        }
        #endregion
    }
}
