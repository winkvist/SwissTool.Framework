// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyExtensions.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the AssemblyExtensions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Extensions
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The assembly extensions class.
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The name of the assembly.</returns>
        public static string GetAssemblyName(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            return attributes.Length == 0
                ? string.Empty
                : ((AssemblyTitleAttribute)attributes[0]).Title;
        }

        /// <summary>
        /// Gets the assembly version.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The assembly version.</returns>
        public static Version GetAssemblyVersion(this Assembly assembly)
        {
            return assembly.GetName().Version;
        }

        /// <summary>
        /// Gets the assembly copyright.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The assembly copyright string.</returns>
        public static string GetAssemblyCopyright(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            return attributes.Length == 0 
                ? string.Empty 
                : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        /// <summary>
        /// Gets the assembly description.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The assembly description.</returns>
        public static string GetAssemblyDescription(this Assembly assembly)
        {
            var descriptionAttribute = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            var descriptionText = ((AssemblyDescriptionAttribute)descriptionAttribute[0]).Description;

            return descriptionText;
        }

        /// <summary>
        /// Gets the assembly identifier.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The assembly identifier.</returns>
        public static Guid GetAssemblyIdentifier(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(typeof(GuidAttribute), false);

            return Guid.Parse(((GuidAttribute)attributes[0]).Value);
        }

        /// <summary>
        /// Gets the assembly directory path.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The directory path of the assembly.</returns>
        public static string GetAssemblyDirectoryPath(this Assembly assembly)
        {
            return Path.GetDirectoryName(assembly.Location);
        }
    }
}
