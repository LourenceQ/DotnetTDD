using LoanApplication.Core.Repository;

namespace LoanApplication.Core;

public class LoanService
{
    private readonly ILoanRepository loanRepository;

    public LoanService(ILoanRepository loanRepository)
	{
        this.loanRepository = loanRepository;
    }

    public List<Loan> GetBadCarLoans()
    {
        List<Loan> badLoans = loanRepository.GetBadCarLoans();

        return badLoans;
    }
}
