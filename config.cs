using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterConsoleLogs
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("are RA command logs enabled?")]
        public bool CommandLogs { get; set; } = false;
    }
}
