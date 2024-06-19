using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class DashboardAwal
{
    public static void Daftar()
    {
        Console.WriteLine("\n==== Menu Daftar ====");
        Console.WriteLine("Username tidak lebih dari 5 karakter & username hanya dapat menerima input berupa huruf kecil");
        Console.WriteLine("Masukkan Username : ");
        string Username = Console.ReadLine();
        Console.WriteLine("Masukkan Password : ");
        string Password = Console.ReadLine();

        Akun akun = new Akun(Username, Password);
        bool failed = false;

        // validasi bahwa username tidak boleh lebih dari 5 karakter dan harus huruf kecil
        if (Username.Length < 5)
        {
            for (int i = 0; i < Username.Length; i++)
            {
                if (!Char.IsLower(Username[i]))
                {
                    failed = true;
                    break;
                }
            }
            if (!failed)
            {
                if (ChainingHash.ValidasiDaftar(akun))
                {
                    Console.WriteLine("\nAkun Berhasil Terdaftar!!\n");
                }
                else
                {
                    Console.WriteLine("\nAkun Gagal Terdaftar!!\n");
                }
            }
        }
        else
        {
            Console.WriteLine("Username tidak boleh lebih dari 5 karakter dan berupa huruf kecil");
        }
        Program.Main();
    }


    public static void Masuk()
    {
        Console.WriteLine("Username tidak lebih dari 5 karakter & harus berupa huruf kecil");
        Console.WriteLine("Masukkan Username :");
        string Username = Console.ReadLine();
        Console.WriteLine("Masukkan Password :");
        string Password = Console.ReadLine();

        Akun cekAkun = new Akun(Username, Password);

        if (ChainingHash.ValidasiLogin(cekAkun))
        {
            Console.WriteLine("\nBerhasil Masuk!!\n");
            HomePage hp = new HomePage();
            hp.TampilkanMenu();
        }
        else
        {
            Console.WriteLine("\nAkun tidak ditemukan! Mohon periksa username dan password anda\n");
            Masuk();
        }
    }
}
