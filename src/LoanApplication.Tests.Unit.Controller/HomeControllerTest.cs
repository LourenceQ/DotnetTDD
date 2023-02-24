using LoanApplication.Controllers;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace LoanApplication.Tests.Unit.Controller;

public class HomeControllerTest
{
    private Mock<ILoanRepository> loanRepository;
    private HomeController homeController;

    public HomeControllerTest()
    {
        loanRepository = new Mock<ILoanRepository>();
        loanRepository.Setup(x => x.GetLoanTypes()).Returns(GetLoanTypes());

        homeController = new HomeController(loanRepository.Object);
    }

    [Fact]
    public void TestIndex()
    {
        var result = homeController.Index();
        var viewResult = Assert.IsType<ViewResult>(result);
        var loanTypes = Assert.IsAssignableFrom<IEnumerable<LoanType>>(viewResult.ViewData["LoanTypes"]);
        Assert.Equal(2, loanTypes.Count());
    }

    private List<LoanType> GetLoanTypes()
    {
        var loanTypes = new List<LoanType>();
        loanTypes.Add(new LoanType()
        {
            Id = 1,
            Name = "Car Loan"
        });
        loanTypes.Add(new LoanType()
        {
            Id = 2,
            Name = "House Loan"
        });
        return loanTypes;
    }

    [Fact]
    public void TestAbout()
    {        
        var result = homeController.About();
        var viewResult = Assert.IsType<ViewResult>(result);
    }
}