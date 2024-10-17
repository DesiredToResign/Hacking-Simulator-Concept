using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacking_Simulator
{
    public class Utility
    {
        public static Random rand = new Random();
        public static void KeyPress()
        {
            Console.WriteLine("\nHit Any Key To continue");
            Console.ReadKey(true);
        }
        public static int Int(int min, int max)
        {
            return rand.Next(min, max);
        }
    }
}
