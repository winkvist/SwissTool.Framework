// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionHotKey.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines an action hot key combination.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using SwissTool.Framework.Definitions;
    using SwissTool.Framework.Enums;

    /// <summary>
    /// Defines an action hot key combination.
    /// </summary>
    public class ActionHotKey : IActionHotKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionHotKey"/> class.
        /// </summary>
        /// <param name="firstModifier">The first modifier.</param>
        /// <param name="secondModifier">The second modifier.</param>
        /// <param name="hotKey">The hot key.</param>
        public ActionHotKey(HotKeyModifier firstModifier, HotKeyModifier secondModifier, HotKey hotKey)
        {
            this.HotKey = hotKey;
            this.FirstModifier = firstModifier;
            this.SecondModifier = secondModifier;
        }

        /// <summary>
        /// Gets the hot key.
        /// </summary>
        /// <value>The hot key.</value>
        public HotKey HotKey { get; private set; }

        /// <summary>
        /// Gets the first modifier.
        /// </summary>
        /// <value>The first modifier.</value>
        public HotKeyModifier FirstModifier { get; private set; }

        /// <summary>
        /// Gets the second modifier.
        /// </summary>
        /// <value>The second modifier.</value>
        public HotKeyModifier SecondModifier { get; private set; }
    }
}
