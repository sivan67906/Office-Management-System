using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Event.Controllers;
[Area("Event")]
public class EventController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Event()
    {
        return View();
    }
}
