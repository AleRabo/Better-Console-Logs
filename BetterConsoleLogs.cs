using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace BetterConsoleLogs
{

    public class BetterConsoleLogs : Plugin<Config>
    {

        public override Version RequiredExiledVersion => new Version(2, 10, 0);

        private static readonly Lazy<BetterConsoleLogs> LazyInstace = new Lazy<BetterConsoleLogs>(valueFactory: () => new BetterConsoleLogs());
        public static BetterConsoleLogs Instance => LazyInstace.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Player player;
        private Handlers.Server server;

        private BetterConsoleLogs()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisteredEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.RoundStarted += server.OnRoundStarted;

            Player.Left += player.OnLeft;
            Player.Joined += player.OnJoined;
            Player.InteractingDoor += player.OnInteractingDoor;
            Player.InsertingGeneratorTablet += player.OnActivatingGenerator;
            Player.InteractingElevator += player.OnCallingElevator;
            Player.IntercomSpeaking += player.OnSpeakingIntercom;
        }

        public void UnregisteredEvents()
        {

            Server.RoundStarted -= server.OnRoundStarted;

            Player.Left -= player.OnLeft;
            Player.Joined -= player.OnJoined;
            Player.InteractingDoor -= player.OnInteractingDoor;
            Player.InsertingGeneratorTablet -= player.OnActivatingGenerator;
            Player.InteractingElevator -= player.OnCallingElevator;
            Player.IntercomSpeaking -= player.OnSpeakingIntercom;

            player = null;
            server = null;
        }
    }
}

