using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Finance.Controllers
{
    [Area("Finance")]
    public class FinanceController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Finance Control";

            return View();
        }
        public IActionResult Proposal()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Proposal";

            return View();
        }

        public IActionResult Estimates()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Estimates";

            return View();
        }
        public IActionResult Invoice()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Invoice";

            return View();
        }
        public IActionResult Payments()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Payments";

            return View();
        }
        public IActionResult CreditNote()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "CreditNote";

            return View();
        }
        public IActionResult EInvoice()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "E-Invoice";

            return View();
        }
        public IActionResult Expenses()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Expenses";

            return View();
        }
        public IActionResult BankAccount()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Control";

            // Breadcrumb
            ViewData["bGParent"] = "Finance";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Bank Account";

            return View();
        }
    }
}
