internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class //System.Collections.Generic // T-> object türündedir.
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);
        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kirmizi");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sari");
        renkListesi.Add("Yeşil");
        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);
        //Foreach ve List. ForEach ile elemanlara erişim
        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach (var renk in renkListesi)
            Console.WriteLine(renk);
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));
        //Listeden eleman çikarma sayiListesi.Remove(4); renkListesi.Remove("Yeşil");
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk =>
        Console.WriteLine(renk));
        //Liste içerisinde Arama
        if (sayiListesi.Contains(10))
            Console.WriteLine("10 Liste içerisinde bulundu!");
        //Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sari"));
        //Diziyi List'e çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
        List<string> hayvanListesi = new List<string>(hayvanlar);
        //Listeyi nasil temizleriz?
        hayvanListesi.Clear();
        //List çerisinde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Ayşe";
        kullanici1.Soyisim = "Yilaz";
        kullanici1.Yas = 26;
        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Dilara";
        kullanici2.Soyisim = "Sevim";
        kullanici2.Yas = 26;
        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);
        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar()
        {
            Isim = "Enes",
            Soyisim = "Vardar",
            Yas = 24
        });
        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi:" + kullanici.Isim);
            Console.WriteLine("Kullanici Soyadi :" + kullanici.Soyisim);
            Console.WriteLine("Kullanici Yas:" + kullanici.Yas);
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        
    }
}