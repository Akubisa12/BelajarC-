using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan jumlah perjalanan: ");
        int jumlah = int.Parse(Console.ReadLine());

        // Deklarasi array
        string[] kode = new string[jumlah];
        double[] jarak = new double[jumlah];
        double[] pendapatan = new double[jumlah];
        double[] totalBiaya = new double[jumlah];
        double[] keuntungan = new double[jumlah];
        double[] keuntunganPerKm = new double[jumlah];

        // Input dan proses data
        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine("\nPerjalanan ke-" + (i + 1));
            Console.Write("Kode Perjalanan : ");
            kode[i] = Console.ReadLine();

            Console.Write("Jarak Tempuh (km): ");
            jarak[i] = double.Parse(Console.ReadLine());

            // Validasi jarak
            if (jarak[i] <= 0)
            {
                Console.WriteLine("Jarak harus lebih dari 0 km");
                i--;
                continue;
            }

            pendapatan[i] = HitungPendapatan(jarak[i]);
            totalBiaya[i] = HitungTotalBiaya(jarak[i]);
            keuntungan[i] = pendapatan[i] - totalBiaya[i];
            keuntunganPerKm[i] = keuntungan[i] / jarak[i];
        }

        Console.WriteLine("\n===== DATA KEUNTUNGAN PERJALANAN =====");

        double totalKeuntungan = 0;
        int indexTertinggi = 0;

        // Output dan analisis
        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Kode Perjalanan   : " + kode[i]);
            Console.WriteLine("Jarak             : " + jarak[i] + " km");
            Console.WriteLine("Pendapatan        : Rp" + pendapatan[i]);
            Console.WriteLine("Total Biaya       : Rp" + totalBiaya[i]);
            Console.WriteLine("Keuntungan        : Rp" + keuntungan[i]);
            Console.WriteLine("Keuntungan per Km : Rp" + keuntunganPerKm[i]);

            totalKeuntungan += keuntungan[i];

            if (keuntunganPerKm[i] > keuntunganPerKm[indexTertinggi])
            {
                indexTertinggi = i;
            }
        }
    }
}