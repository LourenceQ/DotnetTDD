namespace LoanApplication.Core;

public interface IDbContext
{
    int SaveChanges();
    void Dispose();
}
