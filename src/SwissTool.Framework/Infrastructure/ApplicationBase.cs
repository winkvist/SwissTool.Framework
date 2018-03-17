// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationBase.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the ApplicationBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using SwissTool.Framework.Definitions;
    using SwissTool.Framework.Extensions;
    using SwissTool.Framework.Helpers;

    /// <summary>
    /// The extension application base.
    /// </summary>
    [InheritedExport(typeof(IApplication))]
    public abstract class ApplicationBase : IApplication
    {
        /// <summary>
        /// Indicates whether this instance is an extension.
        /// </summary>
        private readonly bool isExtension;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationBase" /> class.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        [ImportingConstructor]
        protected ApplicationBase(Assembly assembly = null)
        {
            assembly = assembly ?? Assembly.GetCallingAssembly();

            this.Name = assembly.GetAssemblyName();
            this.Description = assembly.GetAssemblyDescription();
            this.Version = assembly.GetAssemblyVersion();
            this.Identifier = assembly.GetAssemblyIdentifier();
            this.HomeDirectory = assembly.GetAssemblyDirectoryPath();

            this.isExtension = assembly.GetTypes().Any(t => t.IsClass && t.IsPublic && typeof(IExtension).IsAssignableFrom(t));
        }
        
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public Version Version { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Identifier { get; private set; }

        /// <summary>
        /// Gets the home directory.
        /// </summary>
        /// <value>The home directory.</value>
        public string HomeDirectory { get; private set; }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        [Import(typeof(IHost))]
        public IHost Host { get; private set; }

        /// <summary>
        /// Gets the application data directory.
        /// </summary>
        /// <value>The application data directory.</value>
        public string DataDirectory => this.isExtension 
            ? Path.Combine(AppConstants.ExtensionDataPath, this.Name) 
            : AppConstants.ApplicationDataPath;

        /// <summary>
        /// Loads the configuration.
        /// </summary>
        /// <typeparam name="T">The type of the configuration object.</typeparam>
        /// <param name="create">Whether default resource should be returned if file is not found. Throws exception if set to false and file is not found.</param>
        /// <param name="filename">The filename.</param>
        /// <returns>The configuration.</returns>
        public T LoadConfiguration<T>(bool create = true, string filename = null) where T : new()
        {
            filename = filename == null ? AppConstants.DefaultSettingsFilename : Path.GetFileName(filename);
            var filePath = Path.Combine(this.DataDirectory, filename);

            return SettingsHelper.Load<T>(create, filePath);
        }

        /// <summary>
        /// Saves the configuration.
        /// </summary>
        /// <typeparam name="T">The type of the configuration object.</typeparam>
        /// <param name="obj">The resource object.</param>
        /// <param name="filename">The configuration.</param>
        public void SaveConfiguration<T>(T obj, string filename = null)
        {
            filename = filename == null ? AppConstants.DefaultSettingsFilename : Path.GetFileName(filename);
            var filePath = Path.Combine(this.DataDirectory, filename);

            SettingsHelper.Save(obj, filePath);
        }
    }
}
