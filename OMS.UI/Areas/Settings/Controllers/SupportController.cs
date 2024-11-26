using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Support Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Support";
            ViewData["bChild"] = "Index";

            return View();
        }

        public IActionResult Ticket()
        {
            // Page Title
            ViewData["pTitle"] = "Ticket Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Support";
            ViewData["bChild"] = "Ticket";

            return View();
        }

        public IActionResult Lead()
        {
            // Page Title
            ViewData["pTitle"] = "Lead Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Support";
            ViewData["bChild"] = "Lead";

            return View();
        }
    }
}

