// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppConstants.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the application constants.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System;
    using System.IO;

    /// <summary>
    /// Defines the application constants.
    /// </summary>
    internal class AppConstants
    {
        /// <summary>
        /// The application name
        /// </summary>
        internal static readonly string ApplicationName = "SwissTool";

        /// <summary>
        /// The AppData settings path.
        /// </summary>
        internal static readonly string ApplicationDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SwissTool");

        /// <summary>
        /// The updates data path
        /// </summary>
        internal static readonly string UpdatesDataPath = Path.Combine(ApplicationDataPath, "Updates");

        /// <summary>
        /// The AppData extension settings path.
        /// </summary>
        internal static readonly string ExtensionDataPath = Path.Combine(ApplicationDataPath, "Extensions");

        /// <summary>
        /// The log file path
        /// </summary>
        internal static readonly string LogFilePath = Path.Combine(ApplicationDataPath, $"{ApplicationName}.log");

        /// <summary>
        /// The default settings filename.
        /// </summary>
        internal static readonly string DefaultSettingsFilename = "settings.json";
    }
}
