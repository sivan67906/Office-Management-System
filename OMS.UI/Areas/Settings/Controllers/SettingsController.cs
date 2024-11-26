using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Settings Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Application()
        {
            // Page Title
            ViewData["pTitle"] = "Application Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Application";

            return View();
        }

        public IActionResult Purchase()
        {
            // Page Title
            ViewData["pTitle"] = "Purchase Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Purchase";

            return View();
        }
    }
}
