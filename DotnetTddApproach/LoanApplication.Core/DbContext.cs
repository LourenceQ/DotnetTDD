using LoanApplication.Core.Model;

namespace LoanApplication.Core;

public class DbContext : IDbContext
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public int SaveChanges()
    {
        throw new NotImplementedException();
    }

    public List<Loan> Loans { get; set; }
    public List<CarLoan> CarLoans { get; set; }
    public List<HouseLoan> HouseLoans { get; set; }
}
