using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using TournamentManager.IoC;
using TournamentManager.Model.Services.Test;
using TournamentManager.View.Desktop.Registers;

namespace IoC.Test
{
    [TestClass]
    public class BootstrapTests
    {
        [TestMethod]
        public void BootstrapTest()
        {
            var bootstrap = new Bootstrap();
            bootstrap.Configure(new List<Registry>
            {
                new TournamentManagerRegistry(),
                new ViewRegistry()
            });

            ITestService testService = ObjectFactory.GetInstance<ITestService>();

            Assert.IsNotNull(testService);

            bool result = testService.ItIsWorking();

            Assert.IsTrue(result);
        }
    }
}
