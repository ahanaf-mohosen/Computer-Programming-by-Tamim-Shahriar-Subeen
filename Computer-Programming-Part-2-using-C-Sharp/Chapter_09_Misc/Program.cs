







#region CpBook_2, Problem: 9.1
using System;

class Program
{
    // Defining constants in C#
    const int MIN = -1;
    const double PI = 3.141592653589793;  // Directly assigning the value of PI

    static void Main()
    {
        // We can use 'n1' and 'n2' for output to avoid the "unused variable" warning
        int n1 = 10, n2 = 5;

        // Output the constants
        Console.WriteLine($"Value of MIN: {MIN}");
        Console.WriteLine($"Value of PI: {PI}");

        // Using 'n1' and 'n2' in some simple calculation
        Console.WriteLine($"Sum of n1 and n2: {n1 + n2}");
    }
}

#endregion

#region CpBook_2, Problem: 9.2
//using System;

//class Program
//{
//    const int p = 50;
//    const int q = 60;

//    static void Main()
//    {
//        int a = p;
//        int b = q;

//        Console.WriteLine($"a = {a}, b = {b}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.3
//using System;

//class Program
//{
//    // Generic method to find the maximum of two values
//    static T Max<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b) > 0 ? a : b;
//    }

//    static void Main()
//    {
//        int a = 83, b = 323;
//        double d1 = 8.32323, d2 = 3.33332323;

//        Console.WriteLine($"Maximum of {a} and {b} is {Max(a, b)}");
//        Console.WriteLine($"Maximum of {d1} and {d2} is {Max(d1, d2)}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.4
//using System;

//class Program
//{
//    // Method to swap two integers
//    static void Swap(ref int a, ref int b)
//    {
//        a ^= b;
//        b ^= a;
//        a ^= b;
//    }

//    static void Main()
//    {
//        int a = 83, b = 323;

//        Console.WriteLine($"a is: {a} and b is: {b}");

//        // Swap values
//        Swap(ref a, ref b);

//        Console.WriteLine($"a is: {a} and b is: {b}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.5
//using System;

//class Program
//{
//    // Define an enum for color
//    enum COLOR
//    {
//        RED,
//        GREEN,
//        BLUE
//    }

//    static void Main()
//    {
//        COLOR selectedColor;
//        int num = -1;  // Initialize num to a default value

//        Console.Write("Enter 1 for RED, 2 for GREEN, 3 for BLUE: ");
//        string? input = Console.ReadLine();  // Read user input

//        // Check if input is null or empty and handle accordingly
//        if (string.IsNullOrWhiteSpace(input))
//        {
//            Console.WriteLine("Input cannot be empty.");
//            return;  // Exit the program if input is null or empty
//        }

//        // Try parsing the input to an integer
//        if (!int.TryParse(input, out num) || num < 1 || num > 3)
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 3.");
//            return;  // Exit the program if the input is not a valid number or out of range
//        }

//        // Set selectedColor based on user input
//        switch (num)
//        {
//            case 1:
//                selectedColor = COLOR.RED;
//                break;
//            case 2:
//                selectedColor = COLOR.GREEN;
//                break;
//            case 3:
//                selectedColor = COLOR.BLUE;
//                break;
//            default:
//                Console.WriteLine("Invalid selection.");
//                return;
//        }

//        // Output the selected color (numeric value of the enum)
//        Console.WriteLine($"Selected Color: {selectedColor} ({(int)selectedColor})");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.6
//using System;

//class Program
//{
//    // Define an enum for color
//    enum COLOR
//    {
//        NO_COLOR,
//        RED,
//        GREEN,
//        BLUE
//    }

//    static void Main()
//    {
//        // Print the numeric values of the enum constants
//        Console.WriteLine("Value: " + (int)COLOR.NO_COLOR);
//        Console.WriteLine("Value: " + (int)COLOR.RED);
//        Console.WriteLine("Value: " + (int)COLOR.GREEN);
//        Console.WriteLine("Value: " + (int)COLOR.BLUE);
//    }
//}

#endregion

#region CpBook_2, Problem: 9.7
//using System;

//class Program
//{
//    // Define an enum for color with specific integer values
//    enum COLOR
//    {
//        NO_COLOR = 0,
//        RED = 40,
//        GREEN = 44,
//        BLUE = 60
//    }

//    static void Main()
//    {
//        // Print the numeric values of the enum constants
//        Console.WriteLine("Value: " + (int)COLOR.NO_COLOR);
//        Console.WriteLine("Value: " + (int)COLOR.RED);
//        Console.WriteLine("Value: " + (int)COLOR.GREEN);
//        Console.WriteLine("Value: " + (int)COLOR.BLUE);
//    }
//}

#endregion

#region CpBook_2, Problem: 9.8
//using System;

//class Program
//{
//    // Define an enum for the days of the week
//    enum DAY
//    {
//        SUNDAY,
//        MONDAY,
//        TUESDAY,
//        WEDNESDAY,
//        THURSDAY,
//        FRIDAY,
//        SATURDAY
//    }

//    static void Main()
//    {
//        // Initialize the current day
//        DAY today = DAY.SUNDAY;

//        // Use a switch statement to print a message based on the current day
//        switch (today)
//        {
//            case DAY.SUNDAY:
//                Console.WriteLine("Today is Sunday. It is a work day.");
//                break;

//            case DAY.MONDAY:
//                Console.WriteLine("Today is Monday. It is a work day.");
//                break;

//            case DAY.TUESDAY:
//                Console.WriteLine("Today is Tuesday. It is a work day.");
//                break;

//            case DAY.WEDNESDAY:
//                Console.WriteLine("Today is Wednesday. It is a work day.");
//                break;

//            case DAY.THURSDAY:
//                Console.WriteLine("Today is Thursday. It is a work day.");
//                break;

//            case DAY.FRIDAY:
//                Console.WriteLine("Today is Friday. It is holiday.");
//                break;

//            case DAY.SATURDAY:
//                Console.WriteLine("Today is Saturday. It is holiday.");
//                break;

//            default:
//                break;
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 9.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        int n;
//        Console.Write("Enter a positive integer (> 0): ");
//        string? input = Console.ReadLine();

//        // Check if input is not null and can be parsed to an integer
//        if (input != null && int.TryParse(input, out n))
//        {
//            // Switch statement to check the value of n
//            switch (n)
//            {
//                case 1:
//                    Console.WriteLine("One item.");
//                    break;

//                case 2:
//                    Console.WriteLine("Two items.");
//                    break;

//                default:
//                    Console.WriteLine("Many items.");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 9.10
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Ensure that two command-line arguments are passed
//        if (args.Length < 2)
//        {
//            Console.WriteLine("Please provide two integers.");
//            return;
//        }

//        int n1, n2, sum;

//        // Try to parse the command-line arguments to integers
//        if (int.TryParse(args[0], out n1) && int.TryParse(args[1], out n2))
//        {
//            sum = n1 + n2;
//            Console.WriteLine($"{n1} + {n2} = {sum}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please provide valid integers.");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 9.11
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Print the argument count
//        Console.WriteLine("Argument count: " + args.Length);

//        // Print the first argument (args[0] is the name of the program itself in C#)
//        if (args.Length > 0)
//        {
//            Console.WriteLine("First Argument: " + args[0]);
//        }
//        else
//        {
//            Console.WriteLine("No arguments provided.");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 9.12
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Check if exactly one argument is passed (besides the program name)
//        if (args.Length != 1)
//        {
//            Console.WriteLine("Please enter one argument (your name)");
//            return;
//        }

//        // Print the welcome message with the provided argument (name)
//        Console.WriteLine($"Welcome {args[0]}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.13
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 0;     // a is an integer, initialized to 0
//        int? b = null; // b is a nullable integer, initialized to null
//        int? c = null; // c is a nullable integer, initialized to null
//        int d = 0;     // d is a regular integer, initialized to 0

//        // Check if nullable types have values before accessing them
//        if (b.HasValue)
//        {
//            Console.WriteLine($"b has a value: {b.Value}");
//        }
//        else
//        {
//            Console.WriteLine("b is null");
//        }

//        if (c.HasValue)
//        {
//            Console.WriteLine($"c has a value: {c.Value}");
//        }
//        else
//        {
//            Console.WriteLine("c is null");
//        }

//        // You can safely use d because it's initialized
//        Console.WriteLine($"a: {a}, d: {d}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        int? a = null;    // a is a nullable integer
//        int? b = null;    // b is a nullable integer
//        int? c = null;    // c is a nullable integer
//        int d = 0;        // d is a regular integer

//        // Using the variables to avoid warnings
//        Console.WriteLine($"a: {a}");
//        Console.WriteLine($"b: {b}");
//        Console.WriteLine($"c: {c}");
//        Console.WriteLine($"d: {d}");

//        // Alternatively, you can add a simple operation to use them if needed.
//    }
//}

#endregion

#region CpBook_2, Problem: 9.15
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int? a = null;    // a is a nullable integer
//        int? b = null;    // b is a nullable integer (using the alias ip)
//        int? c = null;    // c is a nullable integer (using the alias ip)
//        int? d = null;    // d is a nullable integer (using the alias ip)

//        // Print the values to avoid unused variable warnings
//        Console.WriteLine($"a: {a}");
//        Console.WriteLine($"b: {b}");
//        Console.WriteLine($"c: {c}");
//        Console.WriteLine($"d: {d}");
//    }
//}

#endregion

#region CpBook_2, Problem: 9.16
//using System;

//class Program
//{
//    // Type alias equivalent in C#
//    delegate int Fp(int x);  // Delegate type for function pointers (Fp)

//    static void Main()
//    {
//        // Pointer to int is represented using nullable integers
//        int? a = 10, b = 20, c = 30;  // Assigning values to avoid unused variable warning

//        // Arrays in C# can be directly represented by arrays
//        int[] p = new int[100], q = new int[100];  // p, q are arrays of 100 integers

//        // Example use of arrays to avoid unused variable warnings
//        p[0] = a.GetValueOrDefault();
//        q[0] = b.GetValueOrDefault();

//        // Function pointers are represented by delegates in C#
//        Fp f1 = x => x * 2, f2 = x => x + 5;  // f1 and f2 are function pointers (delegates)

//        // Example usage of f1 and f2
//        Console.WriteLine($"f1(10) = {f1(10)}");  // Using f1
//        Console.WriteLine($"f2(20) = {f2(20)}");  // Using f2

//        // Print the arrays to avoid unused variable warnings
//        Console.WriteLine($"p[0]: {p[0]}, q[0]: {q[0]}");

//        // Now using 'c' to avoid unused variable warning
//        Console.WriteLine($"Value of c: {c}");
//    }
//}

#endregion

#region CpBook_2, Problem: Page 154
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int sum = 0;

//        // Loop through command-line arguments (args) starting from index 0
//        for (int i = 0; i < args.Length; i++)
//        {
//            if (int.TryParse(args[i], out int number))
//            {
//                sum += number;
//            }
//            else
//            {
//                Console.WriteLine($"Invalid input: {args[i]} is not an integer.");
//            }
//        }

//        Console.WriteLine($"Sum: {sum}");
//    }
//}

#endregion