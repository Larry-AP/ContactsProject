using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net.WebSockets;

using WebAppMultiPage.Models;

namespace WebAppMultiPage.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx) => context = ctx;

        //attribute routing
        [Route("/")]
        public IActionResult Index()
        {
            var Contacts = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(Contacts);
        }

        //simple action method
        //attribute routing
        [Route("About")]
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }
        
    }
}
