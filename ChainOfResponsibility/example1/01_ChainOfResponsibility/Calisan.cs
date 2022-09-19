using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChainOfResponsibility
{
    abstract class Calisan
    {
        protected Calisan _siradaki;

        public Calisan(Calisan calisan)
        {
            _siradaki = calisan;
        }

        public string AdSoyad { get; set; }

        public abstract string Onayla(Kredi kredi);
    }
}
