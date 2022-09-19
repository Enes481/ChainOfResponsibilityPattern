using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChainOfResponsibility
{
    internal class PremiumExit : PolicyExit
    {
        public PremiumExit(PolicyExit policyExit) : base(null)
        {
        }

        public override void Process(InputData inputData)
        {
            //birçok yerden veri çek hesapla
            outputData.Premium = 1000;
        }
    }
}
