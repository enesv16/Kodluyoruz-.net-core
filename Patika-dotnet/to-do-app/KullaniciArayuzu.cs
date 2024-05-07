public class KullaniciArayuzu
{
    public static string kullaniciGiris(string mesaj)
    {
        Console.Write(mesaj);
        string giris = Console.ReadLine();
        if (giris == "")
        {
            return "Boş giriş yapilamaz!";
        }
        else
        {
            return giris;
        }
    }

    public static void mesajGoster(string mesaj)
    {
        Console.WriteLine(mesaj);
    }
}