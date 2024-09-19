using System;

namespace Inheritance
{
    //Parent class
    public class Lingkaran
    {
        double luas;
        
        //Method untuk menghitung luas
        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }

    //Child class
    public class Tabung : Lingkaran
    {
        double volume;

        public Tabung(int tinggi, double r)
        {
            //Menggunakan metode luas lingkaran dari kelas lingkaran
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            //Membuat objek
            Tabung tabung = new Tabung(5, 10);

            //Menampilkan volume tabung
            Console.WriteLine("Volume = " + tabung.getVolume());
        }

    }
}