// Perulangan while adalah bentuk perulangan yang lebih sederhana. Artinya, ketika kamu ingin mengulang sesuatu selama suatu kondisi masih benar

// Perulangan while ini jumlah perulangannya tidak diketahui secara pasti, tetapi kamu tahu kondisi berhentinya. while akan mengecek kondisi terlbih dahulu di awal. Jika kondisi dari awal sudah false, blok kode didalamnya tidak akan pernah dijalankan sama sekali 

// Sintaks :
// while (kondisi)
/* {// blok kode yang akan diulang}
*/

// Contoh sederhana
// case : kita ingin meminta pengguna memasukkan kata sandi. Kita akan terus meminta selama sandi  yang dimasukkan salah ("12345")

// Algoritma :
// 1. kita bikin dulu tempat buat menampung sandinya 
// 2. ulang

string kataSandi = "";
while (kataSandi != "12345")
{
    Console.Write("Masukkan kata sandi: ");
    kataSandi = Console.ReadLine();

    if (kataSandi != "12345")
    {
        Console.WriteLine("Kata sandi salah. Coba lagi.");
    }
    Console.WriteLine("Selamat! Kamu berhasil login.");
}

// Analogi : Menunggu hujan berhenti 
// Bayangkan kamu ingin pergi ke luar rumah, tetapi saat ini sedang hujan derans. Kamu akan menunggu di dalam rumah selama hujan masih turun
// Kondisi : "Apakah masih hujan?" (while (sedangHujan)).
// Blok kode : kamu menunggu didalam, mungkin sambil minum teh/kopi

// kamu akan mengecek keluar jendela(cek kondisi) sebelum kamu melangkah kelaur. Jika saat kamu mau pergi ternyata sudah tidak hujan (kondisi false dari awal), kamu akan langsung keluar(loop tidak berjalan, kamu tidak menunggu sama sekali). Ini adalah perbedaan kunci dari perulangan yang akan kita bahas berikutnya