using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace SampleSignalR.Chat
{
    public class Chat : Hub
    {
        public void Send(string mensagem)
        {
            Clients.addMessage(mensagem);
        }
    }
}