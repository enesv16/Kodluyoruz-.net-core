using System.Transactions;
using System.Xml.Serialization;

public class RehberYoneticisi
{
    private Rehber rehber;
    public RehberYoneticisi(Rehber rehber)
    {
        this.rehber = rehber;
    }


    public void kisiEkle()
    {
        string isim = KullaniciArayuzu.kullaniciGiris("Lütfen isim giriniz: ");
        string soyad = KullaniciArayuzu.kullaniciGiris("Lütfen soyadinizi giriniz: ");
        string telNo = KullaniciArayuzu.kullaniciGiris("Lütfen telefon numaranizi giriniz: ");
        rehber.Ekle(new Kisi(isim, soyad, telNo));
        KullaniciArayuzu.mesajGoster("Kullanici rehbere başariyla eklendi.");
    }

    public void kisiSil()
    {
        string silinecekAd = KullaniciArayuzu.kullaniciGiris("Lütfen silinecek kisi adini veya soyadini giriniz: ");
        Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(silinecekAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(silinecekAd, StringComparison.OrdinalIgnoreCase));
        if (kisi == null)
        {
            KullaniciArayuzu.mesajGoster("Kullanici rehberde bulunamadi");
            return;
        }
        else
        {
            rehber.Sil(kisi);
        }
    }

    public void kisiGuncelle()
    {
        string guncellenecekAd = KullaniciArayuzu.kullaniciGiris("Lütfen numarasi güncellenecek kisinin adini veya soyadini giriniz: ");
        Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(guncellenecekAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(guncellenecekAd, StringComparison.OrdinalIgnoreCase));
        if (kisi == null)
        {
            KullaniciArayuzu.mesajGoster("Bilgileri güncellemek için önce bir kişiyi seçiniz!");
        }
        else
        {
            string yeniNumara = KullaniciArayuzu.kullaniciGiris("Yeni numarayi giriniz: ");
            kisi.Numara = yeniNumara;
            KullaniciArayuzu.mesajGoster("Bilgiler basariyla guncellendi.");
        }
    }


    public void rehberListele()
    {
        KullaniciArayuzu.mesajGoster("Lütfen siralam türünü seçiniz");
        KullaniciArayuzu.mesajGoster("A-Z siralamak için  1'e Basiniz.");
        KullaniciArayuzu.mesajGoster("Z-A siralama için  2'ye Basınız.");
        int secim = Convert.ToInt32(KullaniciArayuzu.kullaniciGiris("Seçim yapiniz:"));
        var newList = rehber.KisiList.OrderBy(person => person.Ad).ToList();
        var newListDec = rehber.KisiList.OrderByDescending(person => person.Ad).ToList();
        if (secim == 1)
        {
            foreach (Kisi kisi in newList)
            {
                KullaniciArayuzu.mesajGoster(kisi.Ad + " " + kisi.Soyad + " - " + kisi.Numara);
            }
        }
        else if (secim == 2)
        {
            foreach (Kisi kisi in newListDec)
            {
                KullaniciArayuzu.mesajGoster(kisi.Ad + " " + kisi.Soyad + " - " + kisi.Numara);
            }
        }


    }

    public void rehberdeAra()
    {
        KullaniciArayuzu.mesajGoster("isim ya da soyisimle aramak için 1i numarayla aramak için 2yi tuşlayiniz:");
        int aramaTipi = int.Parse(KullaniciArayuzu.kullaniciGiris("Arama tipini tuşlayiniz:"));
        if (aramaTipi == 1)
        {
            string arananAd = KullaniciArayuzu.kullaniciGiris("Lütfen numarasi güncellenecek kisinin adini veya soyadini giriniz: ");
            Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(arananAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(arananAd, StringComparison.OrdinalIgnoreCase));
            rehber.KisiYazdir(kisi);
        }
        else if (aramaTipi == 2)
        {
            string arananNumara = KullaniciArayuzu.kullaniciGiris("Aranacak numarayı giriniz:");
            Kisi sonuc = rehber.KisiList.FirstOrDefault(aranan => aranan.Numara.Equals(arananNumara, StringComparison.OrdinalIgnoreCase));
            if (sonuc != null)
            {
                rehber.KisiYazdir(sonuc);
            }
            else
            {
                KullaniciArayuzu.mesajGoster("Bu numara bulunamadı!");
            }


        }

    }
}