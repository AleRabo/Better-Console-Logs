using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace BetterConsoleLogs
{

    public class BetterConsoleLogs : Plugin<Config>
    {
        public override string Author { get; } = "AleRabo";

        public override string Name { get; } = "BetterConsoleLogs";

        public override string Prefix { get; } = "BCL";

        public override Version Version { get; } = new Version(1, 0, 2);

        private Handlers.Player player;
        private Handlers.Server server;

        private BetterConsoleLogs()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();

            Log.Info("Better Console Logs is enabled! Thank you!!! - AleRabo");

            base.OnEnabled();

            BetterConsoleLogs.Singleton = this;
        }

        public override void OnDisabled()
        {
            UnregisteredEvents();

            Log.Error("Better Console Logs is not enabled. To enable it just set is_enabled to true in configs");

            base.OnDisabled();
        }

        public void RegisterEvents()
        {

            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.RoundStarted += server.OnRoundStarted;
            Server.RespawningTeam += server.OnRespawningTeam;
            Server.SendingConsoleCommand += server.OnSendingConsoleCommand;
            Server.ReportingCheater += server.OnReportingCheater;
            Server.LocalReporting += server.OnLocalReporting;

            Player.Hurting += server.OnHurting;
            Player.Died += server.OnDeath;
            Player.Left += player.OnLeft;
            Player.Verified += player.OnVerified;
            Player.InteractingDoor += player.OnInteractingDoor;
            Player.InsertingGeneratorTablet += player.OnActivatingGenerator;
            Player.InteractingElevator += player.OnCallingElevator;
            Player.IntercomSpeaking += player.OnSpeakingIntercom;
        }

        public void UnregisteredEvents()
        {

            Server.RoundStarted -= server.OnRoundStarted;
            Server.RespawningTeam -= server.OnRespawningTeam;
            Server.SendingConsoleCommand -= server.OnSendingConsoleCommand;
            Server.ReportingCheater -= server.OnReportingCheater;
            Server.LocalReporting -= server.OnLocalReporting;


            Player.Hurting -= server.OnHurting;
            Player.Died -= server.OnDeath;
            Player.Left -= player.OnLeft;
            Player.Verified -= player.OnVerified;
            Player.InteractingDoor -= player.OnInteractingDoor;
            Player.InsertingGeneratorTablet -= player.OnActivatingGenerator;
            Player.InteractingElevator -= player.OnCallingElevator;
            Player.IntercomSpeaking -= player.OnSpeakingIntercom;
    }
    public static BetterConsoleLogs Singleton;
}
}
