// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionMenuItem.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the ExtensionMenuItemBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System.Collections.Generic;

    using SwissTool.Framework.Definitions;

    /// <summary>
    /// The extension menu item base class.
    /// </summary>
    public class ExtensionMenuItem : ExtensionActionBase, IExtensionMenuItem
    {
        /// <summary>
        /// Gets or sets the sub menu items.
        /// </summary>
        /// <value>The sub menu items.</value>
        public virtual IEnumerable<IExtensionMenuItem> SubMenuItems { get; set; }
    }
}
