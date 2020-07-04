using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;


  


namespace Assignment2Tiktok
{
    static class TikTokManager
    {      //  Private instance variables(Fields)
        private static List<TikTok> TIKTOKS;
         private static string FILENAME="Tiktokfile.txt";
         static TikTokManager()
         { // Initialize the TIKTOKS field to a new list of tiktok
            TIKTOKS = new List<TikTok>();
            //Opens the file specified by the filename field for reading
            TextReader reader = new StreamReader(FILENAME);
            string line = reader.ReadLine();
            // Using a looping structure it does the following:
            //This is repeated until the input from the file is empty (null).
            while (line != null)
            {
                //Reads one line from the file
                // Passes this line to the static Parse() method of the TikTok class to create a tiktok object.
                // The resulting object is added to the tiktok collection.
                TIKTOKS.Add(TikTok.Parse(line));
                line = reader.ReadLine();
            }
            reader.Close();
         }
         public static void Initialize()
        {  
            //Creates about 5 tiktoks objects and add them to the tiktok collection.
            TikTok T = new TikTok("TylerSwift", 300, "music", Audience.World);
           TikTok E = new TikTok("EmmaWatson", 210, "movie", Audience.Group);
           TikTok J = new TikTok("JessiJ", 410, "movie", Audience.World);
           TikTok A = new TikTok("AriannaGrande", 40, "music", Audience.Special);
           TikTok K = new TikTok("KatePerry", 30, "movie", Audience.Special);
           TIKTOKS.Add(T);
           TIKTOKS.Add(E);
           TIKTOKS.Add(J);
           TIKTOKS.Add(A);
           TIKTOKS.Add(K);
        }

         public static void Show()
         {
            //displays all the tiktoks in the collection.
            foreach (TikTok x in TIKTOKS)
            {
                Console.WriteLine(x);
            }
         }

         public static void Show(string tag)
        { //It displays all the tiktoks with hashTag matching the argument.This comparison must be case in-sensitive.
            foreach (TikTok x in TIKTOKS)
            {
                if (tag==x.Hashtag)
                {
                    Console.WriteLine(x);
                }
            }
         }
         public static void Show(int length)
        {//It displays all the tiktoks with length greater than the argument.
            foreach (TikTok x in TIKTOKS)
            {
                if (length<x.Length)
                {
                    Console.WriteLine(x);
                }
            }
        }
         public static void Show(Audience audience)
        {//It displays all the tiktoks with audience matching the argument.
            
            foreach (TikTok x in TIKTOKS)
            {
                if (audience==x.Audience)
                {
                    Console.WriteLine(x);
                }
            }
        }
     }
}
