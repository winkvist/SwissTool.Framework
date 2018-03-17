// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotKeyModifier.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the KeyModifier type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Enums
{
    using System;

    /// <summary>
    /// The key modifier.
    /// </summary>
    [Flags]
    public enum HotKeyModifier
    {
        /// <summary>
        /// No key specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// The ALT key.
        /// </summary>
        Alt = 1,

        /// <summary>
        /// The Control key.
        /// </summary>
        Control = 2,

        /// <summary>
        /// The Shift key.
        /// </summary>
        Shift = 4,

        /// <summary>
        /// The Windows key.
        /// </summary>
        Windows = 8
    }
}
