using System.Globalization;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Odev odevler = new();
        odevler.FirstExample();
        odevler.SeconExample();
        odevler.ThirdExample();
        odevler.FourthExample();

    }
}
public class Odev
{
    public void FirstExample()
    {
        Console.WriteLine("Lütfen pozitif bir sayi giriniz");
        int sayi = Convert.ToInt32(Console.ReadLine());
        while (sayi <= 0)
        {
            Console.WriteLine("Pozitif sayi girmediniz. Lütfen pozitif bir sayi giriniz!");
            sayi = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Lütfen {sayi} tane pozitif sayi giriniz.");
        int[] sayilar = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine($"{i + 1}. sayiyi giriniz.");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            while (sayilar[i] <= 0)
            {
                Console.WriteLine("Pozitif sayi girmediniz. Lütfen pozitif bir sayi giriniz!");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        Console.Write("Pozitif sayilar: ");
        foreach (int number in sayilar)
        {
            if (number % 2 == 0)
            {
                Console.Write($"{number},");
            }
        }
    }
    public void SeconExample()
    {
        Console.WriteLine("Lütfen 2 adet pozitif sayi giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Lütfen {n} tane pozitif sayi giriniz.");
        int[] sayilar = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1}. sayiyi giriniz.");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            while (sayilar[i] <= 0)
            {
                Console.WriteLine("Pozitif sayi girmediniz. Lütfen pozitif bir sayi giriniz!");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        foreach (var item in sayilar)
        {
            if (item % m == 0)
            {
                Console.Write(item);
            }
        }
    }
    public void ThirdExample()
    {
        Console.WriteLine("Lütfen pozitif bir sayi giriniz");
        int sayi = Convert.ToInt32(Console.ReadLine());
        while (sayi <= 0)
        {
            Console.WriteLine("Pozitif sayi girmediniz. Lütfen pozitif bir sayi giriniz!");
            sayi = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Lütfen {sayi} adet kelime giriniz.");
        string[] kelimeler = new string[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine($"{i + 1}. kelimeyi giriniz.");
            kelimeler[i] = Console.ReadLine();
        }
        Array.Reverse(kelimeler);
        foreach (var item in kelimeler)
        {
            Console.Write(item + " ");
        }
    }
    public void FourthExample()
    {
        string metin;
        Console.WriteLine("metni giriniz:");
        metin = Console.ReadLine();
        String[] kelimeler = metin.Split(' ');
        Console.WriteLine("Kelime Sayisi :" + kelimeler.Length);
        metin= string.Join("", metin.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

        Console.WriteLine("Harf Sayisi"+ metin.Length);
    }
}