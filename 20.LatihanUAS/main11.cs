public class Clock
{
    public static int Past(int h, int m, int s)
    {
        // 1 jam = 3600000 ms, 1 menit = 60000 ms, 1 detik = 1000 ms
        // Rumus : 
        // Totas ms = (jam x 3.600.000) + (menit x 60.000) + (detik x 1.000)
        return (h * 3600000) + (m * 60000) + (s * 1000);
    }
}
