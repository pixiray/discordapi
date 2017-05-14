using System;
using System.Threading.Tasks;
using Pixiray.Discord.Api;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DiscordClient client = new DiscordClient();
            Task.Run(() => client.GetDiscordHealthAsync());
            Console.ReadLine();
        }
    }
}