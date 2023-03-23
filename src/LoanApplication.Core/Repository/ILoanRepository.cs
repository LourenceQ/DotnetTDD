using LoanApplication.Core.Model;

namespace LoanApplication.Core.Repository;

public interface ILoanRepository
{
    List<LoanType> GetLoanTypes();
    List<Loan> GetBadCarLoans();
    List<Loan> GetCarLoans();
    List<Person> GetCarLoanDefaulters(int year)
}
