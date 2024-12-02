using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.HR.Controllers;

[Area("HR")]

public class HRController : Controller
{
    public IActionResult Employee()
    {

        // Page Title
        ViewData["pTitle"] = "HR Control";

        // Breadcrumb
        ViewData["bGParent"] = "HR";
        ViewData["bParent"] = "Employee";
        ViewData["bChild"] = "Employee";

        return View();
    }
    public IActionResult Leave()
    {

        // Page Title
        ViewData["pTitle"] = "HR Control";

        // Breadcrumb
        ViewData["bGParent"] = "HR";
        ViewData["bParent"] = "Leave";
        ViewData["bChild"] = "Leave";

        return View();
    }

    public IActionResult Designation()
    {

        // Page Title
        ViewData["pTitle"] = "HR Control";

        // Breadcrumb
        ViewData["bGParent"] = "HR";
        ViewData["bParent"] = "Designation";
        ViewData["bChild"] = "Designation";

        return View();
    }

    public IActionResult Department()
    {

        // Page Title
        ViewData["pTitle"] = "HR Control";

        // Breadcrumb
        ViewData["bGParent"] = "HR";
        ViewData["bParent"] = "Department";
        ViewData["bChild"] = "Department";

        return View();
    }
}
