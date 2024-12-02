using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.NoticeBoard.Controllers
{
    public class NoticeBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
