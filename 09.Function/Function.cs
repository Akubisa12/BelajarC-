using System;

class Program
{
    // Apa itu fungsi ?
    // Bayangkan fungsi sebagai resep masakkan. Resep ini memiliki nama(misalnya "Nasi Goreng"), mungkin membutuhkan bahan-bahan(input), melakukan serangkaian langkah(proses), dan akhirnya menyajikan hidangan(output)
    // Didalam c# fungsi digunakan untuk :
    // 1. mencegah penulisan kode berulang-ulang
    // 2. memecah program besar menjadi bagian-bagian kecil yang mudah diatur 
    //  Sebuah fungsi di C# umumnya meiliki struktur seperti berikut ini :
    // [Akses] [TipeKembalian] [NamaFungsi]( [Parameter] )

    // Akses (acces modifier) : menentukan siapa yang bisa melihat fungsi ini.
    // Contoh : public, private

    // Tipe Kembalian(Return Type) : data paa yang dihasilkan fungsi setelah selesai.
    // Contoh : int, string, atau void jika tidak menghasilkan apa-apa
    // NamaFungsi : Nama unik untuk memanggil fugnsi tersebut 
    // Parameter : Data input yang dibutuhkan fungsi 
    static void Main(string[] args) {

        // Memanggil fungsi tanpa kembalian(void)
        SapaPengguna("Budi");
        SapaPengguna("Siti");

        // Memanggil fungsi dengan kembalian
        int hasil = TambahAngka(5, 10);
        Console.WriteLine("Hasil penjumlahan: " + hasil);

        int hasilPerkalian = KaliAngka(10, 5);
        Console.WriteLine("Hasil 10 dikali 5 adalah: " + hasilPerkalian);

        Console.WriteLine("Hasil 3 dikali 3 adalah: " + KaliAngka(3, 3));

        Console.ReadLine();
    }

    // CONTOH 1 : Fungsi void(tidak mengembalikan nilai)
    // Fungsi ini hanya melakukan tugas(mencetak teks) lalu selesai

    static void SapaPengguna(string nama)
    {
        Console.WriteLine("Halo, " + nama + "! Selamat belajar C#");
    }

    // CONTOH 2: Fungsi dengan return value(Mengembalikan nilai)
    // Fungsi ini memproses angka dan membeirkan hasil balik/nilai kembalian
    static int TambahAngka(int angka1, int angka2)
    {
        int total = angka1 + angka2;
        return total;
    }

    // Tantangan :
    // Coba ubah fungsi TambahAngka menjadi fungsi KaliAngka yang mengalikan dua angka, lalu panggil fungsi tersebut di dalam Main

    // Solusi 
    static int KaliAngka(int angka1, int angka2){
        int hasil = angka1 * angka2;
        return hasil;
    }
}