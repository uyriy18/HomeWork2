using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            int lastIndex = 0;
            Console.WriteLine("Write some leters");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Console.WriteLine("Enter the symbol");
            char c = Convert.ToChar(Console.ReadLine());
            for(int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] == c)
                {
                    Console.WriteLine("Your symbol is on the " + i + " position");
                    check = true;
                    lastIndex = i;
                }
            }
           
            string symbol = c.ToString();
            if (check)
            {
                str = str.Replace(symbol,symbol.ToUpper());
                str = str.Remove(lastIndex + 1);
                 
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("There isn't symbol in the line");
            }

        }
    }
}
