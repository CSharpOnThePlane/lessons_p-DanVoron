using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masivchick = { 1, 1, 1, 5, 1, 1, 1, 1, 5 };
            int p = masivchick.Length;
            
            for (int geg = 0; geg < p; geg++)
            { 
              if (masivchick[geg]==5)
              {
                Console.WriteLine("тут есть 5" + " " + "и на " + geg + "Месте");
                break;
              }
            }
        }
    }
}
    