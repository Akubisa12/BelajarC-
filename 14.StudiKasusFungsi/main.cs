using System;

namespace StudiKasusFungsi
{
    class Program {
        static void Main(string[] args)
        {
            int panjangMeja = 120;
            int lebarMeja = 60;

            int luasMeja = HitungLuas(panjangMeja, lebarMeja);

            Console.WriteLine("Luas meja adalah: " + luasMeja + " cm persegi");

            Console.WriteLine("Luas buku adalah: " + HitungLuas(20, 15) + " cm persegi");

            Console.ReadLine();
        }
        static int HitungLuas(int panjang, int lebar){
            return panjang * lebar;
        }
    }
    
}