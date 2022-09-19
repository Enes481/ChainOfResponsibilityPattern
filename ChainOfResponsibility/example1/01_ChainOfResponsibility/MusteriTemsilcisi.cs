using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    internal class MusteriTemsilcisi : Calisan
    {
        public MusteriTemsilcisi(Calisan calisan) : base(calisan)
        {

        }

        public override string Onayla(Kredi kredi)
        {
            if (kredi.Tutar <= 30000)
            {
                return "Kredi müşteri temsilcisi tarafından onaylandı";
            }
            else
            {
                string sonuc = "Kredi onayı şube müdürüne iletildi.\n";
                sonuc += _siradaki.Onayla(kredi);
                return sonuc;
            }
        }
    }
}
