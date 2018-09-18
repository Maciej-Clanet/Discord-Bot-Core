using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using Unity;
using Unity.Resolution;
using Unity.Lifetime;
using Unity.Injection;
using DiscordBotCore.Discord;
using Discord.WebSocket;

namespace DiscordBotCore
{
    /*Unity is a dependency injection framework. It is used to create various objects in the application, while resolving their dependencies
     and managing their lifecycle*/
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

        /*A single location to specify how to resolve dependencies, and set lifecycle the objects*/
        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            //Singleton. Each subsequent time it's called will return the same instance.
            _container.RegisterSingleton<IDataStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();

            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Discord.Connection>();

        }

        //basic wrapper function to simply resolving elements.
        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
