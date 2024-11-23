








#region CpBook_2, Problem: 5.1
using System;

byte a, b;

a = 0;
b = (byte)~a;
Console.WriteLine("a = {0}, b = {1}", a, b);

a = 1;
b = (byte)~a;
Console.WriteLine("a = {0}, b = {1}", a, b);

#endregion

#region CpBook_2, Problem: 5.2
//using System;

//int m, x, n;

//while (true)
//{
//    Console.Write("Enter your number (enter 0 to exit): ");
//    string? input = Console.ReadLine();  // Nullable string

//    // Check for null or empty input and try parsing
//    if (string.IsNullOrEmpty(input) || !int.TryParse(input, out n))
//    {
//        Console.WriteLine("Invalid input, please enter a valid number.");
//        continue;
//    }

//    if (n == 0)
//    {
//        break;
//    }

//    Console.Write("How many bits you want to shift left?: ");
//    input = Console.ReadLine();  // Nullable string

//    // Check for null or empty input and try parsing for shift count
//    if (string.IsNullOrEmpty(input) || !int.TryParse(input, out x))
//    {
//        Console.WriteLine("Invalid input, please enter a valid number.");
//        continue;
//    }

//    m = n << x;

//    Console.WriteLine("The number is: {0}\n", m);
//}

#endregion

#region CpBook_2, Problem: 5.3
//using System;

//int n1 = 5, n2 = 6, n3;

//n3 = n1 & n2;

//Console.WriteLine("{0} & {1} = {2}", n1, n2, n3);

#endregion

#region CpBook_2, Problem: 5.4
//using System;

//int n1 = 5, n2 = 6, n3;

//n3 = n1 | n2;

//Console.WriteLine("{0} | {1} = {2}", n1, n2, n3);

#endregion

#region CpBook_2, Problem: 5.5
//using System;

//int n1 = 5, n2 = 6, n3;

//n3 = n1 ^ n2;

//Console.WriteLine("{0} XOR {1} = {2}", n1, n2, n3);

#endregion

#region CpBook_2, Problem: 5.6
//using System;

//int n1, n2 = 1, n3;

//Console.Write("Enter the number: ");
//string? input = Console.ReadLine();  // Nullable string

// // Check if the input is null or empty before parsing
// if (string.IsNullOrEmpty(input) || !int.TryParse(input, out n1))
// {
//     Console.WriteLine("Invalid input. Please enter a valid number.");
//     return; // Exit the program or handle it as needed
// }

//n3 = n1 & n2;
//if (n3 == 1)
//{
//    Console.WriteLine("{0} is odd", n1);
//}
//else
//{
//    Console.WriteLine("{0} is even", n1);
//}

#endregion

#region CpBook_2, Problem: 5.7
//using System;

//char ToUpper(char c)
//{
//    return (char)(c & 95);  // Bitwise operation to convert to uppercase
//}

//char ToLower(char c)
//{
//    return (char)(c | 32);  // Bitwise operation to convert to lowercase
//}

//string str = "AbabidqhiHDHJDFpowkndkasd";

//for (int i = 0; i < 25; i++)
//{
//    Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ToUpper(str[i]), ToLower(str[i]));
//}

#endregion

#region CpBook_2, Problem: 5.8
//using System;

//int n;

//Console.Write("Enter a number: ");
//if (int.TryParse(Console.ReadLine(), out n))
//{
//    if (n > 0 && (n & (n - 1)) == 0)
//    {
//        Console.WriteLine("{0} is a power of 2.", n);
//    }
//    else
//    {
//        Console.WriteLine("{0} is not a power of 2.", n);
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

#endregion

#region CpBook_2, Problem: 5.9
//using System;

//int n, count = 0;

//Console.Write("Enter a number: ");
//if (int.TryParse(Console.ReadLine(), out n))
//{
//    while (n != 0)
//    {
//        if ((n & 1) == 1)
//        {
//            count++;
//        }
//        n >>= 1;
//    }

//    Console.WriteLine("Number of 1's in binary representation: {0}", count);
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

#endregion

#region CpBook_2, Problem: 5.10
//using System;

//int n = 32;
//int count = 0, num;

//Console.Write("Enter a number: ");
//if (int.TryParse(Console.ReadLine(), out num))
//{
//    for (int i = 0; i < n; i++)
//    {
//        if ((num & (1 << i)) != 0)
//        {
//            count++;
//        }
//    }

//    Console.WriteLine("Number of 1's: {0}", count);
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

#endregion

#region CpBook_2, Problem: 5.11
//using System;

//int n, m;

//Console.Write("Enter two numbers: ");
//if (int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out m))
//{
//    if ((n ^ m) != 0)
//    {
//        Console.WriteLine("Numbers are not equal");
//    }
//    else
//    {
//        Console.WriteLine("Numbers are equal");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter valid numbers.");
//}

#endregion

#region CpBook_2, Problem: 5.12
//using System;

//int[] ara = { 1, 2, 3, 4, 1, 2, 3 };
//int result = ara[0];

//for (int i = 1; i < ara.Length; i++)
//{
//    result ^= ara[i];
//}

//Console.WriteLine("The unique element is: {0}", result);

#endregion

#region CpBook_2, Problem: Page 89
//using System;

//int m, x, n;

//while (true)
//{
//    Console.Write("Enter your number (enter 0 to exit): ");
//    if (!int.TryParse(Console.ReadLine(), out n)) // Handle invalid input
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//        continue;
//    }

//    if (n == 0)
//    {
//        break;
//    }

//    Console.Write("How many bits you want to shift right?: ");
//    if (!int.TryParse(Console.ReadLine(), out x)) // Handle invalid input
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//        continue;
//    }

//    m = n >> x;

//    Console.WriteLine("The number is: {0}\n", m);
//}

#endregion

#region CpBook_2, Problem: Small to Capital Converter
//using System;

//char letter;

//Console.Write("Enter a letter to convert: ");
//letter = Console.ReadKey().KeyChar; // Reads a single character input

//if (letter >= 'A' && letter <= 'Z')
//{
//    Console.WriteLine("\nSmall letter of {0} is: {1}", letter, (char)(letter | 32));
//}
//else if (letter >= 'a' && letter <= 'z')
//{
//    Console.WriteLine("\nCapital letter of {0} is: {1}", letter, (char)(letter ^ 32));
//}
//else
//{
//    Console.WriteLine("\nInvalid letter!");
//}

#endregion
