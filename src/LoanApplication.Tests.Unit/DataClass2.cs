using LoanApplication.Core.DTO;

namespace LoanApplication.Tests.Unit;

public class DataClass2
{
    public static IEnumerable<object[]> GetLoanDTOs(int records)
    {
        var loanDTOs = new List<object[]>
        {
            new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location1
                }
            },
            new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location2
                }
            }
        };
        return loanDTOs.TakeLast(records);
    }
}
