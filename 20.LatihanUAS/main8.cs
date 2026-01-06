public class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        // jika bonus == true, gaji dikalikan 10 
        if (bonus)
        {
            salary *= 10;
        }
        // Gaji dikonversi menjadi string dengan prefix $ serta nilai dikembalikan sesuai format yang diminta
        return "$" + salary;
    }
}
