using System;
using System.Collections.Generic;

namespace _04_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InputData> inputs = new List<InputData>();
            inputs.Add(new InputData() { TCKN="11111", PolicyNo="12345" });
            inputs.Add(new InputData() { TCKN="55555", PolicyNo="12345" });

            PolicyExit policyExit = new PremiumExit(null);
            PolicyExit validation = new ValidationExit(policyExit);

            List<OutputData> outputs = new List<OutputData>();
            foreach (InputData item in inputs)
            {
                validation.Process(item);
                outputs.Add(validation.OutputData);
            }

            outputs.ForEach(a => Console.WriteLine(a));

            Console.ReadKey();
        }
    }
}
