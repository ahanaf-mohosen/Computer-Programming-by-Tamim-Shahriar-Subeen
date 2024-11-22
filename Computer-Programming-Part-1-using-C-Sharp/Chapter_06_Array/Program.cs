using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 6.1
            int ft_marks, st_marks, final_marks;
            double total_marks;

            ft_marks = 80;
            st_marks = 74;
            final_marks = 97;

            total_marks = ft_marks / 4.0 + st_marks / 4.0 + final_marks / 2.0;

            Console.WriteLine($"{total_marks:0}");
            #endregion

            #region CpBook_1, Problem: 6.2
            //int[] ara = { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"First element: {ara[0]}");
            //Console.WriteLine($"Third element: {ara[2]}");
            #endregion

            #region CpBook_1, Problem: 6.3
            //int[] ara = { 6, 7, 4, 6, 9 };

            //try
            //{
            //    Console.WriteLine(ara[-1]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index -1 is out of bounds.");
            //}

            //try
            //{
            //    Console.WriteLine(ara[5]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index 5 is out of bounds.");
            //}

            //try
            //{
            //    Console.WriteLine(ara[100]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index 100 is out of bounds.");
            //}
            #endregion

            #region CpBook_1, Problem: 6.4
            //int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i + 1}th element is: {ara[i]}");
            //}
            #endregion

            #region CpBook_1, Problem: 6.5
            //int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int[] ara2 = new int[10];

            //for (int i = 0, j = 9; i < 10; i++, j--)
            //{
            //    ara2[j] = ara[i];
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    ara[i] = ara2[i];
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ara[i]);
            //}
            #endregion

            #region CpBook_1, Problem: 6.6
            //int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int temp;

            //for (int i = 0, j = 9; i < 10 / 2; i++, j--) // i < j condition is also valid
            //{
            //    temp = ara[j];
            //    ara[j] = ara[i];
            //    ara[i] = temp;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ara[i]);
            //}
            #endregion

            #region CpBook_1, Problem: 6.7
            //int[] ft_marks = { 83, 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62 };
            //int[] st_marks = { 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62, 49 };
            //int[] final_marks = { 87, 64, 91, 43, 89, 66, 58, 73, 99, 81, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71, 62, 78, 58, 66, 98, 75, 86, 90, 80, 85, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71 };

            //double[] total_marks = new double[40];

            //for (int i = 0; i < 40; i++)
            //{
            //    total_marks[i] = ft_marks[i] / 4.0 + st_marks[i] / 4.0 + final_marks[i] / 2.0;
            //}

            //for (int i = 1; i <= 40; i++)
            //{
            //    Console.WriteLine($"Roll NO: {i}\tTotal Marks: {total_marks[i - 1]:0}");
            //}
            #endregion

            #region CpBook_1, Problem: 6.8
            //int[] total_marks = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65, 80, 72, 62, 68, 81, 62, 56, 68, 58, 56, 82, 70, 74, 78, 76, 84, 88, 73, 62, 66, 76, 70, 67, 65, 77, 63 };

            //for (int marks = 50; marks <= 100; marks++)
            //{
            //    int count = 0;
            //    for (int i = 0; i < total_marks.Length; i++)
            //    {
            //        if (total_marks[i] == marks)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"Marks: {marks} Count: {count}");
            //}
            #endregion

            #region CpBook_1, Problem: 6.9
            //int[] total_marks = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65, 80, 72, 62, 68, 81, 62, 56, 68, 58, 56, 82, 70, 74, 78, 76, 84, 88, 73, 62, 66, 76, 70, 67, 65, 77, 63 };
            //int[] marks_count = new int[101];

            //for (int i = 0; i < 101; i++)
            //{
            //    marks_count[i] = 0;
            //}

            //for (int i = 0; i < total_marks.Length; i++)
            //{
            //    marks_count[total_marks[i]]++;
            //}

            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine($"Marks: {i} Count: {marks_count[i]}");
            //}
            #endregion

            #region CpBook_1, Problem: 6.10
            //int[] total_marks = { 6, 7, 4, 6, 9, 7, 6, 2, 4, 3, 4, 1 };
            //int[] marks_count = new int[11];

            //Console.WriteLine("1 2 3 4 5 6 7 8 9");
            //Console.WriteLine("-----------------");

            //for (int i = 0; i < 12; i++)
            //{
            //    marks_count[total_marks[i]]++;

            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{marks_count[j]} ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
