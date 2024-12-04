using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Payroll.Controllers;

[Area("Payroll")]
public class PayrollController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "Payroll Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Payroll";
        ViewData["bParent"] = "Payroll";
        ViewData["bChild"] = "Index";

        return View();
    }
    public IActionResult Payroll()
    {
        // Page Title
        ViewData["pTitle"] = "Payroll Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Payroll";
        ViewData["bParent"] = "Payroll";
        ViewData["bChild"] = "Payroll";

        return View();
    }
    public IActionResult EmployeeSalary()
    {
        // Page Title
        ViewData["pTitle"] = "Recruit Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Payroll";
        ViewData["bParent"] = "Payroll";
        ViewData["bChild"] = "Employee Salary";

        return View();
    }
}