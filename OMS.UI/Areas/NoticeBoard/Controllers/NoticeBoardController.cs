using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.NoticeBoard.Controllers
{
    [Area("NoticeBoard")]
    public class NoticeBoardController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Notice Board Profile";

            // Breadcrumb
            ViewData["bGParent"] = "Inventory";
            ViewData["bParent"] = "Inventory";
            ViewData["bChild"] = "Notice Board";
            return View();
        }
    }
}
