// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionHotKeyAction.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines an extension hot key action.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using SwissTool.Framework.Definitions;

    /// <summary>
    /// Defines an extension hot key action.
    /// </summary>
    public class ExtensionHotKeyAction : ExtensionActionBase, IExtensionHotKeyAction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the default hot key.
        /// </summary>
        /// <value>The default hot key.</value>
        public IActionHotKey DefaultHotKey { get; set; }
    }
}
