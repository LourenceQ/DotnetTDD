using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {}

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Message"] = "The application description page.";

        return View();
    }
}