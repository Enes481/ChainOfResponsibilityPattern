using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    internal class GenelMudur : Calisan
    {
        public GenelMudur(Calisan calisan) : base(null)
        {
        }

        public override string Onayla(Kredi kredi)
        {
            if (kredi.Tutar <= 500000)
            {
                return "Kredi genel müdür tarafından onaylandı";
            }
            else
            {
                return "Kredi başvurusu reddedildi.";
            }
        }
    }
}
