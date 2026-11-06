using System;
using System.Collections.Specialized;

class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen(string idAgen, string namaAgen, int stokAgen)
    {
        this.idAgen = idAgen;
        this. namaAgen = namaAgen;
        this.stokAgen = stokAgen;

    }
    public virtual void tampilInfo()
    {
        Console.WriteLine("id Agen :" + idAgen + "/n");
        Console.WriteLine("Nama Agen :" + namaAgen + "/n");
        Console.WriteLine("Stok Agen :" + stokAgen + "/n");
    }
}

abstract class ProdukGalon
{
    private string idProduk {  get; set; }
    private string namaProduk { get; set; }
    private int stokGudang { get; set => stokGudang >= 0; }

    public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        this.idProduk = idProduk;
        this.namaProduk = namaProduk;
        this.stokGudang = stokGudang;
    }

    public int KurangiStok(int jumlah) {  return stokGudang -= jumlah ; }
    public abstract int HitungBiaya(int jumlah);

}

class GalonAkua : ProdukGalon
{
    public int harga;
    public GalonAkua(string idProduk, string namaProduk, int stokGudang, int harga) : base(idProduk,namaProduk,stokGudang)
    {
        this.harga = harga;
    }

    public override int HitungBiaya(int jumlah) { return harga = jumlah * 20000 ;}

}

class GalonBerkeran : ProdukGalon
{
    public int harga;
    public GalonBerkeran(string idProduk, string namaProduk, int stokGudang, int harga) : base(idProduk, namaProduk, stokGudang)
    {
        this.harga = harga;
    }

    public override int HitungBiaya(int jumlah) { return harga = jumlah * 12000 ;}
}

class distribusiGalon
{
    interface DapatDidistribusikan
    {
        public void Kirimpaket(Agen agen, ProdukGalon produkgalon, int jumlah)
        {
            if (jumlah > 0 && produkgalon.stokGudang > produkgalon)
            {
                produkgalon.KurangiStok(jumlah);

            }
            else
            {
                Console.WriteLine("tidak valid");
            }
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Agen Agen1 = new Agen("A1", "budi", 20);
        Agen Agen2 = new Agen("A2", "siti", 20);

        Agen1.tampilInfo();
        Agen2.tampilInfo();


        ProdukGalon.Hitungbiaya(Agen1.stokAgen);
        ProdukGalon.Hitungbiaya(Agen2.stokAgen);

        


        }
    }
