using System;

namespace Jessen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nPerulangan Bersarang");
        Console.WriteLine("-----------------------");
        // NOTE : Perulangan bersarang yang dikerjakan sampai habis itu perulangan yang ada didalam dulu
        for(int i=1; i<=3; i++){ // i = 2 j = 3 (SELASAI)(Balik ke perulangan luar)
            Console.Write(i + " "); 
            for(int j = 1; j <= 3; j++) 
            {
                Console.Write("*");
            } // 1 ***2 ***3 ***
        }
    }
}
