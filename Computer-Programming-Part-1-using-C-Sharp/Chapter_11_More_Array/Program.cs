using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_More_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 11.1
            int[,] marks = new int[4, 10]
        {
                {80, 70, 92, 78, 58, 83, 85, 66, 99, 81},
                {75, 67, 55, 100, 91, 84, 79, 61, 90, 97},
                {98, 67, 75, 89, 81, 83, 80, 90, 88, 77},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}  // Placeholder for total marks
        };

            for (int col = 0; col < 10; col++)
            {
                marks[3, col] = (int)(marks[0, col] / 4.0 + marks[1, col] / 4.0 + marks[2, col] / 2.0);
                Console.WriteLine($"Roll No: {col + 1} Total Marks: {marks[3, col]}");
            }
            #endregion

            #region CpBook_1, Problem: 11.2
            //int[,] namta = new int[10, 10];

            //// Fill the namta array with multiplication values
            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col < 10; col++)
            //    {
            //        namta[row, col] = (row + 1) * (col + 1);
            //    }
            //}

            //// Display the multiplication table
            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col < 10; col++)
            //    {
            //        Console.WriteLine($"{row + 1} x {col + 1} = {namta[row, col]}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region CpBook_1, Problem: 11.3
            //string[] saarc = { "Bangladesh", "India", "Pakistan", "Sri Lanka", "Nepal", "Bhutan", "Maldives" };

            //// Loop through and print each country
            //for (int row = 0; row < saarc.Length; row++)
            //{
            //    Console.WriteLine(saarc[row]);
            //}
            #endregion

            #region CpBook_1, Problem: 11.4
            //string[] saarc = { "Bangladesh", "India", "Pakistan", "Sri Lanka", "Nepal", "Bhutan", "Maldives" };

            //// Loop through each country name
            //for (int row = 0; row < saarc.Length; row++)
            //{
            //    string country = saarc[row];
            //    int nameLength = country.Length;

            //    // Loop through each character of the country name
            //    for (int col = 0; col < nameLength; col++)
            //    {
            //        Console.Write(country[col] + " ");  // Print character with space
            //    }
            //    Console.WriteLine();  // Print newline after each country's characters
            //}
            #endregion

            #region CpBook_1, Problem: 11.5
            //string[] saarc = { "Bangladesh", "India", "Pakistan", "Sri Lanka", "Nepal", "Bhutan", "Maldives" };

            //// Loop through each country name
            //for (int row = 0; row < saarc.Length; row++)
            //{
            //    string country = saarc[row];
            //    int nameLength = country.Length;

            //    // Loop through each character of the country name
            //    for (int col = 0; col < nameLength; col++)
            //    {
            //        Console.Write($"({row}, {col}) = {country[col]}, ");
            //    }
            //    Console.WriteLine();  // Print newline after each country's characters
            //}
            #endregion

            #region CpBook_1, Problem: 11.6
            //    int[,] ara1 = new int[5, 5]
            //{
            //    { 1, 2, 3, 4, 5 },
            //    { 10, 20, 30, 40, 50 },
            //    { 100, 200, 300, 400, 500 },
            //    { 1000, 2000, 3000, 4000, 5000 },
            //    { 10000, 20000, 30000, 40000, 50000 }
            //};
            //    int[,] ara2 = new int[5, 5];

            //    Console.WriteLine("Content of first array (ara1):");
            //    for (int r = 0; r < 5; r++)
            //    {
            //        for (int c = 0; c < 5; c++)
            //        {
            //            Console.Write(ara1[r, c] + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine();

            //    // Copying the data from ara1 to ara2 (transposing the matrix)
            //    for (int r = 0; r < 5; r++)
            //    {
            //        for (int c = 0; c < 5; c++)
            //        {
            //            ara2[c, r] = ara1[r, c];
            //        }
            //    }

            //    Console.WriteLine("Content of second array (ara2):");
            //    for (int r = 0; r < 5; r++)
            //    {
            //        for (int c = 0; c < 5; c++)
            //        {
            //            Console.Write(ara2[r, c] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            #endregion
        }
    }
}
