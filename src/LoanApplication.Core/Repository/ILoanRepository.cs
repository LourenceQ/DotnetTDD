using LoanApplication.Core.Model;

namespace LoanApplication.Core.Repository;

public interface ILoanRepository
{
    List<LoanType> GetLoanTypes();
}
