using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Inventory.Controllers;
[Area("Inventory")]
public class InventoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Vendor()
    {
        return View();
    }
    public IActionResult PurchaseProducts()
    {
        return View();
    }
    public IActionResult PurchaseOrder()
    {
        return View();
    }
    public IActionResult Bills()
    {
        return View();
    }
    public IActionResult VendorPayments()
    {
        return View();
    }
    public IActionResult VendorCredits()
    {
        return View();
    }
    public IActionResult Inventory()
    {
        return View();
    }
    public IActionResult Assets()
    {
        return View();
    }
    public IActionResult Orders()
    {
        return View();
    }
    public IActionResult Products()
    {
        return View();
    }

}
