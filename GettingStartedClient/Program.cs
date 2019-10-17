using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStartedClient.ServiceReference1;

namespace GettingStartedClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //1: create an instance of the WCF proxy
            CalculatorClient client = new CalculatorClient();

            // 2: Call the service operations;             
            //Add service call:
            double val1 = 100.00D;
            double val2 = 15.99D;
            double res = client.Add(val1, val2);
            Console.WriteLine("Add ({0},{1})={2}", val1, val2, res);

            //Subtract service call:
            val1 = 145.00D;
            val2 = 76.54D;
            res = client.Subtract(val1, val2);
            Console.WriteLine("Subtract ({0},{1})={2}", val1, val2, res);

            //Multiply service call:
            val1 = 9.00D;
            val2 = 81.25D;
            res = client.Multiply(val1, val2);
            Console.WriteLine("Multiply ({0},{1})={2}", val1, val2, res);

            //Divide service call:
            val1 = 22.00D;
            val2 = 7.54D;
            res = client.Divide(val1, val2);
            Console.WriteLine("Divide ({0},{1})={2}", val1, val2, res);

            //3: close client and connection to free resources
            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();

        }
    }
}
