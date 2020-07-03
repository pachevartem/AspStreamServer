using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPStream
{
    public class ServerHub : Hub
    {
        public ServerHub()
        {
            Trace.WriteLine("Eaaaa, Create new hub");
        }


        public void ClientRegistration(string name)
        {
            Trace.WriteLine($"msg: {name}");
            if (name == "unity")
            {
                Pulse();
            }
        }

        public void Pulse()
        {
            Clients.All.SendCoreAsync("EventName", new object[] { });
        }

        public string EchoMsg(string word)
        {
            return word + "-" + word;
        }
    }
}
