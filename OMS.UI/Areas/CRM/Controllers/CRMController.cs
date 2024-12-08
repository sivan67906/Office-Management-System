using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.CRM.Controllers;

[Area("CRM")]
public class CRMController : Controller
{
    public IActionResult Lead()
    {
        // Page Title
        ViewData["pTitle"] = "Leads Profile";

        // Breadcrumb
        ViewData["bGParent"] = "CRM";
        ViewData["bParent"] = "Lead";
        ViewData["bChild"] = "Lead View";

        return View();
    }
    public IActionResult Client()
    {
        // Page Title
        ViewData["pTitle"] = "Clients Profile";

        // Breadcrumb
        ViewData["bGParent"] = "CRM";
        ViewData["bParent"] = "Client";
        ViewData["bChild"] = "Client View ";

        return View();
    }
}
