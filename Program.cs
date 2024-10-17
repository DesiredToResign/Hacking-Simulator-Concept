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
            Console.WriteLine("Alrighty...");
            Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("CHOOSE ANY OF THE HACKS POSTED BELOW");
            Console.WriteLine("\n[1] Penetration [2] Remote Access [3] Upgrades");
            string response = Console.ReadKey(true).KeyChar.ToString().ToLower();
            if (response == "1")
            {
                Console.Clear();
                Penetration();
            }
            else if (response == "2")
            {
                Console.Clear();
                RemoteAccess();
            }
            else if (response == "3")
            {
                Console.Clear();
                Upgrades();
            }
            else
            {
                Console.Clear();
                MainProgram();
            }
        }

        public static void Penetration()
        {
            Console.WriteLine("// SUPER-DUPER EPIC PEN-TESTER 9000 //");
            Console.WriteLine("\n [1] START PEN-TEST [2] BACK");
            string response = Console.ReadKey(true).KeyChar.ToString().ToLower();
            if (response == "1") 
            {
                Console.Clear();
                Console.Beep();
                Console.WriteLine("CHOOSE TARGET...");
                Console.WriteLine("\n[1] Level 1 Scrub \n[2] Level 20 Hacker \n[3] Level 100 Cybersecurity Expert \n[4] Random Bank");
                if (response == "1")
                {

                }
                else if (response == "2")
                {

                }
                else if (response == "3")
                {

                }
                else if (response == "4")
                {

                }
            }
            else if (response == "2")
            {
                Console.Clear();
                MainProgram();
            }
        }

        public static void RemoteAccess()
        {

        }

        public static void Upgrades()
        {

        }
    }
}