using System;

using System.IO;


namespace BingArticleCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\shipin.json";



            string readText = File.ReadAllText(path);

            Console.WriteLine(readText);
            Console.ReadKey();


        }
    }
}
