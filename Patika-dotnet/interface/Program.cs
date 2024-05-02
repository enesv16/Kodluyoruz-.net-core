internal class Program
{
    private static void Main(string[] args)
    {
        Focus focus = new Focus();
        Console.WriteLine("Hangi Markanin Araci:"+focus.HangiMarkaninAraci().ToString());
        Console.WriteLine("Kac tekeri var: "+focus.KacTekerlektenOlsur());
        Console.WriteLine("Arabanin rengi ne: "+focus.StandartRengiNe().ToString());
        Aventador aventador = new Aventador();
        Console.WriteLine("Hangi Markanin Araci:"+aventador.HangiMarkaninAraci().ToString());
        Console.WriteLine("Kac tekeri var: "+aventador.KacTekerlektenOlsur());
        Console.WriteLine("Arabanin rengi ne: "+aventador.StandartRengiNe().ToString());
        Civic civic = new Civic();
        Console.WriteLine("Hangi Markanin Araci:"+civic.HangiMarkaninAraci().ToString());
        Console.WriteLine("Kac tekeri var: "+civic.KacTekerlektenOlsur());
        Console.WriteLine("Arabanin rengi ne: "+civic.StandartRengiNe().ToString());
    }
}