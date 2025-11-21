class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 11;
        int c = 24;

        if (a <= 10)
        {
            Console.WriteLine($"Ya nilai  {a} kurang dari sama dengan 10");
        }
        else if (b == 11)
        {
            Console.WriteLine($"Ya nilai {b} sama dengan 11");
        }
        else if (c == 30)
        {
            Console.WriteLine($"ya nilai {c} sama dengan 30");
        }
        else
        {
            Console.WriteLine("Angka tidak ditemukan!");
        }

        // Ternary Operator 
        // bentuk singkat dari If selse statement. 
        // Ternary operator digunakan untuk menggambarkan multi line If else statement menjadi single line If else statement
        // Sintaks 
        // variabbel = (kondisi) ? ekspresiTrue : ekspresiFalse;
        int angka = 90;
        string angkaku = (angka > 10) ? "Ya angka lebih dari 10" : "Ya angka kurang dari 10";
    }
}