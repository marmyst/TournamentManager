using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentManager.IoC;
using TournamentManager.Model.Services.Test;

namespace IoC.Test
{
    [TestClass]
    public class BootstrapTests
    {
        [TestMethod]
        public void BootstrapTest()
        {
            var bootstrap = new Bootstrap();
            bootstrap.Configure();

            ITestService testService = ObjectFactory.GetInstance<ITestService>();

            Assert.IsNotNull(testService);

            bool result = testService.ItIsWorking();

            Assert.IsTrue(result);
        }
    }
}
