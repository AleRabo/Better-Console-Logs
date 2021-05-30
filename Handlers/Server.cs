using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

namespace BetterConsoleLogs.Handlers
{
    public class Server
    {
        public void OnRoundStarted()
        {
            Log.Info("Round Started");
        }


        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            
            if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
            {
                Log.Info($"Nine Tailed Fox spawned with {ev.Players}");
            }

            if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
            {
                Log.Info($"Chaos Insurgency spawned with {ev.Players}");
            }

        }

        public void OnSendingConsoleCommand(SendingConsoleCommandEventArgs ev)
        {
            if (BetterConsoleLogs.Singleton.Config.CommandLogs)
            {
                Log.Info($"{ev.ReturnMessage} was typed in the console by {ev.Player}");
            }
        }

        public void OnReportingCheater(ReportingCheaterEventArgs ev)
        {
            Log.Info($"{ev.Reporter} just reported {ev.Reported} for {ev.Reason}");
        }

        public void OnLocalReporting(LocalReportingEventArgs ev)
        {
            Log.Info($"{ev.Issuer} just local reported {ev.Target} for {ev.Reason}");
        }

        internal void OnDeath(DiedEventArgs ev)
        {
            Log.Info($"{ev.Killer} just killed {ev.Target}. {ev.HitInformations} of damage.");
        }

        internal void OnHurting(HurtingEventArgs ev)
        {
            Log.Info($"{ev.Attacker} has hurted {ev.Target} with {ev.Tool}. {ev.HitInformations} of damage. damage type: {ev.DamageType}");
        }
    }
}
