using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Tests.Unit;

public class AboutMethod : HomeControllerTest
{
    [Fact]
    public void TestAbout()
    {
        var result = homeController.About();
        var viewResult = Assert.IsType<ViewResult>(result);
    }
}
