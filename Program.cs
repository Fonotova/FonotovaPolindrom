using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonotovaPolindrom
{
    class Program
    {
        static int Polindrom(int n)
        {
            string str = "1881";
            string newString = "";
            int max = 0;
            double basis = 10;
            double digit = n;

            int upper = Convert.ToInt32(Math.Pow(basis, digit));
            int lower = Convert.ToInt32(Math.Pow(basis, (digit - 1)));
            Console.WriteLine("Please, wait...");
            Console.WriteLine();
            for (int first = (upper - 1); first > lower; first--)
            {
                for (int second = (upper - 1); second > lower; second--)
                {
                    str = Convert.ToString(first * second);

                    for (int strLength = 0; strLength < str.Length; strLength++)
                    {
                        newString = newString + str[(str.Length - 1 - strLength)];
                    }
                    if (String.Compare(str, newString) == 0)
                    {
                        if (first * second > max)
                        {
                            max = first * second;
                        }
                    }
                    newString = "";
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int DigitNumber = 3; // 3-digit numbers. 
            Console.WriteLine("LagestPolindrom = {0}", Polindrom(DigitNumber));
        }
    }
}
