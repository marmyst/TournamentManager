using StructureMap;

namespace TournamentManager.IoC
{
    public static class ObjectFactory
    {
        private static Container _container;
        public static Container Container
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
