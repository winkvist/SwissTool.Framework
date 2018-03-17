// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExtensionMenuItem.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the IExtensionMenuItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    using System.Collections.Generic;

    /// <summary>
    /// The extension menu item class.
    /// </summary>
    public interface IExtensionMenuItem : IExtensionAction
    {
        /// <summary>
        /// Gets or sets the sub menu items.
        /// </summary>
        /// <value>The sub menu items.</value>
        IEnumerable<IExtensionMenuItem> SubMenuItems { get; set; }
    }
}
