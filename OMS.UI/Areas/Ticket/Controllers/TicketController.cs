using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Ticket.Controllers
{
    [Area("Ticket")]
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tickets()
        {
            return View();
        }
    }
}
