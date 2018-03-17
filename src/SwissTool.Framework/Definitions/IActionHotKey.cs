// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IActionHotKey.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines an action hot key.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    using SwissTool.Framework.Enums;

    /// <summary>
    /// Defines an action hot key.
    /// </summary>
    public interface IActionHotKey
    {
        /// <summary>
        /// Gets the hot key.
        /// </summary>
        /// <value>The hot key.</value>
        HotKey HotKey { get; }

        /// <summary>
        /// Gets the first modifier.
        /// </summary>
        /// <value>The first modifier.</value>
        HotKeyModifier FirstModifier { get; }

        /// <summary>
        /// Gets the second modifier.
        /// </summary>
        /// <value>The second modifier.</value>
        HotKeyModifier SecondModifier { get; }
    }
}
