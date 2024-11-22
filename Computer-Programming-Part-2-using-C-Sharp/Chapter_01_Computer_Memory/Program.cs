





#region CpBook_2, Problem: 1.1
using System;

class Program
{
    static void Main()
    {
        for (int i = 33; i <= 126; i++)
        {
            Console.WriteLine($"ASCII code for {(char)i} is {i}");
        }
    }
}

#endregion

#region CpBook_2, Problem: 1.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        char smallLetter, capitalLetter;

//        Console.Write("Please enter a small letter: ");
//        smallLetter = Console.ReadKey().KeyChar; // Reads a single key pressed by the user
//        capitalLetter = (char)(smallLetter - 32); // Converts to capital letter

//        Console.WriteLine($"\nThe capital letter is: {capitalLetter}");
//    }
//}

#endregion

#region CpBook_2, Problem: 1.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        char ch1 = 'A', ch2 = 'B';
//        int n1 = 100, n2 = 100000;

//        Console.WriteLine($"Value of ch1 = {ch1},\t Address of ch1 = {GetAddressOf(ch1)}");
//        Console.WriteLine($"Value of ch2 = {ch2},\t Address of ch2 = {GetAddressOf(ch2)}");
//        Console.WriteLine($"Value of n1 = {n1},\t Address of n1 = {GetAddressOf(n1)}");
//        Console.WriteLine($"Value of n2 = {n2},\t Address of n2 = {GetAddressOf(n2)}");
//    }

//    static string GetAddressOf(object obj)
//    {
//        // To simulate getting memory address in C#
//        return obj.GetHashCode().ToString("X");
//    }
//}

#endregion

#region CpBook_2, Problem: 1.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] ara = { 50, 60, 70, 80, 90 };

//        Console.WriteLine($"Value of Array: {ara[0]}, {ara[1]}, {ara[2]}, {ara[3]}, {ara[4]}");

//        // In C#, memory addresses are not directly accessible like in C, so we simulate them
//        Console.WriteLine($"Address of ara[0] = {GetAddressOf(ara[0])}");
//        Console.WriteLine($"Address of ara[1] = {GetAddressOf(ara[1])}");
//        Console.WriteLine($"Address of ara[2] = {GetAddressOf(ara[2])}");
//        Console.WriteLine($"Address of ara[3] = {GetAddressOf(ara[3])}");
//        Console.WriteLine($"Address of ara[4] = {GetAddressOf(ara[4])}");
//    }

//    // Simulating getting the memory address by using GetHashCode() for each element
//    static string GetAddressOf(int obj)
//    {
//        return obj.GetHashCode().ToString("X"); // Returning hash code in hexadecimal format
//    }
//}

#endregion

#region CpBook_2, Problem: 1.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Printing sizes of data types
//        Console.WriteLine($"Size of int: {sizeof(int)}");
//        Console.WriteLine($"Size of char: {sizeof(char)}");
//        Console.WriteLine($"Size of double: {sizeof(double)}");
//        Console.WriteLine($"Size of float: {sizeof(float)}");
//    }
//}

#endregion

#region CpBook_2, Problem: Page 21
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Please enter a character: ");
//        char c = Console.ReadKey().KeyChar; // Reads a single character

//        if (IsDigit(c))
//        {
//            Console.WriteLine("\nIt's a digit.");
//        }
//        else
//        {
//            Console.WriteLine("\nNot a digit.");
//        }
//    }

//    static bool IsDigit(char c)
//    {
//        // Checking if the character is a digit (0-9)
//        return c >= '0' && c <= '9';
//    }
//}

#endregion