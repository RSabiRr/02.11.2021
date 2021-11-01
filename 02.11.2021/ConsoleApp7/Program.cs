using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Rasim is a masculine given name of Arabic origin meaning \"planner\" ,\"architect\"";


            if (text.Length>50)
            {
                Console.WriteLine(text.Substring(0, 50)+"...");
            }
            else
            {
                Console.WriteLine(text);

            }
        }
    }
}
