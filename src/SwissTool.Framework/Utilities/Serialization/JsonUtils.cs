// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonUtils.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   The JSON utils.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Utilities.Serialization
{
    using System.IO;

    using Newtonsoft.Json;

    /// <summary>
    /// Defines a set of JSON tools.
    /// </summary>
    public static class JsonUtils
    {
        /// <summary>
        /// Serializes the specified object to a JSON string.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>The JSON string.</returns>
        public static string SerializeJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Deserializes the JSON string to the specified type.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="json">The JSON string.</param>
        /// <returns>The deserialized object.</returns>
        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Serializes the object to JSON and stores to a file with the specified filename.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="filename">The filename.</param>
        /// <param name="obj">The object.</param>
        public static void SerializeJsonFile<T>(string filename, T obj)
        {
            var json = JsonConvert.SerializeObject(obj);

            File.WriteAllText(filename, json);
        }

        /// <summary>
        /// Deserializes the JSON contents from a file to the specified object type.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="filename">The filename.</param>
        /// <returns>The object.</returns>
        public static T DeserializeJsonFile<T>(string filename) where T : new()
        {
            var json = File.ReadAllText(filename);

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Clones the specified source.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>The cloned object.</returns>
        public static T Clone<T>(T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
