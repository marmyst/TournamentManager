using StructureMap;

namespace TournamentManager.View.Desktop.Registers
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
