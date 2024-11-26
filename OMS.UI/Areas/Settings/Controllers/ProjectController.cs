using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Project Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Project";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Task()
        {
            // Page Title
            ViewData["pTitle"] = "Task Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Project";
            ViewData["bChild"] = "Task";

            return View();
        }
    }
}

