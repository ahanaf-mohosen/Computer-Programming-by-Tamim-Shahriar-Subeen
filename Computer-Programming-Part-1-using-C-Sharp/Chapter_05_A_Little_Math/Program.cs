using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_05_A_Little_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 5.1
            double x, y, xPlusY, xMinusY;

            // Input for x + y
            Console.Write("Enter the value of x + y: ");
            xPlusY = Convert.ToDouble(Console.ReadLine());

            // Input for x - y
            Console.Write("Enter the value of x - y: ");
            xMinusY = Convert.ToDouble(Console.ReadLine());

            // Calculate x and y
            x = (xPlusY + xMinusY) / 2;
            y = (xPlusY - xMinusY) / 2;

            // Output the result
            Console.WriteLine($"x = {x:F2}, y = {y:F2}");
            #endregion

            #region CpBook_1, Problem: 5.2
            //double a1, a2, b1, b2, c1, c2, x, y;

            //// Input values for a1, a2, b1, b2, c1, c2
            //Console.Write("a1 = ");
            //a1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("a2 = ");
            //a2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b1 = ");
            //b1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b2 = ");
            //b2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c1 = ");
            //c1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c2 = ");
            //c2 = Convert.ToDouble(Console.ReadLine());

            //// Cramer's rule to calculate x and y
            //double denominator = a1 * b2 - a2 * b1;
            //x = (b2 * c1 - b1 * c2) / denominator;
            //y = (a1 * c2 - a2 * c1) / denominator;

            //// Output the result
            //Console.WriteLine($"x = {x:F2}, y = {y:F2}");
            #endregion

            #region CpBook_1, Problem: 5.3
            //double a1, a2, b1, b2, c1, c2, d, x, y;

            //// Input values for a1, a2, b1, b2, c1, c2
            //Console.Write("a1 = ");
            //a1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("a2 = ");
            //a2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b1 = ");
            //b1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("b2 = ");
            //b2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c1 = ");
            //c1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("c2 = ");
            //c2 = Convert.ToDouble(Console.ReadLine());

            //// Calculate the determinant d
            //d = a1 * b2 - a2 * b1;

            //// Check if determinant is zero
            //if (d == 0)
            //{
            //    Console.WriteLine("Value of x and y can not be determined.");
            //}
            //else
            //{
            //    // Cramer's rule to calculate x and y
            //    x = (b2 * c1 - b1 * c2) / d;
            //    y = (a1 * c2 - a2 * c1) / d;

            //    // Output the result
            //    Console.WriteLine($"x = {x:F2}, y = {y:F2}");
            //}
            #endregion

            #region CpBook_1, Problem: 5.4
            //// Declare variables
            //double loanAmount, interestRate, numberOfYears, totalAmount, monthlyAmount;

            //// Get user inputs
            //Console.Write("Enter the loan amount: ");
            //loanAmount = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the interest rate: ");
            //interestRate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Number of years: ");
            //numberOfYears = Convert.ToDouble(Console.ReadLine());

            //// Calculate total amount and monthly amount
            //totalAmount = loanAmount + loanAmount * numberOfYears * interestRate / 100.00;
            //monthlyAmount = totalAmount / (numberOfYears * 12);

            //// Display results
            //Console.WriteLine("Total amount: {0:F2}", totalAmount);
            //Console.WriteLine("Monthly amount: {0:F2}", monthlyAmount);
            #endregion

            #region CpBook_1, Problem: 5.5
            //// Declare variables
            //int n, sum;

            //// Get user input
            //n = Convert.ToInt32(Console.ReadLine());

            //// Calculate the summation
            //sum = (n * (n + 1)) / 2;

            //// Display the result
            //Console.WriteLine("Summation is {0}", sum);
            #endregion

            #region CpBook_1, Problem: 5.6
            //// Declare variables
            //int i, n, sum;

            //// Get user input
            //n = Convert.ToInt32(Console.ReadLine());

            //// Calculate the summation using a loop
            //sum = 0;
            //for (i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //// Display the result
            //Console.WriteLine("Summation is {0}", sum);
            #endregion

            #region CpBook_1, Problem: 5.6.1
            //// Declare variables
            //int n, sum = 0;

            //// Get user input
            //Console.Write("Enter a positive integer: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is positive
            //if (n > 0)
            //{
            //    // Loop to calculate the sum of odd numbers
            //    for (int i = 1; i <= n; i += 2)
            //    {
            //        sum += i;
            //    }

            //    // Display the result
            //    Console.WriteLine("The sum of odd numbers from 1 to {0} is: {1}", n, sum);
            //}
            //else
            //{
            //    // Display a message if the number is not positive
            //    Console.WriteLine("Please enter a positive integer.");
            //}
            #endregion

            #region CpBook_1, Problem: 5.7
            //double celsius, fahrenheit;
            //Console.Write("Enter the temperature in celsius: ");
            //celsius = Convert.ToDouble(Console.ReadLine());
            //fahrenheit = 1.8 * celsius + 32;
            //Console.WriteLine($"Temperature in fahrenheit is: {fahrenheit}");
            #endregion

            #region CpBook_1, Problem: 5.7.1
            //// Declare variables
            //double celsius, fahrenheit;

            //// Get user input for temperature in Fahrenheit
            //Console.Write("Enter the temperature in Fahrenheit: ");
            //fahrenheit = Convert.ToDouble(Console.ReadLine());

            //// Convert Fahrenheit to Celsius
            //celsius = (fahrenheit - 32) / 1.8;

            //// Display the result in Celsius
            //Console.WriteLine("Temperature in Celsius is: {0}", celsius);
            #endregion

            #region CpBook_1, Problem: 5.8
            //int a, b, x, gcd = 1;
            //string[] input = Console.ReadLine().Split();
            //a = Convert.ToInt32(input[0]);
            //b = Convert.ToInt32(input[1]);

            //for (x = (a < b) ? a : b; x >= 1; x--)
            //{
            //    if (a % x == 0 && b % x == 0)
            //    {
            //        gcd = x;
            //        break;
            //    }
            //}
            //Console.WriteLine($"GCD is {gcd}");
            #endregion

            #region CpBook_1, Problem: 5.9
            //int a, b, t, gcd;

            //string[] input = Console.ReadLine().Split();
            //a = Convert.ToInt32(input[0]);
            //b = Convert.ToInt32(input[1]);

            //if (a == 0)
            //{
            //    gcd = a;
            //}
            //else if (b == 0)
            //{
            //    gcd = b;
            //}
            //else
            //{
            //    while (b != 0)
            //    {
            //        t = b;
            //        b = a % b;
            //        a = t;
            //        Console.WriteLine($"a={a}, b={b}");
            //    }
            //    gcd = a;
            //}

            //Console.WriteLine($"GCD is {gcd}");
            #endregion

            #region CpBook_1, Problem: 5.9.1
            //Console.Write("Enter two integers: ");
            //string? input = Console.ReadLine();

            //// Validate input
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid input. Please provide two integers.");
            //    return;
            //}

            //string[] parts = input.Split();
            //if (parts.Length != 2 || !int.TryParse(parts[0], out int a) || !int.TryParse(parts[1], out int b))
            //{
            //    Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
            //    return;
            //}

            //Console.WriteLine($"LCM of {a} and {b} is {Lcm(a, b)}");
            //static int Gcd(int a, int b)
            //{
            //    while (b != 0)
            //    {
            //        int t = b;
            //        b = a % b;
            //        a = t;
            //    }
            //    return Math.Abs(a); // GCD should always be positive
            //}

            //static int Lcm(int a, int b)
            //{
            //    if (a == 0 || b == 0) return 0; // LCM is 0 if any number is 0
            //    return Math.Abs(a * b) / Gcd(a, b);
            //}
            #endregion
        }
    }
}
