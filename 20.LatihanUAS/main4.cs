public class Kata
{
    public static int[] Maps(int[] x)
    {
        //Membuat array baru dengan panjang yang sama seperti array input
        int[] result = new int[x.Length];
        // Mengakses setiap elemen array input.
        for (int i = 0; i < x.Length; i++)
        {
            //Mengalikan setiap nilai dengan 2 dan menyimpannya ke array hasil
            result[i] = x[i] * 2;
        }
        //Mengembalikan array baru berisi nilai yang sudah digandakan
        return result;
    }
}
