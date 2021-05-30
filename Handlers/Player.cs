using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BetterConsoleLogs.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            Log.Info($"{ev.Player} has left the server");
        }

        public void OnVerified(VerifiedEventArgs ev)
        {
            Log.Info($"{ev.Player} has joined the server");
        }

        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            Log.Info($"{ev.Player} has interacted with door");
        }

        public void OnActivatingGenerator(InsertingGeneratorTabletEventArgs ev)
        {
            Log.Info($"{ev.Player} has activated a generator");
        }

        public void OnCallingElevator(InteractingElevatorEventArgs ev)
        {
            Log.Info($"{ev.Player} has called an elevator");
        }
        public void OnSpeakingIntercom(IntercomSpeakingEventArgs ev)
        {
            Log.Info($"{ev.Player} has start the intercom");
        }
    }

}
