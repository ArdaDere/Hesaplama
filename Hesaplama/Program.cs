using System;
using Matematik; 

namespace ProgramNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());


            Hesaplama hesap = new Hesaplama();


            int toplamSonuc = hesap.topla(sayi1, sayi2);
            int carpimSonuc = hesap.carp(sayi1, sayi2);


            Console.WriteLine($"Toplam: {toplamSonuc}");
            Console.WriteLine($"Çarpım: {carpimSonuc}");

            Console.ReadKey();
        }
    }
}
