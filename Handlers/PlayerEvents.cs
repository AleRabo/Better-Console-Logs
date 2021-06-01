// -----------------------------------------------------------------------
// <copyright file="PlayerEvents.cs" company="AleRabo">
// Copyright (c) AleRabo. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace BetterConsoleLogs.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;

    /// <summary>
    /// Handles all events subscribed from <see cref="Exiled.Events.Handlers.Player"/>.
    /// </summary>
    public class PlayerEvents
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDestroying(DestroyingEventArgs ev)
        {
            Log.Info($"{ev.Player.Nickname} has left the server");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnVerified(VerifiedEventArgs)"/>
        public void OnVerified(VerifiedEventArgs ev)
        {
            Log.Info($"{ev.Player} has joined the server");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnInteractingDoor(InteractingDoorEventArgs)"/>
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            Log.Info($"{ev.Player} has interacted with door");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnInsertingGeneratorTablet(InsertingGeneratorTabletEventArgs)"/>
        public void OnInsertingGeneratorTablet(InsertingGeneratorTabletEventArgs ev)
        {
            Log.Info($"{ev.Player} has activated a generator");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnInteractingElevator(InteractingElevatorEventArgs)"/>
        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            Log.Info($"{ev.Player} has called an elevator");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnIntercomSpeaking(IntercomSpeakingEventArgs)"/>
        public void OnIntercomSpeaking(IntercomSpeakingEventArgs ev)
        {
            Log.Info($"{ev.Player} has start the intercom");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDied(DiedEventArgs ev)
        {
            Log.Info($"{ev.Killer.Nickname} just killed {ev.Target.Nickname}. {ev.HitInformations.Amount} damage.");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnHurting(HurtingEventArgs)"/>
        public void OnHurting(HurtingEventArgs ev)
        {
            Log.Info($"{ev.Attacker.Nickname} has hurt {ev.Target.Nickname} with {ev.Tool}. {ev.Amount} damage. Damage Type: {ev.DamageType}");
        }
    }
}
