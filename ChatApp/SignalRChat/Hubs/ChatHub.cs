using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using SignalRChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        readonly ApplicationDbContext _dbContext;
        public ChatHub(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SendMessage(string user, string message)
        {
            Message messageObject = new Message()
            {
                Username = user,
                MessageText = message,
                MessageDate = DateTime.Now
            };
            _dbContext.Messages.Add(messageObject);
            await _dbContext.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
//send message metodumuz içerisinde gelen mesajlar aynı zamanda veri tabanına kaydedilecek