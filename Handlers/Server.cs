using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace BetterConsoleLogs.Handlers
{
    class Server
    {


        public void OnRoundStarted()
        {
            Log.Info(message: "Round Started");
        }
    }
}
