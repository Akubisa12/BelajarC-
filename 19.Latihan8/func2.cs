using System;

class Program
{
    public static void Main(int[] arr)
    {
        // mulai nilai total = 0 
        int nilaiTotal = 0;
        // baca setiap elemen array 1 per 1
        foreach (int nilaiFix in arr)
        {
            // periksa 
            if (nilaiFix > 0)
            {
               // Tambah ke total 
                nilaiFix += nilaiTotal;
            }
        }
        return nilaiTotal;
    }
}
