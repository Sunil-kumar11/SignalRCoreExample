using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCoreExample
{
    public class ChatHub :  Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("newMessage", "anonymous", message);
        }
        //public async Task SendMessage(string user , string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}

    }
}
