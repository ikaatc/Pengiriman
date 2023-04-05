using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Pengiriman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Koneksi ke Database\n");
                    Console.WriteLine("Masukkan Server : ");
                    string server = Console.ReadLine();
                    Console.WriteLine("Masukkan User ID : ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Masukkan Password : ");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Masukkan database tujuan : ");
                    string db = Console.ReadLine();
                    Console.Write("\nKetik K untuk Terhubung ke Database : ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                MySqlConnection conn;
                                string connectionString;
                                connectionString = @"SERVER= " + server + ";DATABASE= " +
                                    db + ";UserID= " + user + ";PASSWORD= " + pass + ";Port=3306";

                                conn = new MySqlConnection(connectionString);
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Melihat Seluruh Data");
                                        Console.WriteLine("2. Tambah Data");
                                        Console.WriteLine("3. Hapus Data");
                                        Console.WriteLine("4. Keluar");
                                        Console.Write("\nENter your choice (1-4): ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Pengiriman Barang\n");
                                                    Console.WriteLine();
                                                    pr.baca(conn);
                                                }
                                                break;
                                        }
                                    }
                                    catch { }
                                }
                            }
                    }
                }
                catch { }
            }
        }
        public void baca(MySqlConnection con)
        {

        }
    }
}
