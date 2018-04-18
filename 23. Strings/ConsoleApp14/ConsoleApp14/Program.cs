using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "";
            int g = int.Parse(Console.ReadLine());
            for(int h = 0;h<g; h++)
            {
               k = k + "*";
            }
            Console.WriteLine(k);
        }
    }
}
