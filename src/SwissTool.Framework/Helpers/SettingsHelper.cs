// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsHelper.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the SettingsHelper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Helpers
{
    using System;
    using System.IO;

    using SwissTool.Framework.Utilities.Serialization;

    /// <summary>
    /// A settings helper class.
    /// </summary>
    internal static class SettingsHelper
    {
        /// <summary>
        /// Serializes and saves the specified object to a file.
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="fileLocation">The file location.</param>
        internal static void Save<T>(T obj, string fileLocation)
        {
            try
            {
                var directoryPath = Path.GetDirectoryName(fileLocation);

                if (directoryPath == null)
                {
                    throw new ApplicationException("The specified path is invalid.");
                }

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                JsonUtils.SerializeJsonFile(fileLocation, obj);
            }
            catch
            {
                throw new ApplicationException($"Unable to save changes to settings file {fileLocation}.");
            }
        }

        /// <summary>
        /// Deserializes and loads an object of a specific type.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="create">Creates a default instance if the file is not found.</param>
        /// <param name="fileLocation">The file location.</param>
        /// <returns>The object.</returns>
        internal static T Load<T>(bool create, string fileLocation) where T : new()
        {
            var obj = new T();

            if (!File.Exists(fileLocation))
            {
                if (create)
                {
                    return obj;
                }
                else
                {
                    throw new FileNotFoundException($"The settings file {fileLocation} does not exist.");
                }
            }

            try
            {
                obj = JsonUtils.DeserializeJsonFile<T>(fileLocation);
            }
            catch
            {
                throw new ApplicationException($"Unable to load the settings file {fileLocation}.");
            }

            return obj;
        }
    }
}
