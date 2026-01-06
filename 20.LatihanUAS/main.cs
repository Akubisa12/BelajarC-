using System; 
// Mengimpor library System agar dapat menggunakan Console, tipe data dasar, dll.

class Program
{
    static void Main(string[] args)
    {
        // Meminta input jumlah karyawan
        Console.Write("Masukkan jumlah karyawan: ");
        int jumlah = int.Parse(Console.ReadLine());

        // Deklarasi array untuk menyimpan data karyawan
        string[] nik = new string[jumlah];
        string[] nama = new string[jumlah];
        int[] golongan = new int[jumlah];
        int[] jamLembur = new int[jumlah];

        // Array untuk menyimpan hasil perhitungan gaji
        double[] gajiPokok = new double[jumlah];
        double[] lembur = new double[jumlah];
        double[] pajak = new double[jumlah];
        double[] gajiBersih = new double[jumlah];
        string[] kategori = new string[jumlah];

        // Perulangan untuk input dan proses data setiap karyawan
        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine("\nKaryawan ke-" + (i + 1));

            Console.Write("NIK          : ");
            nik[i] = Console.ReadLine();

            Console.Write("Nama         : ");
            nama[i] = Console.ReadLine();

            Console.Write("Golongan (1-3): ");
            golongan[i] = int.Parse(Console.ReadLine());

            Console.Write("Jam Lembur   : ");
            jamLembur[i] = int.Parse(Console.ReadLine());

            // Menghitung gaji pokok berdasarkan golongan
            gajiPokok[i] = HitungGajiPokok(golongan[i]);

            // Menghitung uang lembur
            lembur[i] = jamLembur[i] * 25000;

            // Menghitung pajak 10% dari total gaji kotor
            pajak[i] = 0.1 * (gajiPokok[i] + lembur[i]);

            // Menghitung gaji bersih
            gajiBersih[i] = (gajiPokok[i] + lembur[i]) - pajak[i];

            // Menentukan kategori gaji
            kategori[i] = TentukanKategori(gajiBersih[i]);
        }

        Console.WriteLine("\n===== DATA GAJI KARYAWAN =====");

        double totalPengeluaran = 0;
        int indexTertinggi = 0;

        // Perulangan untuk menampilkan data dan menghitung total & tertinggi
        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine($"{nik[i]} - {nama[i]} | Gaji Bersih: Rp{gajiBersih[i]} | Kategori: {kategori[i]}");

            // Menjumlahkan total gaji bersih
            totalPengeluaran += gajiBersih[i];

            // Mencari indeks karyawan dengan gaji tertinggi
            if (gajiBersih[i] > gajiBersih[indexTertinggi])
            {
                indexTertinggi = i;
            }
        }

        // Menampilkan total pengeluaran gaji
        Console.WriteLine("\nTotal Pengeluaran Gaji: Rp" + totalPengeluaran);

        // Menampilkan karyawan dengan gaji tertinggi
        Console.WriteLine("Gaji Bersih Tertinggi:");
        Console.WriteLine($"{nama[indexTertinggi]} ({nik[indexTertinggi]}) - Rp{gajiBersih[indexTertinggi]}");

        Console.ReadKey(); // Menahan layar agar tidak langsung tertutup
    }

    // Method untuk menentukan gaji pokok berdasarkan golongan
    static double HitungGajiPokok(int golongan)
    {
        if (golongan == 1)
            return 3000000;
        else if (golongan == 2)
            return 4000000;
        else
            return 5000000;
    }

    // Method untuk menentukan kategori gaji
    static string TentukanKategori(double gaji)
    {
        if (gaji >= 5000000)
            return "Tinggi";
        else if (gaji >= 3500000)
            return "Menengah";
        else
            return "Rendah";
    }
}
