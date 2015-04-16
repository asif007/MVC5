using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5
{
    public class Chathub :Hub
    {
        public void send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}