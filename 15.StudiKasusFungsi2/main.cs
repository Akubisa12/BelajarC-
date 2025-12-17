using System;

namespace BelajarFungsi{
    class Program
    {
        static void Main(string[] args)
        {
            // Kasus : mengukur ubin kecil yang presisi
            // Perhatikan : Di coding, koma ditulis menggunakan TITIK

            double panjangUbin = 12.5;
            double lebarUbin = 4.2;

            double luasUbin = HitungLuas(panjangUbin, lebarUbin);

            Console.WriteLine("Panjang: " + panjangUbin);
            Console.WriteLine("Lebar: " + lebarUbin);
            Console.WriteLine("Total Luas: " + luasUbin);

            Console.ReadLine();
        }

        static double HitungLuas(double panjang, double lebar){
            return panjang * lebar;
        }
    }
}