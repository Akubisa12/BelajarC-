namespace FunctionExample
{
    class NilaiMahasiswa
    {
        // variabel global
        static int totalNilai = 0;
        static int jumlahMahasiswa = 0;

        static void TambahNilai(int nilai)
        {
            // variabel local
            int nilaiInput = nilai;
            totalNilai += nilaiInput;
            jumlahMahasiswa++;
        }

        static void Main()
        {
            TambahNilai(80);
            TambahNilai(90);
            TambahNilai(100);

            int rataRata = totalNilai / jumlahMahasiswa;
            Console.WriteLine("Rata-rata Nilai: " + rataRata);
        }
    }
}