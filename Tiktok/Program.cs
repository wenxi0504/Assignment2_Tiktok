using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Assignment2Tiktok
{
    class Program
    {
        static void Main(string[] args)
        {   // Test tiktoks from local file
            Console.WriteLine("Displays all the tiktoks in the collection from local file");
            TikTokManager.Show();
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("Displays all the tiktoks with hashTag matching the argument'game'");
            TikTokManager.Show("game");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
           
            Console.WriteLine("Displays all the tiktoks with length greater than the 120");
            TikTokManager.Show(120);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
           
            Console.WriteLine("Displays all the tiktoks with audience matching the 'World'");
            TikTokManager.Show(Audience.World);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            //Test tiktoks from Initialize()method
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Testing Initialize method");
            TikTokManager.Initialize();
            Console.WriteLine("Displays all the tiktoks in the collection");
            TikTokManager.Show();
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("Displays all the tiktoks with hashTag matching the argument'movie'");
            TikTokManager.Show("movie");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("Displays all the tiktoks with length greater than the 210");
            TikTokManager.Show(210);
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("Displays all the tiktoks with audience matching the 'Special'");
            TikTokManager.Show(Audience.Special);
            Console.WriteLine("---------------------------------------------------------------------------------------------");



        }



    }
}
