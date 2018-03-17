// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplication.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the IApplication type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    using System;

    /// <summary>
    /// The application base interface.
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        Version Version { get; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Identifier { get; }

        /// <summary>
        /// Gets or the home directory.
        /// </summary>
        /// <value>The home directory.</value>
        string HomeDirectory { get; }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        IHost Host { get; }

        /// <summary>
        /// Gets the application data directory.
        /// </summary>
        /// <value>The application data directory.</value>
        string DataDirectory { get; }

        /// <summary>
        /// Loads the settings.
        /// </summary>
        /// <typeparam name="T">The settings type.</typeparam>
        /// <param name="create">if set to <c>true</c> [create].</param>
        /// <param name="filename">The filename.</param>
        /// <returns>The settings.</returns>
        T LoadConfiguration<T>(bool create = true, string filename = null) where T : new();

        /// <summary>
        /// Saves the settings.
        /// </summary>
        /// <typeparam name="T">The settings type.</typeparam>
        /// <param name="obj">The settings object.</param>
        /// <param name="filename">The filename.</param>
        void SaveConfiguration<T>(T obj, string filename = null);
    }
}
