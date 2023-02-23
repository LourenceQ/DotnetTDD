using LoanApplication.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Tests.Unit.Controller;

public class HomeControllerTest
{
    [Fact]
    public void TestIndex()
    {
        var homeController = new HomeController();
        var result = homeController.Index();
        var viewResult = Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void TestAbout()
    {
        var homeController = new HomeController();
        var result = homeController.About();
        var viewResult = Assert.IsType<ViewResult>(result);
    }
}