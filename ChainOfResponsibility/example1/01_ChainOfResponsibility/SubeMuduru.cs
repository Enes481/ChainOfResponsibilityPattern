using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    internal class SubeMuduru : Calisan
    {
        public SubeMuduru(Calisan calisan) : base(calisan)
        {
        }

        public override string Onayla(Kredi kredi)
        {
            if (kredi.Tutar <= 100000)
            {
                return "Kredi şube müdürü tarafından onaylandı";
            }
            else
            {
                string sonuc = "Kredi onayı genel müdüre iletildi.\n";
                sonuc += _siradaki.Onayla(kredi);
                return sonuc;
            }
        }
    }
}
