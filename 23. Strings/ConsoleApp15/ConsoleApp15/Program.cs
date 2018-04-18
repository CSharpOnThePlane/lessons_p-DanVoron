using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string h = Console.ReadLine();
                int k = 0;
                int j = h.Length;
                string aka = "";
                for (int p = 0; p < j; p++)
                {
                    aka = aka + "*";

                }
                Console.WriteLine(aka);
            }
        }
    }
}
