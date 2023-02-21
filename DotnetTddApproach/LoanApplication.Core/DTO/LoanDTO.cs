namespace LoanApplication.Core.DTO;

public class LoanDTO
{
    public LoanType LoanTypeDTO { get; set; }
    public LocationType LocationTypeDTO { get; set; }
    public JobType JobTypeDTO { get; set; }

    public enum LoanType
    {
        CarLoan, HouseLoan
    }

    public enum LocationType
    {
        Location1, Location2, Location3
    }

    public enum JobType
    {
        Professional, Artisan
    }
}
