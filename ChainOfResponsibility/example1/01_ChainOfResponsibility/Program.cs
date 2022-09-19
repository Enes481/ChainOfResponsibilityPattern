using System;

namespace _01_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kredi kredi = new Kredi() { Tutar = 3500000, KrediTipi = KrediTipleri.Konut };
            Console.WriteLine(Banka.KrediBasvurusuYap(kredi));

            Console.ReadKey();
        }
    }
}
