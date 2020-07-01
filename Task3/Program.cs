using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            var rnd = new Random();
            for(int i = 0; i < arr.Length; i++ )
            {
                arr[i] = rnd.Next(1, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n\n Enter your digit");
            int digit = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == digit) count++;
            }
            Console.WriteLine("Amount of numbers equl your digit is " + count);
        }
    }
}
