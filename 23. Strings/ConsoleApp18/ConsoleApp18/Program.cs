using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int lenght = str.Length;
            int j = 0;
            for (int i = 0; i < lenght; i++)
            {
                char letter = str[i];

                if (letter == 'ж')
                {
                    j++;
                    
                    
                }
            }
            Console.WriteLine("ты написал"+" "+j+" "+ "столько ж");
        }
    }
}
