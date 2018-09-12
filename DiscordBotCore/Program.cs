using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using System;
using System.Linq;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Unity.RegisterTypes();

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
