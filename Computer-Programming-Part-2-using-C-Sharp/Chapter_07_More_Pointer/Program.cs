







#region CpBook_2, Problem: 7.1
using System;

Console.Write("Please enter the number of students: ");
int n = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty

int[] marks = new int[n];

Console.WriteLine("Please enter the mark for each student: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter mark for student {i + 1}: ");
    marks[i] = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty
}

Console.WriteLine("Now here you can see the values: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(marks[i]);
}
#endregion

#region CpBook_2, Problem: 7.2
//using System;

//Console.Write("Please enter the number of students: ");
//int n = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty

//int[] marks = new int[n];

//Console.WriteLine("Please enter the mark for each student: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Enter mark for student {i + 1}: ");
//    marks[i] = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty
//}

//Console.WriteLine("Now here you can see the values: ");
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(marks[i]);
//}
#endregion

#region CpBook_2, Problem: 7.3
//using System;

//int[][] marks = new int[5][];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Please enter the number of students in class {0}: ", i + 1);
//    int n = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty

//    marks[i] = new int[n];

//    Console.WriteLine("Please enter the mark for each student: ");
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write($"Enter mark for student {j + 1}: ");
//        marks[i][j] = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty
//    }
//}

//Console.WriteLine("Output");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Class {0}: ", i + 1);
//    for (int j = 0; j < marks[i].Length; j++)
//    {
//        Console.Write("{0,4}", marks[i][j]);
//    }
//    Console.WriteLine();
//}
#endregion

#region CpBook_2, Problem: 7.4
//using System;

//Console.Write("Enter the total number of classes: ");
//int totalClasses = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty

//int[][] marks = new int[totalClasses][];

//for (int i = 0; i < totalClasses; i++)
//{
//    Console.Write("Please enter the number of students in class {0}: ", i + 1);
//    int n = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty

//    marks[i] = new int[n];

//    Console.WriteLine("Please enter the mark for each student: ");
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write($"Enter mark for student {j + 1}: ");
//        marks[i][j] = int.Parse(Console.ReadLine() ?? "0"); // Default to 0 if input is null or empty
//    }
//}

//Console.WriteLine("Output");
//for (int i = 0; i < totalClasses; i++)
//{
//    Console.Write("Class {0}: ", i + 1);
//    for (int j = 0; j < marks[i].Length; j++)
//    {
//        Console.Write("{0,4}", marks[i][j]);
//    }
//    Console.WriteLine();
//}
#endregion

#region CpBook_2, Problem: 7.5
//using System;

//int[] ara = { 100, 300, 500, 700, 900 };

//Console.WriteLine("*ara[0]: {0}", ara[0]);
//Console.WriteLine("*ara + 1: {0}", ara[0] + 1); // This is equivalent to *p + 1 in C
//Console.WriteLine("*(ara + 1): {0}", ara[1]); // This is equivalent to *(p + 1) in C
//Console.WriteLine("*ara + 2: {0}", ara[0] + 2); // This is equivalent to *p + 2 in C
//Console.WriteLine("*(ara + 2): {0}", ara[2]); // This is equivalent to *(p + 2) in C
#endregion

#region CpBook_2, Problem: 7.6
//using System;

//string str = "Bangladesh";

//Console.WriteLine("{0}, {1}, {2}, {3}", str[0], str[1], str[2], str[3]);
//Console.WriteLine("{0}, {1}, {2}, {3}", str[0], (int)str[0] + 1, (int)str[0] + 2, (int)str[0] + 3);
#endregion

#region CpBook_2, Problem: 7.7
//using System;

//Console.WriteLine("Size of char: {0} byte", sizeof(char));
//Console.WriteLine("Size of int: {0} bytes", sizeof(int));
//Console.WriteLine("Size of double: {0} bytes", sizeof(double));

//int[] intArray = new int[10];
//Console.WriteLine("Address of intArray[0]: {0}", intArray); // This is a memory address, but not a pointer in the C sense.

// Note: While we can get the address of an array, direct pointer arithmetic is not supported.
// You can use techniques like unsafe code or reflection to access memory addresses, but it's generally not recommended.
#endregion

#region CpBook_2, Problem: 7.8
//using System;

//int n = 10;

//Console.WriteLine("Size of int: {0} bytes", sizeof(int));

// Simulating void pointer using object:
//object vp = n;
//Console.WriteLine("Value of vp: {0}", vp);
//Console.WriteLine("Content of vp: {0}", (int)vp);
#endregion

#region CpBook_2, Problem: 7.9
//using System;

//delegate int Operation(int a, int b);

//static int Add(int a, int b)
//{
//    return a + b;
//}

//static int Subtract(int a, int b)
//{
//    return a - b;
//}

//Operation operation;

//int n1 = 10, n2 = 5;

//operation = Add;
//Console.WriteLine("Result: " + operation(n1, n2));

//operation = Subtract;
//Console.WriteLine("Result: " + operation(n1, n2));
#endregion

#region CpBook_2, Problem: 7.10
//using System;

//delegate int Operation(int a, int b);

//static int Add(int a, int b)
//{
//    return a + b;
//}

//static int Subtract(int a, int b)
//{
//    return a - b;
//}

//static int Operate(Operation op, int a, int b)
//{
//    return op(a, b);
//}

//int n1 = 10, n2 = 5;

//Console.WriteLine("Result: " + Operate(Add, n1, n2));
//Console.WriteLine("Result: " + Operate(Subtract, n1, n2));
#endregion

#region CpBook_2, Problem: 7.11
//using System;

//int[] values = { 65, 6, 100, 1, 250 };

//Array.Sort(values, Compare);

//foreach (int value in values)
//{
//    Console.Write($"{value} ");
//}

//Console.WriteLine();
#endregion

#region CpBook_2, Problem: 7.12
//using System;

//int key;
//int[] values = { 1, 2, 5, 8, 10 };

//while (true)
//{
//    Console.Write("Enter the value of the key (0 to exit): ");
//    if (!int.TryParse(Console.ReadLine(), out key)) // Ensure valid integer input
//    {
//        Console.WriteLine("Invalid input. Please enter an integer.");
//        continue;
//    }

//    if (key == 0)
//    {
//        break;
//    }

//    // BinarySearch in C# is equivalent to bsearch in C
//    int index = Array.BinarySearch(values, key);

//    if (index >= 0) // If key is found, BinarySearch returns the index
//    {
//        Console.WriteLine($"Item found: {values[index]}");
//    }
//    else
//    {
//        Console.WriteLine("Item not found in the array");
//    }
//}
#endregion

#region CpBook_2, Problem: Page 136
//using System;

//int key;
//int[] values = { 65, 6, 100, 1, 250 };

//Sort the array (equivalent to qsort in C)
//Array.Sort(values);

//Console.WriteLine("Array after sorting:");
//foreach (int value in values)
//{
//    Console.Write($"{value} ");
//}
#endregion
