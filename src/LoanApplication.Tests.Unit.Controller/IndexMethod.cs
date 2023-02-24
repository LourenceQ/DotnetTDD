using Microsoft.AspNetCore.Mvc;
using static LoanApplication.Core.DTO.LoanDTO;

namespace LoanApplication.Tests.Unit.Controller;

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
