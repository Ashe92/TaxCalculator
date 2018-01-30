using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Contracts;

namespace ConsoleStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Program progra = new Program();
            progra.ConsoleMain();
        }

        public void ConsoleMain()
        {
            WriteToConsol("Write the basic amount: ");
            string basicAmount = Console.ReadLine();
            WriteToConsol("Choose type of contract epmloyment: \n\r 1. Contract employment [c] \n\r 2.Contract Mandate [m]");
            string temp = Console.ReadLine();
            if (temp == "C" || temp == "c")
            {
                 ContractEmployment contractEmployment = new ContractEmployment("1",double.Parse(basicAmount),0,0);
                 WriteToConsol("Walue earned : " + contractEmployment.Result.ToString());
            }
            else if (temp == "M" || temp == "m" )
            {
                ContractMandate contractMandate = new ContractMandate("1", double.Parse(basicAmount), 0, 0);
                WriteToConsol("Walue earned : " + contractMandate.Result.ToString());
            }
            else
            {
                WriteToConsol("\n\rThe is no value " + temp);
                Console.ReadLine();
            }
            Console.ReadLine();

        }

        

        public void WriteToConsol(string temp)
        {
            Console.WriteLine(temp);
        }
    }
}
