// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="AleRabo">
// Copyright (c) AleRabo. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace BetterConsoleLogs
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc cref="IConfig"/>
    public sealed class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether remote admin commands should be logged.
        /// </summary>
        [Description("Indicates whether remote admin commands should be logged.")]
        public bool CommandLogs { get; set; } = false;
    }
}
