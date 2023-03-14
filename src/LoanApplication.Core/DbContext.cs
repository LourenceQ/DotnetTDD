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

    public List<Loan>? Loan { get; set; }
    public List<CarLoan>? CarLoan { get; set; }
    public List<HouseLoan>? HouseLoan { get; set; }
}
