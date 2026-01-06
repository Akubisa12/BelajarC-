public class Kata
{
    public static int SquareSum(int[] n)
    {
        // variabel untuk menyimpan total hasil penjumlahan
        int sum = 0;
        // Loop untuk mengakses setiap elemen array
        for (int i = 0; i < n.Length; i++)
        {
            // Menambahkan hasil kuadrat ke total 
            sum += n[i] * n[i];
        }
        // Mengembalikan hasil akhir
        return sum;
    }
}
