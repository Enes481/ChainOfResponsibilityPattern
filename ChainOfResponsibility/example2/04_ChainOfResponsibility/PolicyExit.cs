using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChainOfResponsibility
{
    abstract class PolicyExit
    {
        protected PolicyExit successor;
        protected OutputData outputData;

        public PolicyExit(PolicyExit policyExit)
        {
            successor = policyExit;
        }

        public OutputData OutputData
        {
            get { return outputData; }
            internal set { outputData = value; } // bir de output data nesnesini halkalar arasında taşımamız lazım. O yüzden set bloğu yazılmalı.
        }

        public abstract void Process(InputData inputData);
    }
}
