// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionActionBase.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the ExtensionActionBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System.Windows.Input;
    using System.Windows.Media.Imaging;

    using SwissTool.Framework.Definitions;

    /// <summary>
    /// The extension action base class.
    /// </summary>
    public abstract class ExtensionActionBase : IExtensionAction
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public virtual BitmapImage Icon { get; set; }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>The command.</value>
        public virtual ICommand Command { get; set; }
    }
}
