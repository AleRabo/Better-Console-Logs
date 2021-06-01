// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="AleRabo">
// Copyright (c) AleRabo. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace BetterConsoleLogs
{
    using BetterConsoleLogs.EventHandlers;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;
    using ServerHandlers = Exiled.Events.Handlers.Server;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private static readonly Plugin InstanceValue = new Plugin();

        private Plugin()
        {
        }

        /// <summary>
        /// Gets an instance of the <see cref="Plugin"/> class.
        /// </summary>
        public static Plugin Instance { get; } = InstanceValue;

        /// <inheritdoc />
        public override string Prefix { get; } = "BCL";

        /// <summary>
        /// Gets an instance of the <see cref="EventHandlers.PlayerEvents"/> class.
        /// </summary>
        public PlayerEvents PlayerEvents { get; private set; }

        /// <summary>
        /// Gets an instance of the <see cref="EventHandlers.ServerEvents"/> class.
        /// </summary>
        public ServerEvents ServerEvents { get; private set; }

        /// <inheritdoc />
        public override void OnEnabled()
        {
            ServerEvents = new ServerEvents();
            PlayerEvents = new PlayerEvents();

            PlayerHandlers.Hurting += PlayerEvents.OnHurting;
            PlayerHandlers.Died += PlayerEvents.OnDied;
            PlayerHandlers.Destroying += PlayerEvents.OnDestroying;
            PlayerHandlers.Verified += PlayerEvents.OnVerified;
            PlayerHandlers.InteractingDoor += PlayerEvents.OnInteractingDoor;
            PlayerHandlers.InsertingGeneratorTablet += PlayerEvents.OnInsertingGeneratorTablet;
            PlayerHandlers.InteractingElevator += PlayerEvents.OnInteractingElevator;
            PlayerHandlers.IntercomSpeaking += PlayerEvents.OnIntercomSpeaking;

            ServerHandlers.RoundStarted += ServerEvents.OnRoundStarted;
            ServerHandlers.RespawningTeam += ServerEvents.OnRespawningTeam;
            ServerHandlers.SendingRemoteAdminCommand += ServerEvents.OnSendingRACommand;
            ServerHandlers.ReportingCheater += ServerEvents.OnReportingCheater;
            ServerHandlers.LocalReporting += ServerEvents.OnLocalReporting;

            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            PlayerHandlers.Hurting -= PlayerEvents.OnHurting;
            PlayerHandlers.Died -= PlayerEvents.OnDied;
            PlayerHandlers.Destroying -= PlayerEvents.OnDestroying;
            PlayerHandlers.Verified -= PlayerEvents.OnVerified;
            PlayerHandlers.InteractingDoor -= PlayerEvents.OnInteractingDoor;
            PlayerHandlers.InsertingGeneratorTablet -= PlayerEvents.OnInsertingGeneratorTablet;
            PlayerHandlers.InteractingElevator -= PlayerEvents.OnInteractingElevator;
            PlayerHandlers.IntercomSpeaking -= PlayerEvents.OnIntercomSpeaking;

            ServerHandlers.RoundStarted -= ServerEvents.OnRoundStarted;
            ServerHandlers.RespawningTeam -= ServerEvents.OnRespawningTeam;
            ServerHandlers.SendingRemoteAdminCommand -= ServerEvents.OnSendingRACommand;
            ServerHandlers.ReportingCheater -= ServerEvents.OnReportingCheater;
            ServerHandlers.LocalReporting -= ServerEvents.OnLocalReporting;

            PlayerEvents = null;
            ServerEvents = null;
            base.OnDisabled();
        }
    }
}

