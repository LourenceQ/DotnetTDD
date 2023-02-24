using LoanApplication.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Controllers;

public class HomeController : Controller
{
    private ILoanRepository loanRepository;
    public HomeController(ILoanRepository loanRepository)
    {
        this.loanRepository = loanRepository;
    }

    public IActionResult Index()
    {
        var loanTypes = loanRepository.GetLoanTypes();
        ViewData["LoanTypes"] = loanTypes;

        return View();
    }

    public IActionResult About()
    {
        ViewData["Message"] = "The application description page.";

        return View();
    }
}