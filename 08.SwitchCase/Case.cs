class Program
{
    static void Main(string[] args)
    {
        int hari = 2;
        switch (hari)
        {
            case 1:
                Console.WriteLine("Senin");
                break;
            case 2:
                Console.WriteLine("Selasa");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}