using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 0, 0, 0 , 2, 0, 4, 3, 0, 4, 0, 15, 0, 5 };
            removeElements(ref arr);
            
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
     
         }
        
        private static void removeElements(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = (-1);
                }
            }
            for(int i = 1; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length - 1; j++)
                {
                    if(a[j] == -1)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        
    }
   
}
