using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Inventory.Controllers;

/// <summary>
/// Page Author: Sivan T
/// Created On: 2024-12-02
/// Created By: Sivan T
/// Modified On:
/// Modified By: 
/// </summary>
/// <param name=""></param>
/// <returns></returns>

[Area("Inventory")]
public class InventoryController : Controller
{
    public IActionResult Index()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Index";
        return View();
    }
    public IActionResult Vendor()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Vendor";
        return View();
    }
    public IActionResult PurchaseProducts()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "PurchaseProducts";
        return View();
    }
    public IActionResult PurchaseOrder()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "PurchaseOrder";
        return View();
    }
    public IActionResult Bills()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Bills";
        return View();
    }
    public IActionResult VendorPayments()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "VendorPayments";
        return View();
    }
    public IActionResult VendorCredits()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "VendorCredits";
        return View();
    }
    public IActionResult Inventory()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Inventory";
        return View();
    }
    public IActionResult Assets()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Assets";
        return View();
    }
    public IActionResult Orders()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Orders";
        return View();
    }
    public IActionResult Products()
    {
        // Page Title
        ViewData["pTitle"] = "Inventory Profile";

        // Breadcrumb
        ViewData["bGParent"] = "Inventory";
        ViewData["bParent"] = "Inventory";
        ViewData["bChild"] = "Products";
        return View();
    }

}
