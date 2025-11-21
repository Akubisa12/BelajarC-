using System;

class Program
{
    static void Main(string[] args)
    {
        // A. Operator Aritmatika
        int a = 10;
        int b = 3;

        Console.WriteLine($"Pejumlahan : {a + b}");
        Console.WriteLine($"Pengurangan : {a-b}");
        Console.WriteLine($"Perkalian : {a*b}");
        Console.WriteLine($"Pembagian : {a/b}");
        Console.WriteLine($"Modulus (sisa) : {a%b}");

        int angkaKu = 34;
        Console.WriteLine(angkaKu + 8); // 34 + 3 = 37
        // untuk hasil desimal
        double c = 10.0;
        Console.WriteLine($"Pembagian Double: {c / b}");

        // B. Operator Penugasan 
        int skor = 100;
        Console.WriteLine($"Skor sekarang: {skor}");

        // Menggunakan operator majemuk 
        skor += 20;
        Console.WriteLine($"Dapat bonus 20: {skor}");

        skor -= 50;
        Console.WriteLine($"Kena penalti 50: {skor}");

        // C. Operator Perbandingan
        int umur = 20;
        int batasUmur = 18;
        bool bolehMasuk = umur >= batasUmur;
        Console.WriteLine($"Umur Anda: {umur}");
        Console.WriteLine($"Bolehkan Anda masuk? {bolehMasuk}");

        string password = "123";
        string inputUser = "123";
        bool passwordBenar = (password == inputUser);
        Console.WriteLine($"Password Benar? {passwordBenar}");

        // D. Operator logika 
        // 1. Operator and(&&)
        int umur2 = 25;
        bool lulusUjian = true;
        bool bolehDapatSIM = (umur2 > 17) && (lulusUjian == true);
        Console.WriteLine($"Boleh dapat SIM? {bolehDapatSIM}");

        bool lulusUjian2 = false;
        bool bolehDapatSIM2 = (umur2 > 17) && (lulusUjian2 == true);
        Console.WriteLine($"Boleh dapat SIM 2? {bolehDapatSIM2}");

        // 2. Operator Or (||)
        bool punyaKTP = false;
        bool punyaPelajar = true;
        bool bolehMasukArea = punyaKTP || punyaPelajar;
        Console.WriteLine($"Boleh masuk area? {bolehMasukArea}");

        // 3. Operator NOT(!)
        bool sedangHujan = true;
        bool bolehMainDiluar = !sedangHujan;
        Console.WriteLine($"Boleh main diluar {bolehMainDiluar}");

        // 4. Operator unary 
        // Contoh 1 : Hanya increment 
        int apel = 5;
        apel++;
        Console.WriteLine($"Jumlah apel: {apel}");

        apel--;
        Console.WriteLine($"Jumlah apel: {apel}");

        // Contoh 2 : perbedaan Pre vs Post 
        // post-increment : ambil nilai dulu, baru tambah
        // Langkah 1 : B = A (B = 10)
        // Langkah 2 : A = A + 1 (A = 11)
        int A = 10;
        int B = A++;
        Console.WriteLine($"A = {A}, B = {B}");

        int C = 10;
        // Pre-increment : tambah dulu, baru ambil nilai
        // Langkah 1 : C = C + 1 (C = 11)
        // Langkah 2 : D = C (D = 11)
        int D = ++C;
        Console.WriteLine($"C = {C}, D = {D}");

        // 06. Operator Ternary 
        // Sintaks : kondisi ? nilai_jika_true : nilai_jika_false
        int suhu = 30;
        // Cara biasa dengan if-else 
        string keterangan;
        if (suhu > 28)
        {
            keterangan = "Panas";
        }
        else
        {
            keterangan = "Sejuk";
        }
        Console.WriteLine($"Cara if-else: {keterangan}");

        // Cara cepat dengan Operator ternary
        string keteranganTernary = (suhu > 28) ? "Panas" : "Sejuk";
        Console.WriteLine($"Cara Ternary: {keteranganTernary}");

        // 07. Urutan Prioritas Operator

        // tanpa tanda kurung
        int hasil1 = 5 + 3 * 2;
        Console.WriteLine($"Hasil 1: {hasil1}");

        // Menggunakan tanda kurung
        int hasil2 = (5 * 3) * 2;
        Console.WriteLine($"Hasil 2: {hasil2}");
    }
}