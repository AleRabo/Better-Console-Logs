using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterConsoleLogs
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Sets the log message when someone join the server. ({player} will be replaced with the players name.)")]
        public string JoinedMessage { get; set; } = "{player} has joined the server!";

        [Description("Sets the log message when someone leaves the server. ({player} will be replaced with the players name.)")]
        public string LeftMessage { get; set; } = "{player} has left the server.";

        [Description("Sets the log message when someone Interact with a door. ({player} will be replaced with the players name.)")]
        public string OnInteractingDoor { get; set; } = "{player} has left the server.";

        [Description("Sets the log message when someone activate a generator. ({player} will be replaced with the players name.)")]
        public string OnActivatingGenerator { get; set; } = "{player} has left the server.";

        [Description("Sets the log message when someone call an elevator. ({player} will be replaced with the players name.)")]
        public string OnCallingElevator { get; set; } = "{player} has called an elevator.";

        [Description("Sets the log message when someone speak at the intercom. ({player} will be replaced with the players name.)")]
        public string OnSpeakingIntercom { get; set; } = "{player} has activate the intercom.";
    }
}
