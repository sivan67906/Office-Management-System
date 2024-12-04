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
            // Page Title
            ViewData["pTitle"] = "Ticket Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Ticket";
            ViewData["bParent"] = "Ticket";
            ViewData["bChild"] = "Tickets";

            return View();
        }
    }
}
