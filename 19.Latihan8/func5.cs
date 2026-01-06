using System;
using System.Linq;

class Program
{
    /*
    SOAL :
        Buatlah method/fungsi yang :
        1. Menerima sebuah array bilangan bulat 
        2. Menghitung jumlah semua bilangan positif di dalam array tsbt
        3. Bilangan positif adalah bilangan yang lebih besar dari 0
        4. Jika Array kosong atau Tidak ada bilangan poisitif sama sekali maka hasilnya 0

        Sample tests :
        [TestCase(new int[]{1, 2, 3, 4, 5}, ExpectedResult=15)]
        [TestCase(new int[]{1, -2, 3, 4, 5}, ExpectedResult=13)]
        [TestCase(new int[]{-1, 2, 3, 4, -5}, ExpectedResult=9)]
        [TestCase(new int[]{}, ExpectedResult=0)]
        [TestCase(new int[]{-1, -2, -3, -4, -5}, ExpectedResult=0)]
    */
    public static void Main(int[] arr)
    {
        arr.Where(x => x > 0).Sum();
    }
}