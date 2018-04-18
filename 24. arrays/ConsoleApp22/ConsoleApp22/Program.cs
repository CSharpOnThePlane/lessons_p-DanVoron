using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masivchick = { 1,2,3,44,5,6,7,8,9,10 };
            int length = masivchick.Length;
            for (int o = 0; o < length; o++) 
            {

                if (masivchick[o] % 2==0)
                {
                    Console.WriteLine(masivchick[o] + " " + "делится на 2");
                }
            }
            //|\\
            //|\\
            //|\\
            //|\\
            //|\\
            //|\\
            //|\\
           ///|\\\




        }
    }
}
