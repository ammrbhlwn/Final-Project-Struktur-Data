namespace AplikasiPengelolaKeuangan;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================================");
        Console.WriteLine("Aplikasi Pengelola Keuangan Berbasis CLI");
        Console.WriteLine("1. Daftar");
        Console.WriteLine("2. Masuk");
        Console.WriteLine("3. Keluar");
        Console.WriteLine("Silahkan Masukkan Pilihan [1/2/3]");
        Console.WriteLine("========================================================");
        string pilihan = Console.ReadLine();

        if (pilihan == "1")
        {
            DashboardAwal.Daftar();
        }
        else if (pilihan == "2")
        {
            DashboardAwal.Masuk();
        }
        else if (pilihan == "3")
        {
            Console.WriteLine("\nSampai Bertemu Kembali!!\n");
        }
        else
        {
            Console.WriteLine("\nInput Tidak Valid!!\n");
            Main();
        }
    }
}
