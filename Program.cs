using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA9_Waters_Status
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            double temp1;
            //string status;

  
            Console.WriteLine("\n=== LA 9: Water's State of Matter === \n\nWhat is the water temperature in Celcius?");
            //sting temp = Console.ReadLine();
            //temp =double.Parse(Console.ReadLine());
            bool validation = double.TryParse(Console.ReadLine(),out temp);
            if(validation == false)
            {
                Console.WriteLine("Please make sure to input the temprature in a number format.");
                Console.ReadLine();
            }
            else
            {
                temp1 = temp;

                Console.WriteLine("\n --- Results through ternary statement: ---");
                string a = "The water status at " + temp1 + "\xb0 \bC is";
                string b = temp1 > 100 ? " GAS." : (temp1 <= 0 ? " SOLID." : " LIQUID.");
                Console.WriteLine(a + b);

                Console.WriteLine("\n --- Results through if statements: ---");
                if (temp > 100)
                {
                    Console.WriteLine(a+" GAS.");
                }
                else if (temp <= 0)
                {
                    Console.WriteLine(a+" SOLID.");
                }
                else
                {
                    Console.WriteLine(a+" LIQUID.");
                }

                /* status = temp1 > 100 ? "The water status is GAS " : (temp1 <= 0 ? "The water status is SOLID " : "The water status is LIQUID ");
                Console.WriteLine(status + "at {0}", temp1 +"\xB0 \bC"); <---my original code*/

                Console.ReadLine();
            }

        }
    }
}
