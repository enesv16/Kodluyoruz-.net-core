// Sort işlemleri
int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("sirasiz dizi");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("sirali dizi");
Array.Sort(sayiDizisi);
foreach (var sayi2 in sayiDizisi)
{
    Console.WriteLine(sayi2);
}


//Clear array
Console.WriteLine("**** Array Clear *********");
//ikinci indeksten itibaren 2 tane elemanı 0lar
Array.Clear(sayiDizisi,2,2);
foreach (var sayi2 in sayiDizisi)
{
    Console.WriteLine(sayi2);
}

//reverse
Console.WriteLine("**** Array Reverse *********");

Array.Reverse(sayiDizisi);
foreach (var sayi2 in sayiDizisi)
{
    Console.WriteLine(sayi2);
}


//index of array
Console.WriteLine("**** Array indexof *********");

int indeks=Array.IndexOf(sayiDizisi,72);
foreach (var sayi2 in sayiDizisi)
{
    Console.WriteLine(sayi2);
}
    Console.WriteLine(indeks);


//resize array
Console.WriteLine("**** Array resize *********");

Array.Resize<int>(ref sayiDizisi,10);
sayiDizisi[4] = 39;
sayiDizisi[5] = 41;
sayiDizisi[8] = 99;
sayiDizisi[9] = 31;

foreach (var sayi2 in sayiDizisi)
{
    Console.WriteLine(sayi2);
}
sayiDizisi.

