using LoanApplication.Core.DTO;
using System.Collections;

namespace LoanApplication.Tests.Unit;

public class LoanDTOData : IEnumerable<object[]>
{
    private IEnumerable<object[]> data => new[]
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

    public IEnumerator<object[]> GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return data.GetEnumerator();
    }
}
