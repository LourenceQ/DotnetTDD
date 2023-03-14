using LoanApplication.Core;

namespace LoanApplication.Tests.Unit;

public class EFCoreFixture : IDisposable
{
    public LoanAppContext Context { get; set; }
    public EFCoreFixture()
    {
        Context = new LoanAppContext();
    }

    public void Dispose()
    {
        Context = null;
    }
}
