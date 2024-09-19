using System;

namespace Encapsulation
{
    //Class Lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        //Private field untuk menyimpan nilai radius
        private double radius;

        //Public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari nol");
                }
            }
        }

            //method buat hitung luas lingkaran
        public double Luas()
        {
            return 3.14 * radius * radius;
        }

        //Class Tabung menggunakan Lingkaran sebagai komponen
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            //Konstruktor untuk inisiasi tabung
            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius; //Menggunaka property untuk mengatur radius 
                this.tinggi = tinggi;
            }

            public double HitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(-2, 9);
                    Console.WriteLine("Volume tabung :" + tabung.HitungVolume());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
} 