using LoanApplication.Core.DTO;
using LoanApplication.Core.Model;

namespace LoanApplication.Core;

public class LoanCalculator
{
    protected IRateParser rateParser;

    public LoanCalculator(IRateParser rateParser)
    {
        this.rateParser = rateParser;
    }

    /*public virtual LoanDTO CalculateLoan(LoanDTO loanDTO)
    {
        Loan loan = new Loan();
        if (loanDTO.LoanTypeDTO == LoanDTO.LoanType.CarLoan )
        {
            loan.LoanType = LoanDTO.LoanType.CarLoan;
            loan.InterestRate = rateParser.GetRateByLoanType(LoanDTO.LoanType.CarLoan);
            // do other processing
        }
        else if (loanDTO.LoanTypeDTO == LoanDTO.LoanType.HouseLoan)
        {
            loan.LoanTypeDTO = LoanDTO.LoanType.HouseLoan;
            loan.InterestRate = rateParser.GetRateByLoanType(LoanDTO.LoanType.HouseLoan);
            // do other processing
        }
        return loan;
    }*/

    public CarLoan CalculateCarLoan(LoanDTO loanDTO)
    {
        throw new NotImplementedException();
    }

    public HouseLoan CalculateHouseLoan(LoanDTO loanDTO)
    {
        throw new NotImplementedException();
    }

    public List<Rate> ParseRatesFromXmlString(string xmlString)
    {
        throw new NotImplementedException();
    }

    public List<Rate> ParseRatesFromXmlFile(string xmlFile)
    {
        throw new NotImplementedException();
    }

    /*public CurrencyConverter GetCurrencyConverter()
    {
        return new CurrencyConverter();
    }*/
}
