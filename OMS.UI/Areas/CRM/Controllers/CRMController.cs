using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.CRM.Controllers;

[Area("CRM")]
public class CRMController : Controller
{
    public IActionResult Lead()
    {
        // Page Title
        ViewData["pTitle"] = "CRM Settings";

        // Breadcrumb
        ViewData["bGParent"] = "CRM";
        ViewData["bParent"] = "Lead";
        ViewData["bChild"] = "Lead";

        return View();
    }
    public IActionResult Client()
    {
        // Page Title
        ViewData["pTitle"] = "CRM Control";

        // Breadcrumb
        ViewData["bGParent"] = "CRM";
        ViewData["bParent"] = "Client";
        ViewData["bChild"] = "Client";

        return View();
    }

}
