public class Kart
{
    public Tip Tip{get;set;}
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public Kisi AtananKisi { get; set; }
    public KartBoyutu Buyukluk {get;set;}
    public Kart(string baslik, string icerik , Kisi atananKisi, KartBoyutu buyukluk, Tip tip)
    {
        this.Tip= tip;
        this.Baslik = baslik;
        this.Icerik = icerik;
        this.AtananKisi = atananKisi;
        this.Buyukluk = buyukluk;
    }

}