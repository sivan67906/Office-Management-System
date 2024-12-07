
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers;



[Area("Settings")]
public class CompanyController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "Common Settings";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Dashboard";

        return View();
    }
    public IActionResult Consumer()
    {
        // Page Title
        ViewData["pTitle"] = "Consumers Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Consumer";
        ViewData["bChild"] = "Consumer List";

        return View();
    }

    public IActionResult SearchConsumer()
    {
        // Page Title
        ViewData["pTitle"] = "Search Consumers Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "SearchConsumer";
        ViewData["bChild"] = "Filter";

        return View();
    }


    public IActionResult Department()
    {
        // Page Title
        ViewData["pTitle"] = "Departments Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Department ";
        ViewData["bChild"] = "Department View";

        return View();
    }


    public IActionResult Designation()
    {
        // Page Title
        ViewData["pTitle"] = "Designations Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Designation ";
        ViewData["bChild"] = "Designation View";

        return View();
    }


    public IActionResult Client()
    {
        // Page Title
        ViewData["pTitle"] = "Clients Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Client";
        ViewData["bChild"] = "Client View";

        return View();
    }

    public IActionResult Company()
    {
        // Page Title
        ViewData["pTitle"] = "Companies Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Company List";

        return View();
    }


    public IActionResult BusinessAddress()
    {
        // Page Title
        ViewData["pTitle"] = "Business Locations Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Business Location Index";

        return View();
    }


    public IActionResult Notifications()
    {
        // Page Title
        ViewData["pTitle"] = "Company Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Notifications";

        return View();
    }

    public IActionResult Currency()
    {
        // Page Title
        ViewData["pTitle"] = "Currencies Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Currency";
        ViewData["bChild"] = "Currency View";

        return View();
    }

    public IActionResult Contract()
    {
        // Page Title
        ViewData["pTitle"] = "Contracts Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Contract";
        ViewData["bChild"] = "Contract View";

        return View();
    }



    public IActionResult Roles()
    {
        // Roles & Permissions both here only.

        // Page Title
        ViewData["pTitle"] = "Roles Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Roles";
        ViewData["bChild"] = "Roles View";

        return View();
    }


    public IActionResult Message()
    {
        // Page Title
        ViewData["pTitle"] = "Message Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Message";
        ViewData["bChild"] = "Message view";

        return View();
    }

    public IActionResult Security()
    {
        // Page Title
        ViewData["pTitle"] = "Company Profile";

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
        ViewData["pTitle"] = "Company Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Permissions";

        return View();
    }

    public IActionResult Assets()
    {
        // Page Title
        ViewData["pTitle"] = "Company Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Company";
        ViewData["bChild"] = "Assets";

        return View();
    }

    public IActionResult SMS()
    {
        // Page Title
        ViewData["pTitle"] = "SMS Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "SMS";
        ViewData["bChild"] = "SMS View";

        return View();
    }


    public IActionResult Planning()
    {
        // Page Title
        ViewData["pTitle"] = "Plannings Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Planning";
        ViewData["bChild"] = "Planning View";

        return View();
    }
    public IActionResult DesignationRoleMap()
    {
        // Page Title
        ViewData["pTitle"] = "Roles Mappings Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Settings";
        ViewData["bParent"] = "Roles Mapping";
        ViewData["bChild"] = "Roles Mapping View";

        return View();
    }
}
