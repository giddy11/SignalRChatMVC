using Microsoft.AspNetCore.SignalR;

namespace SignalRChatMVC.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //send updates to all the clients to receive the message
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}
