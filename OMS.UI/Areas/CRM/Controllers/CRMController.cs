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
        ViewData["bChild"] = "Lead Page";

        return View();
    }
    public IActionResult Client()
    {
        // Page Title
        ViewData["pTitle"] = "CRM Controll";

        // Breadcrumb
        ViewData["bGParent"] = "CRM";
        ViewData["bParent"] = "Client";
        ViewData["bChild"] = "Client Page";

        return View();
    }

}
