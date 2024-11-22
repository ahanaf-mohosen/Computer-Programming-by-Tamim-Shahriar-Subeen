using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Some_Programming_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 13.1
            Console.Write("Enter a word: ");
            string? word = Console.ReadLine();

            // Validate input
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Invalid input. Please enter a valid word.");
                return;
            }

            string reverseWord = "";

            // Reverse the word
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine(reverseWord);

            // Check if the word is a palindrome
            if (word.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(word + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(word + " is not a palindrome.");
            }
            #endregion

            #region CpBook_1, Problem: 13.2
            //int[] ara1 = { 3, 1, 5, 2, 4 };
            //int[] ara2 = new int[5];
            //int minimum, index_2;

            //for (index_2 = 0; index_2 < 5; index_2++)
            //{
            //    minimum = 10000;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (ara1[i] < minimum)
            //        {
            //            minimum = ara1[i];
            //        }
            //    }
            //    ara2[index_2] = minimum;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(ara2[i]);
            //}
            #endregion

            #region CpBook_1, Problem: 13.3
            //int[] ara1 = { 3, 1, 5, 2, 4 };
            //int[] ara2 = new int[5];
            //int minimum, index_2, minimumIndex = -1;

            //for (index_2 = 0; index_2 < 5; index_2++)
            //{
            //    minimum = 10000;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (ara1[i] < minimum)
            //        {
            //            minimum = ara1[i];
            //            minimumIndex = i;
            //        }
            //    }
            //    ara1[minimumIndex] = 10000;
            //    ara2[index_2] = minimum;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(ara2[i]);
            //}
            #endregion

            #region CpBook_1, Problem: 13.4
            //int x, y;
            //char c;

            //Console.Write("Please enter the initial position (e.g., '0 0'): ");
            //string? input = Console.ReadLine();

            //// Validate input
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
            //    return;
            //}

            //string[] position = input.Split();
            //if (position.Length != 2 ||
            //    !int.TryParse(position[0], out x) ||
            //    !int.TryParse(position[1], out y))
            //{
            //    Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
            //    return;
            //}

            //Console.WriteLine("Use U (Up), D (Down), L (Left), R (Right) to move. Press S to stop.");

            //while (true)
            //{
            //    c = Console.ReadKey().KeyChar; // Read a single character input
            //    if (c == 'S' || c == 's') // Allow both uppercase and lowercase 'S' to stop
            //    {
            //        break;
            //    }
            //    else if (c == 'U' || c == 'u') // Move Up
            //    {
            //        x--;
            //    }
            //    else if (c == 'D' || c == 'd') // Move Down
            //    {
            //        x++;
            //    }
            //    else if (c == 'R' || c == 'r') // Move Right
            //    {
            //        y++;
            //    }
            //    else if (c == 'L' || c == 'l') // Move Left
            //    {
            //        y--;
            //    }
            //}

            //Console.WriteLine($"\nFinal position of the robot is: {x}, {y}");
            #endregion

            #region CpBook_1, Problem: Pattern 13.1
            //int n = 7;

            //// Upper part of the pattern
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        // Printing spaces
            //        Console.Write("");
            //    }
            //    for (int k = 0; k <= n - i; k++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part of the pattern
            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = 1; j < i + 1; j++)
            //    {
            //        // Printing spaces
            //        Console.Write("");
            //    }
            //    for (int k = 1; k <= i + 1; k++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region CpBook_1, Problem: Pattern 13.2
            //int rows = 6;

            //// Upper part of the pattern (inverted pyramid)
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        // Printing spaces
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < (2 * (rows - i) - 1); j++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part of the pattern (normal pyramid)
            //for (int i = 1; i < rows; i++)
            //{
            //    for (int j = 0; j < (rows - i - 1); j++)
            //    {
            //        // Printing spaces
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < (2 * i + 1); j++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region CpBook_1, Problem: Pattern 13.3
            //int n = 7;

            //// Upper part of the pattern
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        // Printing spaces
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= n - i; k++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part of the pattern
            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = 1; j < n - i; j++)
            //    {
            //        // Printing spaces
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i + 1; k++)
            //    {
            //        // Printing 'c' characters
            //        Console.Write("c");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region CpBook_1, Problem: Pattern 13.4
            //int rows = 10;

            //// Loop to print the upper part of the pattern
            //for (int i = 1; i <= rows; i++)
            //{
            //    // Print 'c' characters for the left side
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("c");
            //    }

            //    // Print spaces in between
            //    for (int j = 0; j < (rows - i) * 2; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Print 'c' characters for the right side
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("c");
            //    }

            //    // Move to the next line
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
