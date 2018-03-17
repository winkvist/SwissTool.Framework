// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionBase.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the ExtensionBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Reflection;
    using System.Windows.Media.Imaging;

    using SwissTool.Framework.Definitions;

    /// <summary>
    /// The extension base class.
    /// </summary>
    /// <seealso cref="SwissTool.Framework.Infrastructure.ApplicationBase" />
    /// <seealso cref="SwissTool.Framework.Definitions.IExtension" />
    [InheritedExport(typeof(IExtension))]
    public abstract class ExtensionBase : ApplicationBase, IExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBase"/> class.
        /// </summary>
        protected ExtensionBase()
            : base(Assembly.GetCallingAssembly())
        {
        }

        /// <summary>
        /// Gets or sets the extension icon.
        /// </summary>
        /// <value>
        /// The extension icon.
        /// </value>
        public BitmapImage Icon { get; protected set; }

        /// <summary>
        /// Gets the actions.
        /// </summary>
        /// <value>
        /// The actions.
        /// </value>
        public IList<IExtensionHotKeyAction> Actions { get; } = new List<IExtensionHotKeyAction>();

        /// <summary>
        /// Gets the menu items.
        /// </summary>
        /// <value>
        /// The menu items.
        /// </value>
        public IList<IExtensionMenuItem> MenuItems { get; } = new List<IExtensionMenuItem>();

        /// <summary>
        /// Initializes the extension.
        /// </summary>
        public virtual void Initialize()
        {
        }

        /// <summary>
        /// Adds the actions.
        /// </summary>
        /// <param name="actions">The actions.</param>
        protected void AddActions(params IExtensionHotKeyAction[] actions)
        {
            if (actions == null)
            {
                return;
            }
            
            foreach (var action in actions)
            {
                this.Actions.Add(action);
            }
        }

        /// <summary>
        /// Adds the menu items.
        /// </summary>
        /// <param name="menuItems">The menu items.</param>
        protected void AddMenuItems(params IExtensionMenuItem[] menuItems)
        {
            if (menuItems == null)
            {
                return;
            }

            foreach (var menuItem in menuItems)
            {
                this.MenuItems.Add(menuItem);
            }
        }
    }
}