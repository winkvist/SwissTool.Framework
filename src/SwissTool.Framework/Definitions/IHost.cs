// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHost.cs" company="Fredrik Winkvist">
//   Copyright (c) Fredrik Winkvist. All rights reserved.
// </copyright>
// <summary>
//   The host interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Framework.Definitions
{
    /// <summary>
    /// The host interface.
    /// </summary>
    public interface IHost
    {
        /// <summary>
        /// Shows the balloon tool tip.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="message">The message.</param>
        /// <param name="balloonIcon">The balloon icon.</param>
        void ShowBalloonToolTip(string title, string message, Enums.BalloonIcon balloonIcon);
    }
}
