using LoanApplication.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Tests.Unit;

public class IndexMethod : HomeControllerTest
{
    [Fact]
    public void TestIndex()
    {
        var result = homeController.Index();
        var viewResult = Assert.IsType<ViewResult>(result);
        var loanTypes = Assert.IsAssignableFrom<IEnumerable<LoanType>>(viewResult.ViewData["LoanTypes"]);
        Assert.Equal(3, loanTypes.Count());
    }
    
}
