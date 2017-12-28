using StructureMap;
using System.Collections.Generic;
using TournamentManager.IoC;

namespace IoC
{
    public class Bootstrap
    {
        public void Configure()
        {
            Configure(new List<Registry>());
        }

        public void Configure(IList<Registry> resisters)
        {
            ConfigureIoC(resisters);
        }

        private void ConfigureIoC(IList<Registry> resisters)
        {
            var container = new Container(c =>
            {
                foreach(Registry registry in resisters)
                {
                    c.AddRegistry(registry);
                }
            });
            ObjectFactory.Container = container;
        }
    }
}
