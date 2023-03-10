using LoanApplication.Core.DTO;

namespace LoanApplication.Core;

public interface IRateParser
{
    float GetRateByLoanType(LoanType loanType);
}
