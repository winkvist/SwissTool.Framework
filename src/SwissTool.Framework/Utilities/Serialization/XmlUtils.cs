// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XmlUtils.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   The XML utils.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Utilities.Serialization
{
    using System;
    using System.IO;
    using System.Windows;
    using System.Windows.Media;
    using System.Xml;
    using System.Xml.Serialization;

    using SwissTool.Framework.Enums;

    /// <summary>
    /// Defines a set of XML tools.
    /// </summary>
    public static class XmlUtils
    {
        /// <summary>
        /// Serializes the specified object to XML.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>The XML.</returns>
        public static string SerializeXml<T>(T obj)
        {
            var s = new XmlSerializer(typeof(T));
            string xml;

            using (var sr = new StringWriter())
            {
                using (var writer = XmlWriter.Create(sr))
                {
                    s.Serialize(writer, obj);
                    xml = sr.ToString();
                }
            }

            return xml;
        }

        /// <summary>
        /// Deserializes the XML to an object of the specified type.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="xml">The XML.</param>
        /// <returns>The object.</returns>
        public static T DeserializeXml<T>(string xml)
        {
            var s = new XmlSerializer(typeof(T));
            
            T obj;

            using (TextReader reader = new StringReader(xml))
            {
                obj = (T)s.Deserialize(reader);
            }
            
            return obj;
        }

        /// <summary>
        /// Serializes an object and saves it to a XML file
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="filename">The name and location of the file to save</param>
        /// <param name="obj">The object to be serialized</param>
        public static void SerializeXmlFile<T>(string filename, T obj)
        {
            var s = new XmlSerializer(typeof(T));
            using (TextWriter tw = new StreamWriter(filename))
            {
                s.Serialize(tw, obj);
            }
        }

        /// <summary>
        /// Loads and deserializes an object from a XML file
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="filename">The name and location of the file to load</param>
        /// <returns>Deserialized object of the given type</returns>
        public static T DeserializeXmlFile<T>(string filename) where T : new()
        {
            var s = new XmlSerializer(typeof(T));
            T obj;

            using (TextReader tr = new StreamReader(filename))
            {
                obj = (T)s.Deserialize(tr);
            }

            return obj;
        }

        /// <summary>
        /// Serializes the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>The serialized color.</returns>
        public static string SerializeColor(Color color)
        {
            return $"{ColorFormat.ARGBColor}:{color.A}:{color.R}:{color.G}:{color.B}";
        }

        /// <summary>
        /// Deserializes the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>The deserialized color.</returns>
        public static Color DeserializeColor(string color)
        {
            byte a, r, g, b;

            var pieces = color.Split(':');

            var colorType = (ColorFormat)Enum.Parse(typeof(ColorFormat), pieces[0], true);

            switch (colorType)
            {
                case ColorFormat.ARGBColor:
                    a = byte.Parse(pieces[1]);
                    r = byte.Parse(pieces[2]);
                    g = byte.Parse(pieces[3]);
                    b = byte.Parse(pieces[4]);

                    return Color.FromArgb(a, r, g, b);
            }

            return Colors.Black;
        }

        /// <summary>
        /// Serializes the font family.
        /// </summary>
        /// <param name="fontFamily">The font family.</param>
        /// <returns>The serialized font family.</returns>
        public static string SerializeFontFamily(FontFamily fontFamily)
        {
            var converter = new FontFamilyConverter();
            return converter.ConvertToString(fontFamily);
        }

        /// <summary>
        /// Deserializes the font family.
        /// </summary>
        /// <param name="fontFamily">The font family.</param>
        /// <returns>The deserialized font family.</returns>
        public static FontFamily DeserializeFontFamily(string fontFamily)
        {
            var converter = new FontFamilyConverter();
            return (FontFamily)converter.ConvertFromString(fontFamily);
        }

        /// <summary>
        /// Serializes the font weight.
        /// </summary>
        /// <param name="fontWeight">The font weight.</param>
        /// <returns>The serialized font weight.</returns>
        public static string SerializeFontWeight(FontWeight fontWeight)
        {
            var converter = new FontWeightConverter();
            return converter.ConvertToString(fontWeight);
        }

        /// <summary>
        /// Deserializes the font weight.
        /// </summary>
        /// <param name="fontWeight">The font weight.</param>
        /// <returns>The deserialized font weight.</returns>
        public static FontWeight DeserializeFontWeight(string fontWeight)
        {
            var converter = new FontWeightConverter();
            return (FontWeight)converter.ConvertFromString(fontWeight);
        }

        /// <summary>
        /// Serializes the font style.
        /// </summary>
        /// <param name="fontStyle">The font style.</param>
        /// <returns>The serialized font style.</returns>
        public static string SerializeFontStyle(FontStyle fontStyle)
        {
            var converter = new FontStyleConverter();
            return converter.ConvertToString(fontStyle);
        }

        /// <summary>
        /// Deserializes the font style.
        /// </summary>
        /// <param name="fontStyle">The font style.</param>
        /// <returns>The deserialized font style.</returns>
        public static FontStyle DeserializeFontStyle(string fontStyle)
        {
            var converter = new FontStyleConverter();
            return (FontStyle)converter.ConvertFromString(fontStyle);
        }
    }
}
