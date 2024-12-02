using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.NoticeBoard.Controllers
{
    [Area("NoticeBoard")]
    public class NoticeBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
