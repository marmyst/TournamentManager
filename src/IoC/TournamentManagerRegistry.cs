using StructureMap;

namespace IoC
{
    public class TournamentManagerRegistry : Registry
    {
        public TournamentManagerRegistry()
        {
            Scan(_ =>
            {
                _.Assembly("TournamentManager.Model");
                _.TheCallingAssembly();
                _.WithDefaultConventions();
            });
        }
    }
}
