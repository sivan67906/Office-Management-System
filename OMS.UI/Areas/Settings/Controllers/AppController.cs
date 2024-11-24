using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers;

[Area("Settings")]
public class AppController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "App";

        return View();
    }

    public IActionResult Company()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Company Setup";

        return View();
    }

    public IActionResult BusinessAddress()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Business Address";

        return View();
    }

    public IActionResult Notifications()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Notifications";

        return View();
    }

    public IActionResult Currency()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Currency";

        return View();
    }

    public IActionResult Contract()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Contract";

        return View();
    }

    public IActionResult Roles()
    {
        // Roles & Permissions both here only.

        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Roles";

        return View();
    }

    public IActionResult Message()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Message";

        return View();
    }

    public IActionResult Security()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Security";

        return View();
    }

    public IActionResult Permissions()
    {
        // Module Settings.

        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Permissions";

        return View();
    }

    public IActionResult Assets()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Assets";

        return View();
    }

    public IActionResult SMS()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "SMS";

        return View();
    }

    public IActionResult Planning()
    {
        // Page Title
        ViewData["pTitle"] = "App Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Planning";

        return View();
    }
}
