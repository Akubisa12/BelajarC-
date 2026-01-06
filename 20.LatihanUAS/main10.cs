public class Kata
{
    public static int SquareDigits(int n)
    {
        string result = "";
        // n.ToString() akan mengubah angka menjadi string
        // foreach(char digit in n.ToString()) akan mengambil setiap digit satu per satu
        foreach (char digit in n.ToString())
        {
            // digit - '0' mengonversi karakter digit menjadi nilai integer
            int d = digit - '0';
            // Mengkuadratkan digit dan menggabungkan hasil kuadrat ke string hasil
            result += (d * d).ToString();
        }
        // Mengubah hasil akhir kembali menjadi integer 
        return int.Parse(result);
    }
}
