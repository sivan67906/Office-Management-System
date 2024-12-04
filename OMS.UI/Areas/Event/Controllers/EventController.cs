using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Event.Controllers;
[Area("Event")]
public class EventController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "Event Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Event";
        ViewData["bParent"] = "Event";
        ViewData["bChild"] = "Index";
        return View();
    }
    public IActionResult Event()
    {
        // Page Title
        ViewData["pTitle"] = "Event Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Event";
        ViewData["bParent"] = "Event";
        ViewData["bChild"] = "Event";
        return View();
    }
}
