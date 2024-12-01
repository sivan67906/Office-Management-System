using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Recruit.Controllers;

[Area("Recruit")]
public class RecruitController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Controll";

        // Breadcrumb
        ViewData["bGParent"] = "Recruit";
        ViewData["bParent"] = "Recruit";
        ViewData["bChild"] = "Index";

        return View();
    }
    public IActionResult Skill()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Controll";

        // Breadcrumb
        ViewData["bGParent"] = "Recruit";
        ViewData["bParent"] = "Recruit";
        ViewData["bChild"] = "Skill";

        return View();
    }
    public IActionResult Job()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Controll";

        // Breadcrumb
        ViewData["bGParent"] = "Recruit";
        ViewData["bParent"] = "Recruit";
        ViewData["bChild"] = "Job";

        return View();
    }

    public IActionResult JobApplication()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Controll";

        // Breadcrumb
        ViewData["bGParent"] = "Recruit";
        ViewData["bParent"] = "Recruit";
        ViewData["bChild"] = "Job Application";

        return View();
    }

    public IActionResult OfferLetter()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Controll";

        // Breadcrumb
        ViewData["bGParent"] = "Recruit";
        ViewData["bParent"] = "Recruit";
        ViewData["bChild"] = "Offer Letter";

        return View();
    }
}
