using System;
using System.Collections.Generic;

namespace Hacking_Simulator 
{
    class Program
    {
        string response = Console.ReadKey(true).KeyChar.ToString().ToLower();
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

        }
    }
}