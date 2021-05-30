using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BetterConsoleLogs.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.LeftMessage.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has left the server");
        }

        public void OnVerified(VerifiedEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.JoinedMessage.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has joined the server");
        }

        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.OnInteractingDoor.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has interacted with door");
        }

        public void OnActivatingGenerator(InsertingGeneratorTabletEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.OnActivatingGenerator.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has activated a generator");
        }

        public void OnCallingElevator(InteractingElevatorEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.OnCallingElevator.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has called an elevator");
        }
        public void OnSpeakingIntercom(IntercomSpeakingEventArgs ev)
        {
            string message = BetterConsoleLogs.Singleton.Config.OnSpeakingIntercom.Replace("{player}", ev.Player.Nickname);
            Log.Info($"{ev.Player} has start the intercom");
        }
    }

}
