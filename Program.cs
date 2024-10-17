using System;
using System.Collections.Generic;

namespace Hacking_Simulator 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start() 
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO HACKING SIMULATOR!");
            Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
            Console.ReadKey(true);
            Console.Clear();
            MainProgram(); 
        }

        public static void MainProgram()
        {
            Console.WriteLine("Let's Get Started...");
            Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("CHOOSE ANY OF THE HACKS POSTED BELOW");
            Console.WriteLine("\n[1] Penetration [2] Remote Access [3] Upgrades");
            string response = Console.ReadKey(true).KeyChar.ToString().ToLower();
            if (response == "1")
            {
                Console.Clear();
                // Peneration();
            }
            else if (response == "2")
            {
                Console.Clear();
                // RemoteAccess();
            }
            else if (response == "3")
            {
                Console.Clear();
                // Upgrades();
            }
            else
            {
                MainProgram();
            }
        }
    }
}