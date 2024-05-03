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

        while (true)
        {
            string silinecekAd = KullaniciArayuzu.kullaniciGiris("Lütfen silinecek kisi adini veya soyadini giriniz: ");
            Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(silinecekAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(silinecekAd, StringComparison.OrdinalIgnoreCase));
            if (kisi == null)
            {
                KullaniciArayuzu.mesajGoster("Kullanici rehberde bulunamadi");
                string secim = KullaniciArayuzu.kullaniciGiris("* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");

                if (secim == "1")
                {
                    KullaniciArayuzu.mesajGoster("Islem sonlandirilmistir.");
                    break;
                }
                else if (secim == "2")
                {
                    continue;
                }

            }
            else
            {
                string onay = KullaniciArayuzu.kullaniciGiris($"{kisi.Ad} {kisi.Soyad} isimli kişi rehberden silinmek üzere, onayliyor musunuz ?(y/n)");
                if (onay == "y")
                {
                    rehber.Sil(kisi);
                    KullaniciArayuzu.mesajGoster("Islem basarili!");
                }
                else if (onay == "n")
                {
                    KullaniciArayuzu.mesajGoster("Islemden vazgecildi.");
                }
                break;
            }
        }
    }

    public void kisiGuncelle()
    {
        while (true)
        {
            string guncellenecekAd = KullaniciArayuzu.kullaniciGiris("Lütfen numarasi güncellenecek kisinin adini veya soyadini giriniz: ");
            Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(guncellenecekAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(guncellenecekAd, StringComparison.OrdinalIgnoreCase));
            if (kisi == null)
            {
                KullaniciArayuzu.mesajGoster("Bilgileri güncellemek için önce bir kişiyi seçiniz!");

                string secim = KullaniciArayuzu.kullaniciGiris("* Güncellemeyi sonlandirmak için : (1)\n* Yeniden denemek için      : (2)");

                if (secim == "1")
                {
                    KullaniciArayuzu.mesajGoster("Islem sonlandirilmistir.");
                    break;
                }
                else if (secim == "2")
                {
                    continue;
                }
            }
            else
            {
                string yeniNumara = KullaniciArayuzu.kullaniciGiris("Yeni numarayi giriniz: ");


                string onay = KullaniciArayuzu.kullaniciGiris($"{kisi.Ad} {kisi.Soyad} isimli kişinin numarasi {yeniNumara} olarak değistirelecektir. Onayliyor musunuz ?(y/n)");
                if (onay == "y")
                {
                    kisi.Numara = yeniNumara;
                    KullaniciArayuzu.mesajGoster("Bilgiler basariyla guncellendi.");
                }
                else if (onay == "n")
                {
                    KullaniciArayuzu.mesajGoster("Islemden vazgecildi.");
                }
                break;
            }
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
        KullaniciArayuzu.mesajGoster("Lütfen islem yapmak istediğiniz turu tuslayiniz\nIsim ya da soyisimle aramak için: (1)\nNnumarayla aramak için: (2)");
        int aramaTipi = int.Parse(KullaniciArayuzu.kullaniciGiris("Arama tipini tuşlayiniz:"));
        if (aramaTipi == 1)
        {
            string arananAd = KullaniciArayuzu.kullaniciGiris("Lütfen numarasi güncellenecek kisinin adini veya soyadini giriniz: ");
            Kisi kisi = rehber.KisiList.FirstOrDefault(aranan => aranan.Ad.Equals(arananAd, StringComparison.OrdinalIgnoreCase) || aranan.Soyad.Equals(arananAd, StringComparison.OrdinalIgnoreCase));
            rehber.KisiYazdir(kisi);
        }
        else if (aramaTipi == 2)
        {
            string arananNumara = KullaniciArayuzu.kullaniciGiris("Aranacak numarayi giriniz:");
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