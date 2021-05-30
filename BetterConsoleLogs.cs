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

            base.OnEnabled();

            BetterConsoleLogs.Singleton = this;
        }

        public override void OnDisabled()
        {
            UnregisteredEvents();

            base.OnDisabled();
        }

        public void RegisterEvents()
        {

            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.RoundStarted += server.OnRoundStarted;

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
