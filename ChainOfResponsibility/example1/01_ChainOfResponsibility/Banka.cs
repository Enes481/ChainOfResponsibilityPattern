using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    internal class Banka
    {
        public static string KrediBasvurusuYap(Kredi kredi)
        {
            Calisan genelMudur = new GenelMudur(null);
            Calisan subeMuduru = new SubeMuduru(genelMudur);
            Calisan musteriTemsilcisi = new MusteriTemsilcisi(subeMuduru);

            return musteriTemsilcisi.Onayla(kredi);
        }
    }
}
