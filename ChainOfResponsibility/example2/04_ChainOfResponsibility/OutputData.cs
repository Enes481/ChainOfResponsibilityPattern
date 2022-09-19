using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChainOfResponsibility
{
    internal class OutputData
    {
        public string TCKN { get; set; }
        public decimal Premium { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{TCKN} - {Description} - {Premium}";
        }
    }
}
