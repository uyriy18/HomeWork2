using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            var rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(0, 9);
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n Enter the nubers of colums you want to substitute( from 1 to 5 )");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > 0 && a < 6 && b > 0 && b < 6)
            {
                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        int temp = arr[i, a - 1];
                        arr[i, a - 1] = arr[i, b - 1];
                        arr[i, b - 1] = temp;
                    }
                }
                Console.WriteLine("\n\n\n");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }

        }
    }
}
