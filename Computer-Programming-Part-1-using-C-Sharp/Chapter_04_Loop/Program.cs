using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 4.1
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            #endregion

            #region CpBook_1, Problem: 4.2
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            #endregion

            #region CpBook_1, Problem: 4.3
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            #endregion

            #region CpBook_1, Problem: 4.4
            //int n = 1;
            //while (n <= 100)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //    if (n > 10)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 4.5
            //int n = 0;
            //while (n < 10)
            //{
            //    n = n + 1;
            //    if (n % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(n);
            //}
            #endregion

            #region CpBook_1, Problem: 4.6
            //int n = 5;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"{n} X {i} = {n * i}");
            //    i = i + 1;
            //}
            #endregion

            #region CpBook_1, Problem: 4.7
            //int n = 5;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n} X {i} = {n * i}");
            //}
            #endregion

            #region CpBook_1, Problem: 4.8
            //int n = 5;
            //int i = 1;
            //for (; ; )
            //{
            //    Console.WriteLine($"{n} X {i} = {n * i}");
            //    i = i + 1;
            //    if (i > 10)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 4.9
            //int m = 0;
            //int n = 5;
            //for (int i = 1; i <= 10; i++)
            //{
            //    m = m + n;
            //    Console.WriteLine($"{n} X {i} = {m}");
            //}
            #endregion

            #region CpBook_1, Problem: 4.10
            //for (int n = 1; n <= 20; n++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine($"{n} X {i} = {n * i}");
            //    }
            //    Console.WriteLine("---------------------------------");
            //}
            #endregion

            #region CpBook_1, Problem: 4.10.1
            //for (int n = 1; n <= 20; n++)
            //{
            //    int m = 0;
            //    int nn = n;
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        m += nn;
            //        Console.WriteLine($"{n} X {i} = {m}");
            //    }
            //    Console.WriteLine("---------------------------------");
            //}
            #endregion

            #region CpBook_1, Problem: 4.11
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        for (int k = 1; k <= 3; k++)
            //        {
            //            Console.WriteLine($"{i}, {j}, {k}");
            //        }
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 4.12
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3 && j != i; j++)
            //    {
            //        for (int k = 1; k <= 3 && k != i && j != k; k++)
            //        {
            //            Console.WriteLine($"{i}, {j}, {k}");
            //        }
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 4.13
            //for (int a = 1; a <= 3; a++)
            //{
            //    for (int b = 1; b <= 3; b++)
            //    {
            //        if (b != a)
            //        {
            //            for (int c = 1; c <= 3; c++)
            //            {
            //                if (c != b && c != a)
            //                {
            //                    Console.WriteLine($"{a}, {b}, {c}");
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 4.14
            //for (int a = 1; a <= 3; a++)
            //{
            //    for (int b = 1; b <= 3; b++)
            //    {
            //        for (int c = 1; c <= 3; c++)
            //        {
            //            if (b != a && c != a && c != b)
            //            {
            //                Console.WriteLine($"{a}, {b}, {c}");
            //            }
            //        }
            //    }
            //}
            #endregion
        }
    }
}
