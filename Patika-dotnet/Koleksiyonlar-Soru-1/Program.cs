using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int kontrol = 0;
        ArrayList notAsal = new ArrayList();
        ArrayList asal = new ArrayList();
        for (int j = 0; j < 20; j++)
        {
            Console.Write(j + 1 + ". Sayiyi Giriniz : ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int sayi) && sayi > 0)
            {
                if (IsAsal(sayi))
                {
                    asal.Add(sayi);
                }
                else
                {
                    notAsal.Add(sayi);
                }

            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir sayı giriniz.");
                j--;
            }
        }
        asal.Sort();
        asal.Reverse();
        notAsal.Sort();
        notAsal.Reverse();

        Console.WriteLine("\nAsal Sayılar:");
        foreach (int asalOlan in asal)
            Console.Write(asalOlan + " ");

        Console.WriteLine("Ortalamasi:" + CalculateAverage(asal));
        Console.WriteLine("Eleman Sayisi:"+asal.Count);

        Console.WriteLine("\nAsal Olmayan Sayılar:");
        foreach (int asalOlmayan in notAsal)
            Console.Write(asalOlmayan + " ");

        Console.WriteLine("Ortalamasi:" + CalculateAverage(notAsal));
        Console.WriteLine("Eleman Sayisi:"+notAsal.Count);




        static bool IsAsal(int sayi)
        {
            if (sayi < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                    return false;
            }

            return true;
        }
        static double CalculateAverage(ArrayList asalSayilar)
        {
            double result = 0;
            int count = asalSayilar.Count;

            foreach (int sayi in asalSayilar)
            {
                result += sayi;
            }

            return result / count;
        }
    }

}