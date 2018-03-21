using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.AccessControl;

namespace ConsoleApp17
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int lenght = str.Length;
            int k = lenght - 1;
            char letter = str[0];
            char letter2 = str[k];
            if(letter == letter2)
            {
                Console.WriteLine("Мне нравится ");
            }
            else
            {
                Console.WriteLine("мне не нравится");
            }
        }
    }
}
