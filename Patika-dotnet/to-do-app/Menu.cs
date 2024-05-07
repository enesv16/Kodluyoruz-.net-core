public class Menu
{
    public void anaMenu()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
        Console.WriteLine("******************");
        Console.WriteLine(""
            + "1- Board Listeleme \n"
            + "2- Board'a Kart Ekleme \n"
            + "3- Board'dan Kart Silme \n"
            + "4- Kart Taşima \n"
            );
        Console.WriteLine("******************");
    }

    public void tamMenu()
    {
        KartIslemleri kartIslemleri = new KartIslemleri();
        
        while (true)
        {
            anaMenu();
            int input;
            int.TryParse(KullaniciArayuzu.kullaniciGiris("Yapmak istediginiz islemi seciniz."), out input);
            switch (input)
            {
                case 1:
                    kartIslemleri.BoardListeleme();
                    break;

                case 2:
                    kartIslemleri.KartEkle();
                    break;

                case 3:
                    kartIslemleri.KartSil();
                    break;

                case 4:
                    kartIslemleri.KartTasi();
                    break;

                default:
                    Console.WriteLine("Hatali seçim yaptiniz!");
                    break;
            }
        }

    }
}