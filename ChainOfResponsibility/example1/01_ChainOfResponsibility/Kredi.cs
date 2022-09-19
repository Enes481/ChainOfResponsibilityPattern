using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    internal class Kredi
    {
        public decimal Tutar { get; set; }
        public KrediTipleri KrediTipi { get; set; }
    }

    public enum KrediTipleri
    {
        Ihtiyac,
        Konut,
        Arac
    }
}
