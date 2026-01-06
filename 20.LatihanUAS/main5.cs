public class RentalCar
{
    public static int RentalCarCost(int d)
    {
        // Menghitung biaya sewa mobil berdasarkan jumlah hari
        int totalCost = d * 40;
        // Jika menyewa selama 7 hari atau lebih, potongan $50
        // Jika menyewa selama 3 hari atau lebih, potongan $20
        if (d >= 7)
        {
            totalCost -= 50;
        }
        else if (d >= 3)
        {
            totalCost -= 20;
        }
        // Mengembalikan total biaya sewa mobil
        return totalCost;
    }
}
