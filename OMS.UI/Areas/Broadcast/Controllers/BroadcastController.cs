using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Broadcast.Controllers
{
    [Area("Broadcast")]
    public class BroadcastController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Notice Board Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Broadcast";
            ViewData["bParent"] = "Notice";
            ViewData["bChild"] = "Broadcast View";
            return View();
        }
        public IActionResult Broadcast()
        {
            // Page Title
            ViewData["pTitle"] = "Broadcast Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Broadcast";
            ViewData["bParent"] = "Notice";
            ViewData["bChild"] = "Broadcast View";
            return View();
        }
    }
}
