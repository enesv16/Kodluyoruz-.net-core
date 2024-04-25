
try
{
    Console.WriteLine("bir sayi giriniz:");
    // int sayi = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("hata" + ex.Message.ToString());
}
finally
{
    Console.WriteLine("işlem tamamlandı");
}


try
{
    int a = int.Parse("-200000000000000000000000");

}
catch (ArgumentNullException ex)
{
    Console.WriteLine("boş değer girdiniz. --> mesaj kodu :"+ ex.Message.ToString());   
}
catch (FormatException ex1)
{
    Console.WriteLine("yanlış formatta değer girdiniz hata mesaj kodu :"+  ex1.Message.ToString());
}
catch ( OverflowException ex2)
{
    Console.WriteLine("çok büyük değer girdiniz. .hata kodu:"+ex2.Message.ToString());
}
finally
{
 Console.WriteLine("deneme işlemini tamamladınız");
}
