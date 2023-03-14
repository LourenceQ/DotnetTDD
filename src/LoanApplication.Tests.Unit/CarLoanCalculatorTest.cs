using LoanApplication.Core;
using LoanApplication.Core.DTO;

namespace LoanApplication.Tests.Unit.Controller;

public class CarLoanCalculatorTest
{
    private CarLoanCalculator carLoanCalculator;
    public CarLoanCalculatorTest()
    {
        RateParser rateParser = new RateParser();
        this.carLoanCalculator = new CarLoanCalculator(rateParser);
    }

    #region TESTE COM MEMBERDATA DE MÉTODO ESTÁTICO
    /*[Theory, MemberData("GetLoanDTOs")]
    //[Theory, MemberData(nameof(GetLoanDTOs)]
    public void Test_CalculateLoan_ShouldReturnCorrectRate(LoanDTO loanDTO)
    {
        Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
        Assert.NotNull(loan);
        Assert.InRange(loan.InterestRate, 8, 12);
    }

    public static IEnumerable<object[]> GetLoanDTOs()
    {
        yield return new object[]
        {
            new LoanDTO
            {
                LoanType = LoanType.CarLoan,
                JobType = JobType.Professional,
                LocationType = LocationType.Location1
            }
        };

        yield return new object[]
        {
            new LoanDTO
            {
                LoanType = LoanType.CarLoan,
                JobType = JobType.Professional,
                LocationType = LocationType.Location2
            }
        };
    }*/
    #endregion

    #region TESTE COM MEMBERDATA DE PROPRIEDADE ESTÁTICA

    /*[Theory, MemberData("LoanDTOs")]
    public void Test_CalculateLoan_ShouldReturnCorrectRate2(LoanDTO loanDTO)
    {
        Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
        Assert.NotNull(loan);
        Assert.InRange(loan.InterestRate, 8, 12);
    }

    public static IEnumerable<object[]> LoanDTOs
    {
        get
        {
            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location1
                }
            };

            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location2
                }
            };
        }
    }*/
    #endregion
    
    #region TESTE COM MEMBDERDATA DE CLASSE ESPECIFICANDO A CLASSE DE TESTE COM MEMBERTYPE
    /*[Theory, MemberData(nameof(LoanDTOs), parameters: 1, MemberType = typeof(DataClass))]
    public void Test_CalculateLoan_ShouldReturnCorrectRate3(LoanDTO loanDTO)
    {
        Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
        Assert.NotNull(loan);
        Assert.InRange(loan.InterestRate, 8, 12);
    }*/

    #endregion
    [Fact]
    public void Test_CalculateLoan_ShouldReturnCorrectRate1()
    {
        // first scenario
        LoanDTO loanDTO1 = new LoanDTO();
        loanDTO1.LoanType = LoanType.CarLoan;
        loanDTO1.LocationType = LocationType.Location1;
        loanDTO1.JobType = JobType.Professional;
        Loan loan1 = carLoanCalculator.CalculateLoan(loanDTO1);

        Assert.NotNull(loan1);
        Assert.Equal(8, loan1.InterestRate);

        // second scenario
        LoanDTO loanDTO2 = new LoanDTO();
        loanDTO2.LoanType = LoanType.CarLoan;
        loanDTO2.LocationType = LocationType.Location2;
        loanDTO2.JobType = JobType.Professional;
        Loan loan2 = carLoanCalculator.CalculateLoan(loanDTO2);

        Assert.NotNull(loan2);
        Assert.Equal(10, loan2.InterestRate);
    }
}
