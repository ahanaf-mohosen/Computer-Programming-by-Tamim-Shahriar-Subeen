using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12_Binary_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 12.1
            Console.Write("Enter the binary number: ");
            string? binary = Console.ReadLine();

            // Validate input
            if (string.IsNullOrWhiteSpace(binary))
            {
                Console.WriteLine("Invalid input. Please enter a valid binary number.");
                return;
            }

            int decimalValue = 0;
            int len = binary.Length;
            int power = len - 1;

            for (int i = 0; i < len; i++)
            {
                if (binary[i] != '0' && binary[i] != '1')
                {
                    Console.WriteLine("Invalid input. Binary numbers can only contain 0 and 1.");
                    return;
                }

                decimalValue += (binary[i] - '0') * (int)Math.Pow(2, power);
                power--;
            }

            Console.WriteLine("Decimal value is " + decimalValue);
            #endregion

            #region CpBook_1, Problem: 12.1.1
            //Console.Write("Enter a decimal number: ");
            //string? input = Console.ReadLine();

            //// Validate and parse input
            //if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int num))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //Console.Write("Binary representation of " + num + " is: ");
            //DecimalToBinary(num);
            //Console.WriteLine();

            //static void DecimalToBinary(int n)
            //{
            //    if (n > 1)
            //    {
            //        DecimalToBinary(n / 2);
            //    }
            //    Console.Write(n % 2);
            //}
            #endregion
        }
    }
}
