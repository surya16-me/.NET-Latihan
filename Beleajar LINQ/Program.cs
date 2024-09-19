using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beleajar_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int angkarandom = random.Next(1, 11); 
            int inputan = 0;
            int jumlahcoba = 0;

            while (inputan != angkarandom)
            {
                Console.Write("\nMasukkin Angka: ");
                inputan = Convert.ToInt32(Console.ReadLine());
                jumlahcoba++;

                if (inputan < angkarandom)
                {
                    Console.WriteLine("Salah");
                }
                else if (inputan > angkarandom)
                {
                    Console.WriteLine("Salah");
                }
                else
                {
                    Console.WriteLine($"Benar, kamu udah coba {jumlahcoba} kali");
                }
            }
        }
    }
}
