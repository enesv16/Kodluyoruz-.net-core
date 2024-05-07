public class Kisi
{
    // Alanlar
    public string isim{get;}
    public string soyad{get;}
    public int id{get;}
    public Kisi(string isim, string soyad, int id = 0)
    {
        this.isim = isim;
        this.soyad = soyad;
        this.id = id;
    }
}