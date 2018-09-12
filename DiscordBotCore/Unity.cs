using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using Unity;
using Unity.Resolution;

namespace DiscordBotCore
{
    public static class Unity
    {

        private static UnityContainer _container;

        //Returns the container, but first makes sure it's initialised. If it's not, initialises it.
        public static UnityContainer Container
        {
            get
            {
                if(_container == null){ RegisterTypes(); }
                return _container;
            }
        }


        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>();
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
