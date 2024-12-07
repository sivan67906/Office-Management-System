using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Project Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Project";
            ViewData["bChild"] = "Dashboard";

            return View();
        }
        public IActionResult Project()
        {
            // Page Title
            ViewData["pTitle"] = "Projects Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Project";
            ViewData["bChild"] = "Project View";

            return View();
        }
        public IActionResult Task()
        {
            // Page Title
            ViewData["pTitle"] = "Task Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Task";
            ViewData["bChild"] = "Task View";

            return View();
        }
    }
}

