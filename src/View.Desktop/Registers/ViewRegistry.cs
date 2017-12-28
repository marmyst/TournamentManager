using StructureMap;

namespace TournamentManager.View.Desktop.Registers
{
    public class ViewRegistry : Registry
    {
        public ViewRegistry()
        {
            Scan(_ =>
            {
                _.TheCallingAssembly();
                _.WithDefaultConventions();
            });
        }
    }
}
