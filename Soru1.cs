using System;
using System.Collections;

ArrayList asal=new ArrayList();
ArrayList asalOlmayan=new ArrayList();
int kontrol=0;
int asaltoplam=0;
int asalOlmayanToplam=0;
for (int i =0; i < 20; i++)
{
    int sayi=Convert.ToInt32(Console.ReadLine());
    for (int j = 2; j < sayi; j++)
    {
        if (sayi%j==0 || sayi>=1)
        {
            asalOlmayan.Add(sayi);
            asalOlmayanToplam+=sayi;
            kontrol++;
            break;
        }
      
    }
    if (kontrol==0)
    {
        asal.Add(sayi);
        asaltoplam+=sayi;
    }
}
asal.Sort();
asal.Reverse();

asalOlmayan.Sort();
asalOlmayan.Reverse();
Console.WriteLine("Asal Sayılar");


foreach (var asa in asal)
 {Console.WriteLine(asa);}
Console.WriteLine();
Console.WriteLine("Asal Olmayan Sayılar");

foreach (var asa in asalOlmayan)
{Console.WriteLine(asa);}
Console.WriteLine();
Console.WriteLine("Asal Dizi Eleman Sayısı ="+asal.Count);
Console.WriteLine("Asal Olmayan Dizi Eleman Sayısı ="+asalOlmayan.Count);

Console.WriteLine("Asal Sayılar Ortalaması = "+(asaltoplam/asal.Count));
Console.WriteLine("Asal Olmayan Sayılar Ortalaması = "+(asalOlmayanToplam/asalOlmayan.Count));