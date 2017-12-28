namespace TournamentManager.Model.Services.Test
{
    public class TestService : ITestService
    {
        private readonly ITest2Service _test2Service; 

        public TestService(ITest2Service test2Service)
        {
            _test2Service = test2Service;
        }

        public bool ItIsWorking()
        {
            return _test2Service.ItIsWorking();
        }
    }
}
