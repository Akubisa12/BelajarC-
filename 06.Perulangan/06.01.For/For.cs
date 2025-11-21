// For adalah jenis perulangan yang paling terstruktur, artinya ketika kalian menggunkn pasti udah tau berapa kali kalian ingin perulangan itu terjadi

// Memiliki 3 struktur 
// 1. Inisialisasi : Kode yang dijalankan hanya sekali sebelum loop dimulai. Biasanya digunakan untuk mendeklarasikan dan memberi nilai awal pada variabel penghitung(misal int i = 0)

// 2. Kondisi : Sebuah ekspresi boolean.Loop akan terus berjalan selama kondisi ini bernilai true. Kondisi ini diperiksa sebelum setiap iterasi(putaran)

// 3. Iterasi : Kode yang dijalnakan di akhir setiap putara. Biasanya digunakan utnuk menambah (atau mengurangi) variabel penghitung(misal i++)

// Sintaks dasar :
// for (inisialisasi ; kondisi; iterasi){
// blok kode yang akan diulang
// }


// Contoh sederhana 
// Kasus : mencetak angka 1 sampai 5  
// 1. Inisialisasi : kita mulai hitungan dari 1 (int i = 1)
// 2. Kondisi : kita teruskan selama i kurang dari atau sama dengan 5
// 3. Iterasi : setelah setiap putaran, tambahkan 1 ke i (i++)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Hitungan ke: {i}");
}

// Analogi : Latihan push-up
// Analogi : kamu adalah seorang pelatih kebugaran yang menyuruh klien / yang dilatih kamu melakukan tepat 10 kali push-up 
//  Inisialisasi : klien / yang dilatih bersiap di lantai (iin adalah langkah awal, int i = 1)
// Kondisi : "Apakah hitungan push-up saat ini masih dibawah atau sama dengan 10? (i<=10)
// Iterasi : Kamu menghitung "Satu!" 
//           (ini adalah i++)