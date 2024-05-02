public class Kisi
{
    private string ad;
    private string soyad;
    private string numara;

    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public string Numara { get => numara; set => numara = value; }





    public Kisi(string ad, string soyad, string numara)
    {
        this.soyad = soyad;
        this.ad = ad;
        this.numara = numara;
    }
}