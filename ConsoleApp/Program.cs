using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
            
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
