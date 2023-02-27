using LoanApplication.Core;

namespace LoanApplication.Tests.Unit.Controller;

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
