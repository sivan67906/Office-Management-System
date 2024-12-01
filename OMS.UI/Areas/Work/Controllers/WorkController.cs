using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Work.Controllers;

[Area("Work")]
public class WorkController : Controller
{
    public IActionResult Contract()
    {

        // Page Title
        ViewData["pTitle"] = "Work Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Work";
        ViewData["bParent"] = "Contract";
        ViewData["bChild"] = "Contract Page";

        return View();
    }
    public IActionResult Project()
    {

        // Page Title
        ViewData["pTitle"] = "Work Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Work";
        ViewData["bParent"] = "Project";
        ViewData["bChild"] = "Project Page";

        return View();
    }

    public IActionResult Task()
    {

        // Page Title
        ViewData["pTitle"] = "Work Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Work";
        ViewData["bParent"] = "Task";
        ViewData["bChild"] = "Task Page";

        return View();
    }

    public IActionResult Timesheet()
    {

        // Page Title
        ViewData["pTitle"] = "Work Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Work";
        ViewData["bParent"] = "Timesheet";
        ViewData["bChild"] = "Timesheet Page";

        return View();
    }
}
