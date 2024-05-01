internal class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Enes";
        calisan1.Soyad = "Vardar";
        calisan1.Yas = 30;
        calisan1.Maas = 5000;
        Console.WriteLine("Calisan Bilgileri");
        calisan1.bilgiGoster();
        Console.WriteLine("*********************");


        Calisan calisan2 = new Calisan("Dilara", "Sevim", 19, 77000);
        Console.WriteLine("Calisan Bilgileri");
        calisan2.bilgiGoster();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;

    public int Yas ;

    public int Maas;
    public Calisan(string ad, string soyad, int yas, int maas)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.Yas = yas;
        this.Maas = maas;
    }
    public Calisan() { }

    public void bilgiGoster()
    {
        Console.WriteLine($"Ad : {this.Ad} \nSoyad : {this.Soyad}\nYas : {this.Yas} \nMaas : {this.Maas}");
    }
    
}   
