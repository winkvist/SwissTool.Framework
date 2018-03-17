// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationWindowSession.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   Defines the ApplicationWindowSession type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Infrastructure
{
    using System;
    using System.Windows;

    /// <summary>
    /// A class used to temporarily take over the main application window. Useful when creating WPF dialogs with no owner support 
    /// (such as the print dialog) to make the window stay on top of the plugin window.
    /// </summary>
    public class ApplicationWindowSession : IDisposable
    {
        /// <summary>
        /// The original main window
        /// </summary>
        private readonly Window originalMainWindow;

        /// <summary>
        /// The session owner window
        /// </summary>
        private readonly Window sessionOwnerWindow;

        /// <summary>
        /// The disable topmost
        /// </summary>
        private readonly bool disableTopmost;

        /// <summary>
        /// The original topmost
        /// </summary>
        private readonly bool originalTopmost;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationWindowSession"/> class.
        /// </summary>
        /// <param name="sessionOwnerWindow">The session owner window.</param>
        /// <param name="disableTopmost">if set to <c>true</c> [disable topmost].</param>
        public ApplicationWindowSession(Window sessionOwnerWindow, bool disableTopmost = false)
        {
            this.sessionOwnerWindow = sessionOwnerWindow;
            this.disableTopmost = disableTopmost;

            if (Application.Current != null)
            {
                this.originalMainWindow = Application.Current.MainWindow;

                Application.Current.MainWindow = sessionOwnerWindow;

                if (sessionOwnerWindow != null && disableTopmost)
                {
                    this.originalTopmost = sessionOwnerWindow.Topmost;
                    sessionOwnerWindow.Topmost = false;
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (Application.Current != null)
            {
                // Restore the old window
                Application.Current.MainWindow = this.originalMainWindow;
            }

            if (this.sessionOwnerWindow != null && this.disableTopmost)
            {
                this.sessionOwnerWindow.Topmost = this.originalTopmost;
            }
        }
    }
}