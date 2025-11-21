using System;

namespace HelloWorld
{
  class Jessen
  {
    static void Main()
    {
      //  Sintaks : TipeData NamaVariabel;
      // int umur;
      // string namaDepan;

      // Inisialisasi 
      // Sintaks : NamaVariabel = Nilai;
      // int umur = 30;
      // string namaDepanKu = "Jessen";

      // Console.WriteLine(umur);
      // Console.WriteLine(namaDepanKu);

      // Kode Lengkap 
      // 1. Membuat variabel
      string namaProduk = "Laptop Gaming";
      int stok = 10;
      double harga = 12500000.75;
      bool sedangPromo = true;

      Console.WriteLine("---------------INFORMASI PRODUK--------------------");
      Console.WriteLine("Nama: " + namaProduk);
      Console.WriteLine("Stok tersisa: " + stok);
      Console.WriteLine("Harga: Rp. " + harga);
      Console.WriteLine("Sedang Promo: " + sedangPromo);

      // 2. Mengubah nilai Variabel
      stok = stok - 2;
      Console.WriteLine("\n-----Setelah Transaksi");
      Console.WriteLine("Stok Terbaru: " + stok); 
    }
  }
}
