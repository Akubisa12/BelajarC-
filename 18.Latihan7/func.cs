class ReservasiEventLokal
{
    static int PesanTiket(string jenisTiket, int jumlah)
    {
        int harga = 0;

        if (jenisTiket == "VIP")
        {
            harga = 100000;
        }
        else if (jenisTiket == "Reguler")
        {
            harga = 50000;
        }

        return harga * jumlah;
    }

    static void Main()
    {
        int totalPembayaran = 0;

        totalPembayaran += PesanTiket("VIP", 2);
        totalPembayaran += PesanTiket("Reguler", 3);

        Console.WriteLine("Total Pembayaran  : " + totalPembayaran);
    }
}