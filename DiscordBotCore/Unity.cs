using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using Unity;
using Unity.Resolution;
using Unity.Lifetime;

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
            //register IDataStorage type to be resolved by a singleton instance of InMemoryStorage
            _container.RegisterType<IDataStorage, InMemoryStorage>( new ContainerControlledLifetimeManager() );
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
