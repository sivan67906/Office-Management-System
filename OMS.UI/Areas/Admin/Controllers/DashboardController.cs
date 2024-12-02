using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Page Titles
            ViewData["pTitle"] = "Settings Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Pages";
            ViewData["bChild"] = "Dashboard";

            

            return View();
        }
    }
}
