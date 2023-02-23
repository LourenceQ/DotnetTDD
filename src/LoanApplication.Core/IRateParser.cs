using static LoanApplication.Core.DTO.LoanDTO;

namespace LoanApplication.Core;

public interface IRateParser
{
    float GetRateByLoanType(LoanType loanType);
}
