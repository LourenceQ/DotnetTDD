namespace DotnetTddApproach
{
    [TestClass]
    public class LoanRepositoryTest
    {
        public LoanRepository loanRepository;

        public LoanRepositoryTest(LoanRepository loanRepository)
        {
            loanRepository = new LoanRepository();
        }

        [TestMethod]
        public void Tester_GetLoanById_ShouldReturnLoan()
        {
            var loan = loanRepository.GetLoanById(12);
            Assert.IsNotNull(loan);
        }
    }
}