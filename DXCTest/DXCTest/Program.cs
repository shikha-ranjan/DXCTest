using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXCTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var highestPair = new string[5] { "3", "5", "5", "5", "5" };
            int highestPaired = -1;
            string highestPairedValue = string.Empty;
            foreach (var currentValue in highestPair)
            {
                int highestPairedFound = 0;
                foreach (var charToBeMatch in highestPair)
                {
                    if (currentValue == charToBeMatch)
                        highestPairedFound++;
                }
                if (highestPaired < highestPairedFound)
                {
                    highestPaired = highestPairedFound;
                    highestPairedValue = currentValue;
                }
            }
            if (highestPaired <= 1)
            {
                Console.WriteLine(false);
            }
            else
            {
                var result = new object[2] { true, highestPairedValue.ToString() };

                Console.WriteLine(result[0].ToString() + "," + result[1].ToString());
            }

            Console.ReadLine();

        }
    }
}
