// Perulangan do while sangat mirip dengan while. Perbedaan terbesarnya adalah : do while akan menjalankan blok kode terlebih dauhulu(minimal satu kali), baru kemudian mengecek kondisi di akhir

// hal ini menjamin bahwa blok kode di dalam do pasti berjalan setidaknya satu kali, bahkan jika kondisi dari awal sudah false 

// sintaks dasar 
/*
// blok kode yang akan diulang
// Ini pasti berjalan minimal satu kali
*/ // while (kondisi); 

// Contoh program 
// case : menampilkan menu game kepada pengguna. Kita pasti ingin menampilkan menu game setidaknya sekali baru kemudian kita bertanya apakah pengguna ingin keluar ?

string pilihan = "";
do {
    // 1. Menampilkan menu (PASTI dijalankan)
    Console.WriteLine("\n---MENU---");
    Console.WriteLine("1. Mulai Permainan");
    Console.WriteLine("2. Lihat Skor Tertinggi");
    Console.WriteLine("3. Keluar");
    Console.Write("Pilihan Anda (1-3): ");

    pilihan = Console.ReadLine();

    // Lakukan sesuatu berdasarkan pilihan...
    if (pilihan == "1") Console.WriteLine("Permainan dimulai!");
    if (pilihan == "2") Console.WriteLine("Skor tertinggi: 999");

} while (pilihan != "3");
Console.WriteLine("Terima kasih telah bermain");

// Analogi : Mencicipi masakan 
// bayangkan kalian sedang memasak sup dan ingin memastikan rasanya pas sebelum disajikan. Kalian akan mencicipinya(do), lalu memutuskan(while) apakah perlu menambah garam.
// Blok kode(do) : kamu mengambil sendok dan mencicipi sup. Ini adalah aksi yang harus kalian lakukan setidaknya satu kali
// Kondisi(while) : setelah mencicipi, kalian bertanya pada diri sendiri, "Apakah rasanya masih hambar?" (while (rasanyaHambar))

// Jika ya(hambar), kalian akan mengulang prosesnya(tambah garam, lalu cicipi lagi). Jika tidak(rasanya pas), loop berhenti. Perhatikan, kalian tidak bisa memutuskan rasanya hambar sebelum kalian mencicipinya. Kalian harus melakukan(do) aksinya dulu, baru mengecek(while) kodnsinya