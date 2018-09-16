using System;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Discord;

namespace DiscordBotCore
{
    internal class Program
    {
        

        private static void Main()
        {

            Unity.RegisterTypes();


            var discordBotConfig = new DiscordBotCoreConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
