internal class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.ad="Enes";
        calisan1.soyad="Vardar";
        calisan1.yas=30;
        calisan1.maas=5000;
        Console.WriteLine("Calisan Bilgileri");
        calisan1.bilgiGoster();
    }
}


class Calisan
{
    public string ad;
    public string soyad;
    public int yas;
    public int maas;


    public void bilgiGoster(){
        Console.WriteLine("Calisan Adi: " + this.ad);
        Console.WriteLine("Calisan Soyadi:  " + this.soyad);
        Console.WriteLine("Calisan Yasi: " + this.yas);
        Console.WriteLine("Calisan Maasi: " + this.maas);
    }
}