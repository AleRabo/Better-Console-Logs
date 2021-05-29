using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BetterConsoleLogs.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.LeftMessage.Replace("{player}", ev.Player.Nickname);
            Log.Info(message: $"{ev.Player} has left the server");
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.JoinedMessage.Replace("{player}", ev.Player.Nickname);
            Log.Info(message:$"{ev.Player} has joined the server");
        }

        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.OnInteractingDoor.Replace("{player}", ev.Player.Nickname);
            Log.Info(message: $"{ev.Player} has interacted with door");
        }

        public void OnActivatingGenerator(InsertingGeneratorTabletEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.OnActivatingGenerator.Replace("{player}", ev.Player.Nickname);
            Log.Info(message: $"{ev.Player} has activated a generator");
        }

        public void OnCallingElevator(InteractingElevatorEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.OnCallingElevator.Replace("{player}", ev.Player.Nickname);
            Log.Info(message: $"{ev.Player} has called an elevator");
        }
        public void OnSpeakingIntercom(IntercomSpeakingEventArgs ev)
        {
            string message = BetterConsoleLogs.Instance.Config.OnSpeakingIntercom.Replace("{player}", ev.Player.Nickname);
            Log.Info(message: $"{ev.Player} has start the intercom");
        }
    }

}
