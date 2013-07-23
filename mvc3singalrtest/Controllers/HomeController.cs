using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace mvc3singalrtest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Talk(string from, string msg)
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hub.Clients.All.sendMessage(from, msg);
            return new EmptyResult();
        }
    }
}