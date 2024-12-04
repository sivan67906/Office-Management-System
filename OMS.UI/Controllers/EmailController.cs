using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OTPVerify()
        {
            return View();
        }
        public IActionResult Verify()
        {
            return View();
        }
    }
}
