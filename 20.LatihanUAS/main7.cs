public class Kata
{
    public static bool CheckForFactor(int num, int factor)
    {
        // Menghasilkan sisa pembagian num oleh factor 
        // == 0 jika sisa pembagian 0, berarti factor membagi num secara habis
        return num % factor == 0;
    }
}
