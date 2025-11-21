using System;

class Program
{
    static void Main()
    {
        // DemoVariabel();
        // DemoAssignment();
        // DemoPerhitungan(); 
        // DemoUserInput();
        // DemoCastingAuto();
        // DemoCastingManual();
    }
    
    static void DemoVariabel()
    {
        // Console.WriteLine("=== DEMO VARIABLE ===");
        // INI YANG NAMANYA COMMENT
        // Deklarasi dan inisialisasi variabel bersama tipe datanya
        int angka = 10; // integer
        string teks = "Hello, World!"; // string
        double Var_desimal = 3.14; // double
        bool varLogika = true; // boolean
        bool varLogika2 = false; // boolean
        float _desimalFloat = 11.3f; // float
        char varChar = 'A'; // char

        // Menampilkan nilai variabel ke konsol
        Console.WriteLine(angka);
        Console.WriteLine("Nilai angka: " + angka);
        Console.WriteLine("Nilai teks: " + teks);
        Console.WriteLine("Nilai desimal dengan double: " + Var_desimal);
        Console.WriteLine("Nilai boolean true: " + varLogika);
        Console.WriteLine("Nilai boolean false: " + varLogika2);
        Console.WriteLine("Nilai desimal dengan float: " + _desimalFloat);
        Console.WriteLine("Nilai char/character: " + varChar);

        Console.WriteLine(); // Spasi
    }
    
    static void DemoCastingAuto()
    {
        // IMPLICIT CASTING - Otomatis (kecil → besar)
        Console.WriteLine("=== IMPLICIT CASTING ===");

        // 1. char -> int
        char charValue = 'A';
        int intFromChar = charValue;
        Console.WriteLine($"char 'A' → int: {intFromChar}"); // Output: 65 (ASCII)

        // 2. int -> float
        int intValue2 = 50;
        float floatFromInt = intValue2;
        Console.WriteLine("int" + intValue2 + "→ float:" + floatFromInt);

        // 3. int -> double
        int intValue3 = 200;
        double doubleFromInt = intValue3;
        Console.WriteLine($"int {intValue3} → double: {doubleFromInt}");

        // 4. float -> double
        float floatValue = 3.14f;
        double doubleFromFloat = floatValue;
        Console.WriteLine($"float {floatValue} → double: {doubleFromFloat}");

        Console.WriteLine(); // Spasi
    }

    static void DemoCastingManual()
    {
        // EXPLICIT CASTING - Manual (besar → kecil)
        Console.WriteLine("=== EXPLICIT CASTING ===");

        // 1. double -> int
        double doubleValue = 9.78;
        int intFromDouble = (int)doubleValue;
        Console.WriteLine($"double {doubleValue} → int: {intFromDouble}"); // Output: 9 (data hilang!)

        // 2. double -> float
        double doubleValue2 = 10.99;
        float floatFromDouble = (float)doubleValue2;
        Console.WriteLine($"double {doubleValue2} → float: {floatFromDouble}");

        // 3. int -> char
        int intValue4 = 66;
        char charFromInt = (char)intValue4;
        Console.WriteLine($"int {intValue4} → char: '{charFromInt}'"); // Output: 'B' (ASCII)

        // 4. float -> int
        float floatValue2 = 15.75f;
        int intFromFloat = (int)floatValue2;
        Console.WriteLine($"float {floatValue2} → int: {intFromFloat}"); // Output: 15

        Console.WriteLine(); // Spasi
    }

    static void DemoUserInput()
    {
        Console.WriteLine("=== DEMO USER INPUT ===");
        // Ini yang namanya user input
        // Meminta input dari pengguna
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan umur Anda: ");
        int umur = Convert.ToInt32(Console.ReadLine()); // Mengonversi input string ke integer

        Console.Write("Masukkan tinggi badan Anda (dalam meter): ");
        double tinggi = Convert.ToDouble(Console.ReadLine()); // Mengonversi input string ke double
    
        // Menampilkan input yang diberikan pengguna
        Console.WriteLine("Nama Anda: " + nama);
        Console.WriteLine("Umur Anda: " + umur + " tahun");
        Console.WriteLine("Tinggi badan Anda: " + tinggi + " meter");

        Console.WriteLine(); // Spasi
    }

    static void DemoAssignment()
    {
        int a = 9, b = 3;
        Console.WriteLine("=== Assignment Operator ===");
        Console.WriteLine($"a = {a}");
        b += 2;
        Console.WriteLine($"b += 2 : {b}");
        b -= 1;
        Console.WriteLine($"b -= 1 : {b}");
        b *= 3;
        Console.WriteLine($"b *= 3 : {b}");
        b /= 2;
        Console.WriteLine($"b /= 2 : {b}");
        b %= 2;
        Console.WriteLine($"b %= 2 : {b}");
    }
    
    static void DemoPerhitungan()
    {
        int a = 9, b = 3;
        Console.WriteLine("=== Arithmetic Operator ===");
        Console.WriteLine($"Hasil: {a + b}");
        Console.WriteLine($"Hasil: {a - b}");
        Console.WriteLine($"Hasil: {a * b}");
        Console.WriteLine($"Hasil: {a / b}");
        Console.WriteLine($"Hasil: {a % b}\n");

        Console.WriteLine("=== Comparison Operator ===");
        Console.WriteLine($"a == b : {a == b}");
        Console.WriteLine($"a != b : {a != b}");
        Console.WriteLine($"a > b  : {a > b}");
        Console.WriteLine($"a < b  : {a < b}");
        Console.WriteLine($"a >= b : {a >= b}");
        Console.WriteLine($"a <= b : {a <= b}\n");

        // LOGICAL OPERATORS (&&, ||, !)
        bool x = true;
        bool y = false;
        Console.WriteLine("=== Logical Operator ===");
        Console.WriteLine($"x && y : {x && y}"); // AND
        Console.WriteLine($"x || y : {x || y}"); // OR
        Console.WriteLine($"!x     : {!x}");     // NOT
    }

}