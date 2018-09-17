using System;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Discord;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            //Dependency injection container needs to register the dependencies and lifetimes of objects.
            Unity.RegisterTypes();      

            //Settings for the bot
            var discordBotConfig = new DiscordBotCoreConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            //Use the unity framework to get the discord connection. Unity will create all the required dependencies, 
            //and make connection into a singleton object, so all the requests for connection will receive the same connection
            var connection = Unity.Resolve<Connection>();

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
