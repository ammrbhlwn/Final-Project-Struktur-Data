using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class DetailTransaksiPage
{
    private Stack<int> transaksi;

    public DetailTransaksiPage(Stack<int> transaksi)
    {
        this.transaksi = transaksi;
    }


    public void TampilkanMenuTransaksi()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Seluruh Transaksi ===");
            Console.WriteLine("Tanggal\t\tJumlah\t\tJenis");
            Console.WriteLine("---------------------------------------");

            var seluruhTransaksi = transaksi.GetAllItems();
            foreach (var transaksi in seluruhTransaksi)
            {
                string jenis = transaksi.Data > 0 ? "Pemasukan" : "Pengeluaran";
                int jumlah = Math.Abs(transaksi.Data);
                Console.WriteLine($"{transaksi.Tanggal.ToString("dd/MM/yyyy")}\t{jumlah}\t\t{jenis}");
            }

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Tekan tombol apa saja untuk melanjutkan...");
            Console.ReadKey();
        }
    }
}
