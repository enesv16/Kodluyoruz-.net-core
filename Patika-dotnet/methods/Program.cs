// erişim belirtecigeri dönüş tipi metot_adi(parametre listesi/argmüman)


internal class Program
{


    private static void Main(string[] args)
    {
        int a=4;
        int b=3;
        Console.WriteLine(Topla(a, b));
        Metotlar ornek = new Metotlar();
        ornek.ekranaYazdir("asd");
        int c= ornek.ArttırVeTopla(ref a,ref b);
        Console.WriteLine(a);

    }

    static int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }
}

class Metotlar
{
    public void ekranaYazdir(string s)
    {
        Console.WriteLine(s);
    }
    public int ArttırVeTopla(ref int deger1,ref int deger2)
    {
        deger1++;
        deger2++;
        return deger1 + deger2;
    }
}