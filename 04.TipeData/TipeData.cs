using System;

class KonversiImplisit
{
    static void Main()
    {
        // 2 cara mengkonversi tipe data
        // A. IMPLISIT
        // 1. Dari int ke double 
        // int adalah angka bulat (32 bit)
        int angkaBulat = 123;
        // double adalah angka desimal (64 bit)
        // kita bisa memasukkan int ke double tanpa masalah 
        double angkaDesimal = angkaBulat;
        Console.WriteLine("---Konversi Implisit (int ke double)---");
        Console.WriteLine("Nilai int: " + angkaBulat);
        Console.WriteLine("Nilai double setelah dikonversi: " + angkaDesimal);

        // 2. Dari int ke long 
        // int (32 bit) lebih kecil dari long(64 bit)
        int tagihan = 50000;
        int tagihanBesar = tagihan;
        Console.WriteLine("\n---Konversi Implisit (int ke long)---");
        Console.WriteLine("Nilai int: " + tagihan);
        Console.WriteLine("Nilai Long setelah dikonversi: " + tagihanBesar);

        // 2 cara mengkonversi tipe data
        // B. EKSPLISIT
        // Digunakan ketika kamu pengen mengubah dari tipe data yang lebih besar ke tipe data yang lebih kecil
        // 1. Dari int ke double 
        // int adalah angka bulat (32 bit)
        double nilaiUjian = 85.75;
        // Paksa konversi double ke int
        // C# akan memotong (truncate) bagian desimalnya
        // Ini TIDAK membulatkan, tapi MENGHILANGKAN desimalnya
        int nilaiBulat = (int) nilaiUjian;
        Console.WriteLine("---Konversi Eksplisit (dobule ke int)---");
        Console.WriteLine("Nilai double asli: " + nilaiUjian);
        Console.WriteLine("Nilai int setelah casting: " + nilaiBulat);

        // 2. Dari long ke int (Resiko overflow)
        long angkaSangatBesar = 3000000000L;
        // kita paksa masukkan ke int 
        // padahal, int maksimal hanya sekitar 2.1 miliar 
        // Ini akan menyebabkan "Overflow" dan nilainya menjadi aneh
        int angkaKecil = (int)angkaSangatBesar;
        Console.WriteLine("Nilai long asli: " + angkaSangatBesar);
        Console.WriteLine("Nilai int setelah casting: " + angkaKecil); // hasilnya akan aneh/negatif

        // 3. Konversi menggunakan method bawaan c#
        // a. Method Convert.To...()
        // Contoh:
        Console.WriteLine("---Method Convert.To...()---");
        string teksAngka = "456";
        int hasilAngka = Convert.ToInt32(teksAngka); // berhasil
        Console.WriteLine(hasilAngka + 10); // akan mencetak 466

        // b. Method TipeData.Parse()
        Console.WriteLine("---Method TipeData.Parse()---");
        string teksAngka2 = "789";
        int hasilAngka2 = int.Parse(teksAngka2);
        Console.WriteLine(hasilAngka2 + 10); // akan menctak 799
    }
}