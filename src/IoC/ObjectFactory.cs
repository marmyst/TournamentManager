using StructureMap;

namespace TournamentManager.IoC
{
    public static class ObjectFactory
    {
        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                return _container;
            }
            set
            {
                if(_container == null)
                {
                    _container = value;
                }
            }
        }        
        public static T GetInstance<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
