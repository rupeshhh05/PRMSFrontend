using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRMSFrontend.Models;

namespace PRMSFrontend.Controllers;

public class HomeController : Controller
{
    // LOGIN PAGE
    public IActionResult Index()
    {
        return View();
    }

    // ✅ ABOUT PAGE (THIS WAS MISSING)
    public IActionResult About()
    {
        return View();
    }

    // CONTACT PAGE (if you have Contact.cshtml)
    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}
