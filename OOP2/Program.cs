using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MstCar mstCar = new MstCar();
            mstCar.brand = "Kia";
            mstCar.name = "EV 6";
            mstCar.CarType = "Hatchback";
            mstCar.EngineType = "Electric Motor";

            Console.WriteLine(mstCar.name);
            Console.WriteLine(mstCar.EngineType);
        }
    }
}
