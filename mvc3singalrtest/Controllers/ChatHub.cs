using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace mvc3singalrtest.Controllers
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        
    }
}