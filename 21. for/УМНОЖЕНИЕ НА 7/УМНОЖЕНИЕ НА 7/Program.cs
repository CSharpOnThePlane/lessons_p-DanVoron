using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УМНОЖЕНИЕ_НА_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                int g = i * 7;
                Console.WriteLine(i + " " +"* 7 =" + " " + g);
            }
        }
    }
}
