internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Enes";
        ogrenci.Soyisim = "Vardar";
        ogrenci.OgrenciNo = 12345;
        ogrenci.Sinif = 1;

        ogrenci.sinifDusur();
        ogrenci.ogrenciBilgileriGetir();
        ogrenci.sinifAtlat();
        ogrenci.ogrenciBilgileriGetir();
        ogrenci.sinifDusur();

        ogrenci.ogrenciBilgileriGetir();
    }
}


class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return this.isim; }
        set { this.isim = value; }
    }
    public string Soyisim
    {
        get { return this.soyisim; }
        set { this.soyisim = value; }
    }
    public int OgrenciNo
    {
        get { return this.ogrenciNo; }
        set { this.ogrenciNo = value; }
    }
    public int Sinif
    {
        get { return this.sinif; }
        set
        {
            if (value <= 1)
            {
                Console.WriteLine("Sinif 1den  buyuk olmalidir.");
                this.sinif = 1;
            }
            else
            {
                this.sinif = value;
            }
        }
    }


    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci() { }


    public void ogrenciBilgileriGetir()
    {
        Console.WriteLine("*******Ogrenci Bilgileri********");
        Console.WriteLine("Isim : " + Isim);
        Console.WriteLine("Soyismi : " + Soyisim);
        Console.WriteLine("Ogrencino : " + OgrenciNo);
        Console.WriteLine("Sinifi : " + Sinif);
    }

    public void sinifAtlat()
    {
        this.Sinif = this.Sinif + 1;
        Console.WriteLine("Sinif atliyoruz!");
    }
    public void sinifDusur()
    {
        this.Sinif = this.Sinif - 1;
        Console.WriteLine("Sinif atliyoruz!");
    }
}