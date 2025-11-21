using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Contoh If ... Else ===");
        int angka = 10;
        if (angka > 5)
        {
            Console.WriteLine("Angka lebih besar dari 5");
        }
        else
        {
            Console.WriteLine("Angka kurang atau sama dengan 5");
        }

        Console.WriteLine("\n=== Contoh If ... Else If ... Else ===");
        int nilai = 75;
        if (nilai >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (nilai >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade D");
        }

        Console.WriteLine("\n=== Contoh Ternary Operator ===");
        int umur = 18;
        string status = (umur >= 18) ? "Dewasa" : "Anak-anak";
        Console.WriteLine("Status: " + status);

        Console.WriteLine("\n=== Contoh Switch Case Statement ===");
        int hari = 3;
        switch (hari)
        {
            case 1:
                Console.WriteLine("Senin");
                break;
            case 2:
                Console.WriteLine("Selasa");
                break;
            case 3:
                Console.WriteLine("Rabu");
                break;
            default:
                Console.WriteLine("Hari tidak dikenal");
                break;
        }

        Console.WriteLine("\n=== Contoh Break dalam Loop ===");
        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
                continue;

            Console.WriteLine("i = " + i);
        }

        Console.WriteLine("\n=== Contoh Default Keyword ===");
        string warna = "merah";
        switch (warna)
        {
            case "biru":
                Console.WriteLine("Warna biru");
                break;
            case "kuning":
                Console.WriteLine("Warna kuning");
                break;
            default:
                Console.WriteLine("Warna tidak dikenal");
                break;
        }

        Console.WriteLine("\n=== Perbandingan If-Else vs Switch Case ===");

        // Menggunakan if else (Range)
        int skor = 85;
        if (skor >= 90)
            Console.WriteLine("Lulus dengan Nilai A");
        else if (skor >= 70)
            Console.WriteLine("Lulus dengan Nilai B");
        else
            Console.WriteLine("Tidak lulus");

        // Menggunakan switch (Exact match)
        int menu = 1;
        switch (menu)
        {
            case 1:
                Console.WriteLine("Menu 1 dijalankan");
                break;
            case 2:
                Console.WriteLine("Menu 2 dijalankan");
                break;
            default:
                Console.WriteLine("Menu tidak tersedia");
                break;
        }

        // Contoh If Bersarang/Nested If
        Console.WriteLine("\n=== Contoh If Bersarang/Nested If ===");
        int contoh_angka = 8;
        if (contoh_angka > 0)// If utama
        {
            Console.WriteLine("Angka positif");
            if (contoh_angka % 2 == 0)   // If di dalam if
            {
                Console.WriteLine("Angka genap");
            } else {
                Console.WriteLine("Angka ganjil");
            }
        } else {
            Console.WriteLine("Angka negatif atau nol");
        }
    }
}