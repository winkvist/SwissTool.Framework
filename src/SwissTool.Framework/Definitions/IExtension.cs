// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExtension.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the IExtension type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// The extension interface.
    /// </summary>
    [InheritedExport(typeof(IExtension))]
    public interface IExtension : IApplication
    {
        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <value>The icon.</value>
        BitmapImage Icon { get; }

        /// <summary>
        /// Gets the actions.
        /// </summary>
        /// <value>The actions.</value>
        IList<IExtensionHotKeyAction> Actions { get; }

        /// <summary>
        /// Gets the menu items.
        /// </summary>
        /// <value>The menu items.</value>
        IList<IExtensionMenuItem> MenuItems { get; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        void Initialize();
    }
}
