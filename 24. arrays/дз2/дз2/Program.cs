using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз2
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 0;
            int[] edinairossia = { 2, 3,5, 1 ,1};
            int h = edinairossia.Length;
            for (int i = 0; i<h;i++)
            {
             
                
                if (edinairossia[i] < 3)
                {
                    d++;
                }

            }
            Console.WriteLine(d + " " + "команда имеет меньше 3 побед");
        }
    }
}
 