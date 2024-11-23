







#region CpBook_2, Problem: 9.1
using System;

const int MIN = -1;
const double PI = 3.141592653589793;  // Directly assigning the value of PI

// We can use 'n1' and 'n2' for output to avoid the "unused variable" warning
int n1 = 10, n2 = 5;

// Output the constants
Console.WriteLine($"Value of MIN: {MIN}");
Console.WriteLine($"Value of PI: {PI}");

// Using 'n1' and 'n2' in some simple calculation
Console.WriteLine($"Sum of n1 and n2: {n1 + n2}");

#endregion

#region CpBook_2, Problem: 9.2
//using System;

//const int p = 50;
//const int q = 60;

//int a = p;
//int b = q;

//Console.WriteLine($"a = {a}, b = {b}");

#endregion

#region CpBook_2, Problem: 9.3
//using System;

//static T Max<T>(T a, T b) where T : IComparable<T>
//{
//    return a.CompareTo(b) > 0 ? a : b;
//}

//int a = 83, b = 323;
//double d1 = 8.32323, d2 = 3.33332323;

//Console.WriteLine($"Maximum of {a} and {b} is {Max(a, b)}");
//Console.WriteLine($"Maximum of {d1} and {d2} is {Max(d1, d2)}");

#endregion

#region CpBook_2, Problem: 9.4
//using System;

//static void Swap(ref int a, ref int b)
//{
//    a ^= b;
//    b ^= a;
//    a ^= b;
//}

//int a = 83, b = 323;

//Console.WriteLine($"a is: {a} and b is: {b}");

//Swap(ref a, ref b);

//Console.WriteLine($"a is: {a} and b is: {b}");

#endregion

#region CpBook_2, Problem: 9.5
//using System;

//enum COLOR
//{
//    RED,
//    GREEN,
//    BLUE
//}

//COLOR selectedColor;
//int num = -1;

//Console.Write("Enter 1 for RED, 2 for GREEN, 3 for BLUE: ");
//string? input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Input cannot be empty.");
//    return;
//}

//if (!int.TryParse(input, out num) || num < 1 || num > 3)
//{
//    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 3.");
//    return;
//}

//switch (num)
//{
//    case 1:
//        selectedColor = COLOR.RED;
//        break;
//    case 2:
//        selectedColor = COLOR.GREEN;
//        break;
//    case 3:
//        selectedColor = COLOR.BLUE;
//        break;
//    default:
//        Console.WriteLine("Invalid selection.");
//        return;
//}

//Console.WriteLine($"Selected Color: {selectedColor} ({(int)selectedColor})");

#endregion

#region CpBook_2, Problem: 9.6
//using System;

//enum COLOR
//{
//    NO_COLOR,
//    RED,
//    GREEN,
//    BLUE
//}

//Console.WriteLine("Value: " + (int)COLOR.NO_COLOR);
//Console.WriteLine("Value: " + (int)COLOR.RED);
//Console.WriteLine("Value: " + (int)COLOR.GREEN);
//Console.WriteLine("Value: " + (int)COLOR.BLUE);

#endregion

#region CpBook_2, Problem: 9.7
//using System;

//enum COLOR
//{
//    NO_COLOR = 0,
//    RED = 40,
//    GREEN = 44,
//    BLUE = 60
//}

//Console.WriteLine("Value: " + (int)COLOR.NO_COLOR);
//Console.WriteLine("Value: " + (int)COLOR.RED);
//Console.WriteLine("Value: " + (int)COLOR.GREEN);
//Console.WriteLine("Value: " + (int)COLOR.BLUE);

#endregion

#region CpBook_2, Problem: 9.8
//using System;

//enum DAY
//{
//    SUNDAY,
//    MONDAY,
//    TUESDAY,
//    WEDNESDAY,
//    THURSDAY,
//    FRIDAY,
//    SATURDAY
//}

//DAY today = DAY.SUNDAY;

//switch (today)
//{
//    case DAY.SUNDAY:
//        Console.WriteLine("Today is Sunday. It is a work day.");
//        break;
//    case DAY.MONDAY:
//        Console.WriteLine("Today is Monday. It is a work day.");
//        break;
//    case DAY.TUESDAY:
//        Console.WriteLine("Today is Tuesday. It is a work day.");
//        break;
//    case DAY.WEDNESDAY:
//        Console.WriteLine("Today is Wednesday. It is a work day.");
//        break;
//    case DAY.THURSDAY:
//        Console.WriteLine("Today is Thursday. It is a work day.");
//        break;
//    case DAY.FRIDAY:
//        Console.WriteLine("Today is Friday. It is holiday.");
//        break;
//    case DAY.SATURDAY:
//        Console.WriteLine("Today is Saturday. It is holiday.");
//        break;
//    default:
//        break;
//}

#endregion

#region CpBook_2, Problem: 9.9
//using System;

//int n;
//Console.Write("Enter a positive integer (> 0): ");
//string? input = Console.ReadLine();

//if (input != null && int.TryParse(input, out n))
//{
//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("One item.");
//            break;
//        case 2:
//            Console.WriteLine("Two items.");
//            break;
//        default:
//            Console.WriteLine("Many items.");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid integer.");
//}

#endregion

#region CpBook_2, Problem: 9.10
//using System;

//if (args.Length < 2)
//{
//    Console.WriteLine("Please provide two integers.");
//    return;
//}

//int n1, n2, sum;

//if (int.TryParse(args[0], out n1) && int.TryParse(args[1], out n2))
//{
//    sum = n1 + n2;
//    Console.WriteLine($"{n1} + {n2} = {sum}");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please provide valid integers.");
//}

#endregion

#region CpBook_2, Problem: 9.11
//using System;

//Console.WriteLine("Argument count: " + args.Length);

//if (args.Length > 0)
//{
//    Console.WriteLine("First Argument: " + args[0]);
//}
//else
//{
//    Console.WriteLine("No arguments provided.");
//}

#endregion

#region CpBook_2, Problem: 9.12
//using System;

//if (args.Length != 1)
//{
//    Console.WriteLine("Please enter one argument (your name)");
//    return;
//}

//Console.WriteLine($"Welcome {args[0]}");

#endregion

#region CpBook_2, Problem: 9.13
//using System;

//int a = 0;
//int? b = null;
//int? c = null;
//int d = 0;

//if (b.HasValue)
//{
//    Console.WriteLine($"b has a value: {b.Value}");
//}
//else
//{
//    Console.WriteLine("b is null");
//}

//if (c.HasValue)
//{
//    Console.WriteLine($"c has a value: {c.Value}");
//}
//else
//{
//    Console.WriteLine("c is null");
//}

//Console.WriteLine($"a: {a}, d: {d}");

#endregion

#region CpBook_2, Problem: 9.14
//using System;

//int? a = null;
//int? b = null;
//int? c = null;
//int d = 0;

//Console.WriteLine($"a: {a}");
//Console.WriteLine($"b: {b}");
//Console.WriteLine($"c: {c}");
//Console.WriteLine($"d: {d}");

#endregion

#region CpBook_2, Problem: 9.15
//using System;

//int? a = null;
//int? b = null;
//int? c = null;
//int? d = null;

//Console.WriteLine($"a: {a}");
//Console.WriteLine($"b: {b}");
//Console.WriteLine($"c: {c}");
//Console.WriteLine($"d: {d}");

#endregion

#region CpBook_2, Problem: 9.16
//using System;

//delegate int Fp(int x);

//int? a = 10, b = 20, c = 30;

//int[] p = new int[100], q = new int[100];

//p[0] = a.GetValueOrDefault();
//q[0] = b.GetValueOrDefault();

//Fp f1 = x => x * 2, f2 = x => x + 5;

//Console.WriteLine($"f1(10) = {f1(10)}");
//Console.WriteLine($"f2(20) = {f2(20)}");

//Console.WriteLine($"p[0]: {p[0]}, q[0]: {q[0]}");

//Console.WriteLine($"Value of c: {c}");

#endregion

#region CpBook_2, Problem: Page 154
//using System;

//int sum = 0;

//for (int i = 0; i < args.Length; i++)
//{
//    if (int.TryParse(args[i], out int num))
//    {
//        sum += num;
//    }
//    else
//    {
//        Console.WriteLine($"'{args[i]}' is not a valid number.");
//    }
//}

//Console.WriteLine($"Total sum: {sum}");

#endregion
