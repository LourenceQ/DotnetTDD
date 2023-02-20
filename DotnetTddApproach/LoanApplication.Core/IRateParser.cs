using LoanApplication.Core.Model;

namespace LoanApplication.Core;

public interface IRateParser
{
    float GetRateByLoanType(LoanType loanType);
}
