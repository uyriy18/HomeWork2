using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] arr = new int[10] ;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 5);
                Console.Write(arr[i] + " ");
            }
            for(int i = 0; i < arr.Length; i++)//or we can use Array.sort() method
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\n\n");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
