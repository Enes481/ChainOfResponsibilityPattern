using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChainOfResponsibility
{
    internal class ValidationExit : PolicyExit
    {
        Dictionary<string, string> policyTCKNs;

        public ValidationExit(PolicyExit policyExit) : base(policyExit)
        {
            policyTCKNs = new Dictionary<string, string>();
            policyTCKNs.Add("11111", "12345");
            policyTCKNs.Add("22222", "12345");
        }

        public override void Process(InputData inputData)
        {
            outputData = new OutputData(); // Bunu burada new'lemeyi unutmuşuz. O yüzden aynı nesne üzerinden gidiyor.
            outputData.TCKN = inputData.TCKN;

            if (inputData.TCKN.Length != 5) // != 11
            {
                outputData.Description = "TCKN 5 karakter değildir.";
            }
            else if (!policyTCKNs.ContainsKey(inputData.TCKN))
            {
                outputData.Description = "TCKN bulunamadı";
            }
            else if (policyTCKNs[inputData.TCKN] != inputData.PolicyNo)
            {
                outputData.Description = "Poliçe no hatalı";
            }
            else
            {
                outputData.Description = "Başarılı";
                successor.OutputData = outputData; // Output daata nesnesini sıradaki halkaya taşıdık
                successor.Process(inputData);
            }
        }
    }
}
