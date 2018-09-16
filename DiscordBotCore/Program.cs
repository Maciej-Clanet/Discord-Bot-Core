using Discord.WebSocket;
using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main()
        {

            Unity.RegisterTypes();

            Console.WriteLine("end");
            Console.ReadLine();
        }

    }
}
