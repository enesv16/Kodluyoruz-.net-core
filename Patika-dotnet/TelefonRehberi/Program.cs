internal class Program
{
    private static void Main(string[] args)
    {
        Rehber rehber= new Rehber();
        RehberYoneticisi rehberYoneticisi= new RehberYoneticisi(rehber);


        while (true)
        {

            Console.WriteLine("-*-*-*-*-_Rehber Islemleri_-*-*-*-*");

            Console.WriteLine("1 - Telefon Numarasi Kaydet");
            Console.WriteLine("2 - Telefon Numarasi Sil");
            Console.WriteLine("3 - Telefon Numarasi Güncelle");
            Console.WriteLine("4 - Rehber Listeleme (A-Z, Z-A seçimli)");
            Console.WriteLine("5 - Rehberde Arama");
            Console.Write("\nLutfen islem numarasini giriniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    rehberYoneticisi.kisiEkle();
                    break;

                case 2:
                    rehberYoneticisi.kisiSil();
                    break;
                case 3:
                    rehberYoneticisi.kisiGuncelle();
                    break;

                case 4:
                    rehberYoneticisi.rehberListele();
                    break;
                case 5:
                    rehberYoneticisi.rehberdeAra();
                    break;

            }
        }
    }
}