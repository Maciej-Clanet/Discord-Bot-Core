using System;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Discord;
using DiscordBotCore.Storage;
using System.Threading.Tasks;

namespace DiscordBotCore
{
    internal class Program
    {
        private static async Task Main()
        {
            //Dependency injection container needs to register the dependencies and lifetimes of objects.
            Unity.RegisterTypes();

            var storage = Unity.Resolve<IDataStorage>();


            //Use the unity framework to get the discord connection. Unity will create all the required dependencies, 
            //and make connection into a singleton object, so all the requests for connection will receive the same connection
            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new DiscordBotCoreConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
