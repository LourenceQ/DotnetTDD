using static LoanApplication.Core.DTO.LoanDTO;

namespace LoanApplication.Core;

public class LoanAppContext : IDbContext
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public int SaveChanges()
    {
        throw new NotImplementedException();
    }

    public bool Save()
    { throw new NotImplementedException(); }

    public LoanType LoanType { get; set; }
    public LocationType LocationType { get; set; }
    public JobType JobType { get; set; }
}
