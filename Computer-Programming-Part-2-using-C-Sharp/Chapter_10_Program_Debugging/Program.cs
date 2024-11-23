








#region CpBook_2, Problem: 10.1

// Function equivalent to 'add' in C
static int Add(int a, int b)
{
    return a * b;  // C code performs multiplication, not addition
}

int length, sum = 0, tmp;

// Taking input for the number of integers
Console.Write("Enter number of integers: ");
string? inputLength = Console.ReadLine();
if (!int.TryParse(inputLength, out length))
{
    Console.WriteLine("Invalid number of integers.");
    return; // Exit if input is invalid
}

// Loop for entering numbers and calculating sum
for (int i = 0; i < length; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    string? inputNumber = Console.ReadLine();
    if (!int.TryParse(inputNumber, out tmp))
    {
        Console.WriteLine("Invalid number entered.");
        return; // Exit if input is invalid
    }
    sum = Add(sum, tmp);
}

// Calculating and printing the average
double average = (double)sum / length;
Console.WriteLine($"The average is: {average}");
#endregion

#region CpBook_2, Problem: 10.2


// Function equivalent to 'add' in C
// static int Add(int a, int b)
// {
//     return a * b;  // C code performs multiplication, not addition
// }

// int length, sum = 0, tmp;

// // Taking input for the number of integers
// Console.Write("Enter number of integers: ");
// if (!int.TryParse(Console.ReadLine(), out length))
// {
//     Console.WriteLine("Invalid input for number of integers.");
//     return; // Exit if input is invalid
// }

// // Loop for entering numbers, displaying them, and calculating sum
// for (int i = 0; i < length; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     if (!int.TryParse(Console.ReadLine(), out tmp))
//     {
//         Console.WriteLine("Invalid input. Please enter a valid integer.");
//         return; // Exit if input is invalid
//     }
//     Console.WriteLine($"Number {i + 1}: {tmp}");
//     sum = Add(sum, tmp);
// }

// // Calculating and printing the average
// double average = (double)sum / length;
// Console.WriteLine($"The average is: {average}");
#endregion

#region CpBook_2, Problem: 10.3


// Function equivalent to 'add' in C
// static int Add(int a, int b)
// {
//     return a * b;  // C code performs multiplication, not addition
// }

// int length, sum = 0, tmp;

// // Taking input for the number of integers
// Console.Write("Enter number of integers: ");
// if (!int.TryParse(Console.ReadLine(), out length))
// {
//     Console.WriteLine("Invalid input for number of integers.");
//     return; // Exit if input is invalid
// }

// // Loop for entering numbers, calculating sum, and displaying progress
// for (int i = 0; i < length; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     if (!int.TryParse(Console.ReadLine(), out tmp))
//     {
//         Console.WriteLine("Invalid input. Please enter a valid integer.");
//         return; // Exit if input is invalid
//     }
//     sum = Add(sum, tmp);
//     Console.WriteLine($"Current number: {tmp}, current sum: {sum}");
// }

// // Calculating and printing the average
// double average = (double)sum / length;
// Console.WriteLine($"The average is: {average}");
#endregion

#region CpBook_2, Problem: 10.4


// Function equivalent to 'add' in C
// static int Add(int a, int b)
// {
//     return a + b;  // C code performs addition
// }

// int length, sum = 0, tmp;
// const bool DEBUG = true;  // Equivalent to #define DEBUG 1 in C

// // Taking input for the number of integers
// Console.Write("Enter number of integers: ");
// if (!int.TryParse(Console.ReadLine(), out length))
// {
//     Console.WriteLine("Invalid input for number of integers.");
//     return; // Exit if input is invalid
// }

// // Debug output if DEBUG is true
// if (DEBUG)
// {
//     Console.WriteLine("----");
//     Console.WriteLine("DEBUG");
//     Console.WriteLine($"\tNumber of integers: {length}");
//     Console.WriteLine("ENDDEBUG");
//     Console.WriteLine("----");
// }

// // Loop for entering numbers, calculating sum, and displaying debug info
// for (int i = 0; i < length; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     if (!int.TryParse(Console.ReadLine(), out tmp))
//     {
//         Console.WriteLine("Invalid input. Please enter a valid integer.");
//         return; // Exit if input is invalid
//     }

//     // Debug output if DEBUG is true
//     if (DEBUG)
//     {
//         Console.WriteLine("----");
//         Console.WriteLine("DEBUG");
//         Console.WriteLine($"\tNumber {i + 1}: {tmp}");
//         Console.WriteLine("ENDDEBUG");
//         Console.WriteLine("----");
//     }

//     sum = Add(sum, tmp);

//     // Debug output if DEBUG is true
//     if (DEBUG)
//     {
//         Console.WriteLine("----");
//         Console.WriteLine("DEBUG");
//         Console.WriteLine($"\tCurrent sum: {sum}");
//         Console.WriteLine("ENDDEBUG");
//         Console.WriteLine("----");
//     }
// }

// // Calculating and printing the average
// double average = (double)sum / length;
// Console.WriteLine($"The average is: {average}");
#endregion

#region CpBook_2, Problem: 10.5


// Function equivalent to 'add' in C
// static int Add(int a, int b)
// {
//     int s = a + b;
//     return s;
// }

// int length, sum = 0;

// // Taking input for the length of the array
// Console.Write("Enter the length of the array: ");
// if (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
// {
//     Console.WriteLine("Invalid input for array length.");
//     return; // Exit if input is invalid
// }

// // Declaring an array to store the integers
// int[] array = new int[length];

// // Loop for entering the elements and calculating the sum
// for (int i = 0; i < length; i++)
// {
//     Console.Write($"Enter Number {i + 1} element: ");
//     if (!int.TryParse(Console.ReadLine(), out array[i]))
//     {
//         Console.WriteLine("Invalid input. Please enter a valid integer.");
//         return; // Exit if input is invalid
//     }
//     sum = Add(sum, array[i]);
// }

// // Calculating and printing the average
// double average = (double)sum / length;
// Console.WriteLine($"The average is {average}");
#endregion
