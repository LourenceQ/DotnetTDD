using LoanApplication.Core.DTO;

namespace LoanApplication.Tests.Unit;

public class DataClass
{
    public static IEnumerable<object[]> LoanDTOs
    {
        get
        {
            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location1
                }
            };

            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location2
                }
            };
        }
    }
}
