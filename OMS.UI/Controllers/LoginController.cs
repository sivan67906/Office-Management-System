using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult LoginConsumer()
    {
        return View();
    }
    public IActionResult ForgotPassword()
    {
        return View();
    }
    public IActionResult RecoverPassword()
    {
        return View();
    }
}
