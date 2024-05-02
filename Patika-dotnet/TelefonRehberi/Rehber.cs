public class Rehber
{
    private List<Kisi> kisiList; // Kisilerin listesi.

    public Rehber()
    {
        kisiList = new List<Kisi>{
            new Kisi("Ali", "Topcu","12345"),
            new Kisi("Fatma","Gürbüz","45678"),
            new Kisi("Melo", "Kel","98732"),
            new Kisi("Ayse","Mehmet","14312"),
            new Kisi("Halil","Bursa","20952"),
            new Kisi("Dilara","VARDAR", "13579")
          };
    }

    public List<Kisi> KisiList
    {
        get
        {
            return this.kisiList;
        }
    }

    public void Ekle(Kisi yeniKisi)
    {
        kisiList.Add(yeniKisi);
    }

    public void Sil(Kisi kisi)
    {
        kisiList.Remove(kisi);
    }

    public void Guncelle(string kisiAdi, string numara)
    {
        kisiList.Find(aranan => aranan.Ad.Equals(kisiAdi, StringComparison.OrdinalIgnoreCase) ||
        aranan.Soyad.Equals(kisiAdi, StringComparison.OrdinalIgnoreCase)).Numara = numara;

    }

    public void KisiYazdir(Kisi kisi)
    {
        foreach (var item in kisiList)
        {
            if (item == kisi)
            {
                Console.WriteLine($"Ad: {item.Ad} Soyad:{item.Soyad}\nTelefon No:{item.Numara}");
            }
        }
    }



}