// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExtensionHotKeyAction.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the IExtensionHotKeyAction type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    /// <summary>
    /// The extension action class
    /// </summary>
    public interface IExtensionHotKeyAction : IExtensionAction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the default hot key.
        /// </summary>
        /// <value>The default hot key.</value>
        IActionHotKey DefaultHotKey { get; set; }
    }
}