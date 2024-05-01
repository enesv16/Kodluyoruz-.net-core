public class Program
{
    // Enes Vardar
    // Sirali verilerde kullaniliyor, ardişik indexlerde
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);

        int sicaklik = 32;

        if (sicaklik <= (int)Hava_Durumu.Normal)
            Console.WriteLine("Dişariya çikmak için havanin biraz daha isinmasini bekleyelim");
        else if (sicaklik >= (int)Hava_Durumu.Sicak)
            Console.WriteLine("Dişariya çikmak için çok sicak bir gün");
        else if (sicaklik >= (int)Hava_Durumu.Normal && sicaklik <= (int)Hava_Durumu.Cok_Sicak)
            Console.WriteLine("Hadi dişariya çikalim");
    }
    enum Gunler
    {
        Pazartesi = 1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum Hava_Durumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        Cok_Sicak = 30
    }
}