public class KartIslemleri
{
    public List<Kisi> kisiler { get; set; }
    public List<Kart> kartlar { get; set; }

    public KartIslemleri()
    {
        kisiler = new List<Kisi>(){
                new Kisi("Enes"," VARDAR",1),
                new Kisi("Dilara"," VARDAR",2),
                new Kisi("Muhammet","SEVIM",3),
                new Kisi("Ufuk","HALI",4),
                new Kisi("Ali","PASPAS",5),
                new Kisi("Emirhan","OVERLOK",6)
        };

        kartlar = new List<Kart>(){
            new Kart("Proje1","Görev Atamalarini Yap",kisiler[0],KartBoyutu.XS,Tip.TODO),
            new Kart("Proje2","Takim  Çekerek Görevleri Bitir",kisiler[1],KartBoyutu.M,Tip.ProgressLine),
            new Kart("Proje3","Yeni Projeye Katilmak ve Onaylandir",kisiler[2],KartBoyutu.L,Tip.Done)
        };
    }

    public void KartEkle()
    {
        Console.WriteLine("\n************* KART EKLE *****************");
        Console.WriteLine("Lütfen Asagidaki Bilgileri Doldurunuz.");
        Console.WriteLine("Başlik Giriniz                                  :");
        Console.WriteLine("İçerik Giriniz                                  :");
        Console.WriteLine("Kişi Seçiniz                                    :");
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");

        string baslik = KullaniciArayuzu.kullaniciGiris("Başlik Giriniz: ");
        string icerik = KullaniciArayuzu.kullaniciGiris("İcerik Giriniz: ");

        foreach (var item in kisiler)
        {
            Console.WriteLine($"{item.isim} ({item.id})");
        }


        int kisiID = int.Parse(KullaniciArayuzu.kullaniciGiris("Kisi id'sini seciniz"));
        Kisi secilenKisi = kisiler.Find(x => x.id == kisiID);
        KartBoyutu boyut = (KartBoyutu)Enum.Parse(typeof(KartBoyutu), KullaniciArayuzu.kullaniciGiris("Buyuklugu Seciniz: "));
        Kart kart = new Kart(baslik, icerik, secilenKisi, boyut, Tip.TODO);
        kartlar.Add(kart);

    }
    public void KartSil()
    {
        if (kartlar.Count == 0)
        {
            Console.WriteLine("Listede Silinecek Bir Kart Yok!");
            return;
        }
        Console.Write("\n\n*** Listedeki Kartlari Goster *** \n");
        BoardListeleme();
        string silinecekBaslik = KullaniciArayuzu.kullaniciGiris("Silmek Istediğiniz Kartin Basligini giriniz :");

        if (kartlar.Exists(x => x.Baslik == silinecekBaslik))
        {
            Kart kart = kartlar.Find(x => x.Baslik == silinecekBaslik);
            int index = kartlar.IndexOf(kart);
            kartlar.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Bu Baslikta Kart Bulunamadi!");
        }
    }
    public void KartTasi()
    {
        Console.Write("\n\n*** Listedeki Kartlari Goster *** \n");
        BoardListeleme();
        string tasinacakKart = KullaniciArayuzu.kullaniciGiris("TAsimak Istediğiniz Kartin Basligini giriniz :");

        if (kartlar.Exists(x => x.Baslik == tasinacakKart))
        {
            Kart kart = kartlar.Find(x => x.Baslik == tasinacakKart);
            int index = kartlar.IndexOf(kart);
            Tip tasinacakTip= (Tip)Enum.Parse(typeof(Tip),KullaniciArayuzu.kullaniciGiris("Taşimak istediğiniz line seciniz: TODO(1), Progress(2), Done(3)"));
            kartlar[index].Tip= tasinacakTip;
        }
        else
        {
            Console.WriteLine("Bu Baslikta Kart Bulunamadi!");
        }
    }
    public void TemplateKart(Kart kart)
    {
        Console.WriteLine($"Başlik       : {kart.Baslik}");
        Console.WriteLine($"İçerik       : {kart.Icerik}");
        Console.WriteLine($"Atanan Kişi  : {kart.AtananKisi.isim} {kart.AtananKisi.soyad}");
        Console.WriteLine($"Buyukluk     : {kart.Buyukluk}");

    }
    public void BoardListeleme()
    {
        Console.WriteLine();
        Console.WriteLine("********* TODO Line **************");
        Console.WriteLine();
        kartYazdir(Tip.TODO);

        Console.WriteLine();
        Console.WriteLine("***** ProgressLine Line **********");
        Console.WriteLine();
        kartYazdir(Tip.ProgressLine);

        Console.WriteLine();
        Console.WriteLine("********* Done Line **************");
        Console.WriteLine();
        kartYazdir(Tip.Done);

    }
    public void kartYazdir(Tip tip)
    {
        int i = 0;
        foreach (var item in kartlar)
        {

            if (item.Tip == tip)
            {
                KullaniciArayuzu.mesajGoster("-----------------------------");
                TemplateKart(item);
                KullaniciArayuzu.mesajGoster("-----------------------------");
                i++;
            }

        }
        if (i == 0)
        {
            KullaniciArayuzu.mesajGoster("''BOŞ''");
        }
    }
    public void KartGüncelle()
    {

    }
}