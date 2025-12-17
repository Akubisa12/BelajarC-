using System;

class Program
{
    static void Main()
    {
        // For Loop 
        // for (int i = 0; i <= 8; i++)
        // {
        //     Console.WriteLine("Angka: " + i);
        // }

        //Penjumlahan dengan for loop
        // int total = 0;
        // for (int i = 1; i <= 10; i++)
        // {
        //     total += i;
        // }
        // Console.WriteLine("Total penjumlahan 1-10= " + total);

        //For Each
        // sring[] nama = {"Azra", "Ryan", "Sheren", "Naswa"};
        // foreach (string n in nama)
        // {
        //     Console.WriteLine("Nama yang dipilih: " + n);
        // }

        // int[] nilai = {60,75,80, 55, 90, 70};
        // int count = 0;
        // foreach (int n in nilai){
        //     if (n > 70) count++;
        // }
        // Console.WriteLine("Jumlah dari nilai > 70 adalah: " + count);

        // while loop
        // int i = 0;
        // while (i < 10){
        //     Console.WriteLine("While Loop Angka: " + i);
        //     i++;
        // }

        // int angka = -1;
        // while(angka != 0){
        //     Console.Write("Masukkan angka (0 untuk berhenti): ");
        //     angka = int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("Program selesai");

        // int hitung = 10;
        // while (hitung >0){
        //     Console.WriteLine("Hitung mundur: " + hitung);
        //     hitung--;
        // }

        // Do While loop
        // string password;
        // do
        // {
        //     Console.Write("Masukkan password anda: ");
        //     password = Console.ReadLine();
        // }
        // while (password != "admin123");
        // Console.WriteLine("Password benar!");

        // Do While Loop - Menu Sederhana
        // int pilihan;

        // do
        // {
        //     Console.WriteLine("\n=== MENU ===");
        //     Console.WriteLine("1. Tampilakan Nama");
        //     Console.WriteLine("2. Tampilkan Waktu");
        //     Console.WriteLine("3. Keluar Program");
        //     Console.Write("Pilih: ");

        //     pilihan = int.Parse(Console.ReadLine()!);

        //     switch (pilihan)
        //     {
        //         case 1:
        //             Console.WriteLine("Namamu Azra");
        //             break;

        //         case 2:
        //             Console.WriteLine("Waktu sekarang: " + DateTime.Now);
        //             break;

        //         case 3:
        //             Console.WriteLine("Keluar...");
        //             break;

        //         default:
        //             Console.WriteLine("Pilihan tidak valid.");
        //             break;
        //     }

        // }
        // while (pilihan != 3);

        //Fibonacci dengan for loop
        // Fibonacci dengan perulangan while
        // Console.Write("Masukkan jumlah bilangan Fibonacci: ");
        // int n = int.Parse(Console.ReadLine()!);

        // int i = 2;
        // int a = 0, b = 1;

        // Console.Write(a + " " + b + " ");

        // while (i < n)
        // {
        //     int c = a + b;
        //     Console.Write(c + " ");

        //     a = b;
        //     b = c;

        //     i++;
        // }

        // Nested for Loop - Persegi Bintang 3x3
        // for (int i = 1; i <= 3; i++)
        // {
        //     for (int j = 1; j <= 3; j++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        // }

        // Nested for Loop - Segitiga Angka 1
        // for (int i = 1; i <= 5; i++)
        // {
        //     for (int j = 1; j <= i; j++)
        //     {
        //         Console.Write(j + " ");
        //     }
        //     Console.WriteLine(); // Pindah baris
        // }
    }
}