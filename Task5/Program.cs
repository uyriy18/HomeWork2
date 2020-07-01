using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some symbols : ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            Console.WriteLine("\n\n\nStatistic :");
            Console.WriteLine("Capacity : " + sb.Capacity);
            Console.WriteLine("The length = " + sb.Length);
            char[] c = str.ToCharArray();
            int lowLeters = 0;
            int bigLeters = 0;
            int digits = 0;
            int otherSymbols = 0;
            for(int i = 0; i < c.Length; i++)
            {
                int temp = (int)c[i];
                if (temp > 47 && temp < 57)  digits++; 
                else if (temp > 96 && temp < 123) lowLeters++;
                else if (temp > 64 && temp < 91) bigLeters++;
                else otherSymbols++;
            }
            Console.WriteLine("Digits : " + digits);
            Console.WriteLine("Low leters : " + lowLeters);
            Console.WriteLine("Big leters : " + bigLeters);
            Console.WriteLine("Other symbols : " + otherSymbols);

        }
    }
}
