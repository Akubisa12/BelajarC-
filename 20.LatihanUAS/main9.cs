using System;

class Program {
    public static string RemoveExclamationMarks(string s) {
        // Mengganti semua tanda seru (!) dengan string kosong
        // Method replace berlaku untuk seluruh string, tidak hanya satu karakter, aman untuk string kosong
        return s.Replace("!", "");
    }
    public static void Main(){
        Console.WriteLine(RemoveExclamationMarks("Hello World!")); // Output: Hello World
    }
}