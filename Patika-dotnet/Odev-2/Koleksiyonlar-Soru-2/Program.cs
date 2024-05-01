internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = new int[20];
        int[] max = new int[3];
        int[] min = new int[3];
        for (int j = 0; j < 20; j++)
        {
            Console.Write(j + 1 + ". Sayiyi Giriniz : ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int sayi) && sayi > 0)
            {
                sayilar[j] = sayi;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir sayı giriniz.");
                j--;
            }
        }
        Array.Sort(sayilar);
        max[0] = sayilar[19];
        max[1] = sayilar[18];
        max[2] = sayilar[17];
        Console.WriteLine("Max Ortalamasi:"+CalculateAverage(max));


        min[0] = sayilar[0];
        min[1] = sayilar[1];
        min[2] = sayilar[2];
        Console.WriteLine("Min Ortalamasi:"+CalculateAverage(min));

        Console.WriteLine("Ortalama Toplamlari:"+CalculateAverage(min)+CalculateAverage(max));



        static double CalculateAverage(int[] sayilar)
        {
            double result = 0;
            int count = sayilar.Length;

            foreach (int sayi in sayilar)
            {
                result += sayi;
            }

            return result / count;
        }
    }
}