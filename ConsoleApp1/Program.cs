using System;
using System.Collections;

namespace ConsoleApp1
{
    public class PowerList
    {
        public IEnumerable Power(int number, int exponent)
        {
            int valueCounter = 0;
            int currentResult = 1;
            while (valueCounter++ < exponent)
            {
                currentResult = currentResult * number;
                yield return currentResult;
            }
        }
    }

    class Program
    {
        static void 1Main(string[] args)
        {
            PowerList demoObj = new PowerList();

            // Display powers of 2 up to the exponent 10
            foreach (var value in demoObj.Power(2, 10))
            {
                Console.Write("{0} ", value);
            }

            Console.ReadKey(true);
        }
    }
}

