using LoanApplication.Controllers;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;
using Moq;

namespace LoanApplication.Tests.Unit;

public class HomeControllerTest
{
    public Mock<ILoanRepository> loanRepository;
    public HomeController homeController;

    public HomeControllerTest()
    {
        loanRepository = new Mock<ILoanRepository>();
        loanRepository.Setup(x => x.GetLoanTypes()).Returns(GetLoanTypes());

        homeController = new HomeController(loanRepository.Object);
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
}