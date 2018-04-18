using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int lenght = str.Length;
            
            for (int i = 0; i < lenght; i++)
            {
                char letter = str[i];
                 
                if (letter == 'и')
                {
                    Console.WriteLine(letter == 'и');
                    break;
                }
            }
           

        }
    }
}
