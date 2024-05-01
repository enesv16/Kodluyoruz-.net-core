using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        string cumle = Console.ReadLine();
        string sesli = "aeıioöuü";
        ArrayList sesliDizi = new ArrayList();
        int sayac = 0;
        for (int i = 0; i < cumle.Length; i++)
        {
            if (sesli.Contains(cumle[i]))
            {
                sesliDizi.Add(cumle[i]);
                sayac++;
            }
        }
        sesliDizi.Sort();
        foreach (var item in sesliDizi)
        {
            Console.WriteLine(item);
        }

    }
}