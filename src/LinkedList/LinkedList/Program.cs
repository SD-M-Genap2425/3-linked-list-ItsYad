﻿using LinkedList.Inventori;
using LinkedList.ManajemenKaryawan;
using LinkedList.Perpustakaan;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan

        KoleksiPerpustakaan perpustakaan = new KoleksiPerpustakaan();
        perpustakaan.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new Buku("1984", "George Orwell", 1949));
        perpustakaan.TambahBuku(new Buku("The Catcher in the Rye", "J.D. Salinger", 1951));

        Console.WriteLine("Koleksi Buku di Perpustakaan:");
        Console.WriteLine(perpustakaan.TampilkanKoleksi());


        // Soal ManajemenKaryawan
        DaftarKaryawan daftar = new DaftarKaryawan();
        daftar.TambahKaryawan(new Karyawan("001", "John Doe", "Manager"));
        daftar.TambahKaryawan(new Karyawan("002", "Jane Doe", "HR"));
        daftar.TambahKaryawan(new Karyawan("003", "Bob Smith", "IT"));

        Console.WriteLine("Daftar Karyawan:");
        Console.WriteLine(daftar.TampilkanDaftar());


        // Soal Inventori
        ManajemenInventori inventori = new ManajemenInventori();
        inventori.TambahItem(new Item("Apple", 50));
        inventori.TambahItem(new Item("Orange", 30));
        inventori.TambahItem(new Item("Banana", 20));

        Console.WriteLine("Daftar Inventori:");
        inventori.TampilkanInventori();
    }
}
