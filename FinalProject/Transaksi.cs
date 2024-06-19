using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class Transaksi
{
    public int saldo;
    public int tanggal;
    public int bulan;
    public int tahun;
    public string jenis;


    public Transaksi(int saldo, int tanggal, int bulan, int tahun, string jenis)
    {
        this.saldo = saldo;
        this.tanggal = tanggal;
        this.bulan = bulan;
        this.tahun = tahun;
        this.jenis = jenis;
    }
}