using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    goto End;
                }
            }

        End:
            Console.WriteLine("Akhir iterasi");
        }
    }
}
