using Microsoft.AspNetCore.SignalR;

namespace web.Hubs
{
    public class Hubs : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
