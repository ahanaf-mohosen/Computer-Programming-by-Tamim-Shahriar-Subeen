










#region CpBook_2, Problem: 4.1
using System;

int x; // Automatically initialized to 0

int y = 0; // Initialize y explicitly

Console.WriteLine($"x = {x}, y = {y}");

#endregion

#region CpBook_2, Problem: 4.2
//using System;

//int x = 1; // Global variable equivalent

//void MyFunction(int y)
//{
//    y = y * 2;
//    x = x + 10; // Modify the global variable
//    Console.WriteLine($"MyFunction, x = {x}, y = {y}");
//}

//int y = 5; // Local variable

//x = 10; // Modify the global variable

//MyFunction(y); // Call the function, passing the local variable y

//Console.WriteLine($"Main, x = {x}, y = {y}");

#endregion

#region CpBook_2, Problem: 4.3
//int a; // Global variable equivalent
//int b; // Static variable equivalent

//void Func()
//{
//    a = a + 1; // Increment global variable
//    b = b + 1; // Increment static variable
//}

//Func();
//Console.WriteLine($"a = {a}"); // Print global variable
//Console.WriteLine($"b = {b}"); // Print static variable

#endregion

#region CpBook_2, Problem: 4.4
//int s = 10; // Static field at the class level (outside any method)

//void Func()
//{
//    int a = 10; // Regular local variable, reinitialized each time the function is called

//    a = a + 2;
//    s = s + 2;

//    Console.WriteLine($"a = {a}, s = {s}");
//}

//Func(); // First call
//Func(); // Second call
//Func(); // Third call

#endregion

#region CpBook_2, Problem: 4.5
//void Recurse()
//{
//    string s = "Hurrey, I am learning recursion!";
//    Console.WriteLine(s);
//    Recurse(); // Recursive call without a stopping condition
//}

//try
//{
//    Recurse(); // Start recursion
//}
//catch (StackOverflowException)
//{
//    Console.WriteLine("Stack overflow occurred due to infinite recursion.");
//}

#endregion

#region CpBook_2, Problem: 4.6
//void Recurse(int count)
//{
//    if (count == 5)
//    {
//        return; // Stop recursion when count reaches 5
//    }

//    Console.WriteLine("I am learning recursion.");
//    Recurse(count + 1); // Recursive call with incremented count
//}

//Recurse(1); // Start recursion with initial count value 1

#endregion

#region CpBook_2, Problem: 4.7
//void Recurse(int count)
//{
//    if (count > 5)
//    {
//        return; // Stop recursion when count is greater than 5
//    }

//    Console.WriteLine($"Count = {count}");
//    Recurse(count + 1); // Recursive call with incremented count
//}

//Recurse(1); // Start recursion with initial count value 1

#endregion

#region CpBook_2, Problem: 4.8
//void Recurse(int count)
//{
//    if (count > 5)
//    {
//        return; // Stop recursion when count exceeds 5
//    }

//    Recurse(count + 1); // Recursive call first
//    Console.WriteLine($"Count = {count}"); // Print count as recursion unwinds
//}

//Recurse(1); // Start recursion with count 1

#endregion

#region CpBook_2, Problem: 4.9
//void Recurse(int count)
//{
//    if (count > 5)
//    {
//        return; // Stop recursion when count exceeds 5
//    }

//    Console.WriteLine($"count = {count}"); // Print count before the recursive call
//    Recurse(count + 1); // Recursive call
//    Console.WriteLine($"Count = {count}"); // Print count after the recursive call
//}

//Recurse(1); // Start recursion with count 1

#endregion

#region CpBook_2, Problem: 4.10
//int count = 1; // Static field at the class level to retain the count value across recursive calls

//void Recurse()
//{
//    if (count > 5)
//    {
//        return; // Stop recursion when count exceeds 5
//    }

//    Console.WriteLine($"Count = {count}"); // Print the current count
//    count = count + 1; // Increment count
//    Recurse(); // Recursive call
//}

//Recurse(); // Start the recursion

#endregion

#region CpBook_2, Problem: 4.11
//int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    else
//        return n * Factorial(n - 1);
//}

//int n;
//Console.Write("Enter a number: ");
//if (int.TryParse(Console.ReadLine(), out n))
//{
//    if (n < 0)
//    {
//        Console.WriteLine("Factorial is not defined for negative numbers.");
//    }
//    else
//    {
//        Console.WriteLine($"Factorial of {n} is {Factorial(n)}");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input! Please enter a valid integer.");
//}

#endregion

#region CpBook_2, Problem: 4.12
//int f_calls = 0; // Variable to track the number of function calls

//int Factorial(int n)
//{
//    f_calls++; // Increment function call count
//    if (n == 0)
//        return 1; // Base case
//    return n * Factorial(n - 1); // Recursive case
//}

//Console.Write("Enter a number: ");
//if (int.TryParse(Console.ReadLine(), out int num)) // Input validation
//{
//    if (num < 0)
//    {
//        Console.WriteLine("Error: Factorial is not defined for negative numbers.");
//    }
//    else
//    {
//        Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");
//        Console.WriteLine($"Number of function calls: {f_calls}");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input! Please enter a valid integer.");
//}

#endregion

#region CpBook_2, Problem: 4.13
//int Fibonacci(int n)
//{
//    f_calls++; // Increment function call count
//    if (n == 1 || n == 2)
//        return 1; // Base case
//    return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive case
//}

//int n;
//string suffix;

//Console.Write("Enter a positive integer: ");
//if (int.TryParse(Console.ReadLine(), out n)) // Input validation
//{
//    if (n == 1)
//    {
//        suffix = "st";
//    }
//    else if (n == 2)
//    {
//        suffix = "nd";
//    }
//    else if (n == 3)
//    {
//        suffix = "rd";
//    }
//    else
//    {
//        suffix = "th";
//    }

//    Console.WriteLine($"The {n}{suffix} Fibonacci number is: {Fibonacci(n)}");
//    Console.WriteLine($"Number of function calls: {f_calls}");
//}
//else
//{
//    Console.WriteLine("Invalid input! Please enter a valid integer.");
//}

#endregion

#region CpBook_2, Problem: 4.14
//int f_calls = 0;
//int[] fibo = new int[51]; // Array to store Fibonacci numbers

//int Fibonacci(int n)
//{
//    f_calls++; // Increment function call counter
//    if (fibo[n] != 0)
//    {
//        return fibo[n]; // Return cached result if available
//    }
//    if (n == 1 || n == 2)
//    {
//        return 1; // Base cases for Fibonacci
//    }
//    fibo[n] = Fibonacci(n - 1) + Fibonacci(n - 2); // Store the result in the array
//    return fibo[n]; // Return the calculated Fibonacci number
//}

//fibo[1] = 1; // Set the base Fibonacci values
//fibo[2] = 1;

//int n;
//string suffix;

//Console.Write("Enter a positive integer (less than or equal to 50): ");
//if (int.TryParse(Console.ReadLine(), out n) && n <= 50)
//{
//    // Determine the ordinal suffix
//    if (n == 1)
//    {
//        suffix = "st";
//    }
//    else if (n == 2)
//    {
//        suffix = "nd";
//    }
//    else if (n == 3)
//    {
//        suffix = "rd";
//    }
//    else
//    {
//        suffix = "th";
//    }

//    // Display the result for the nth Fibonacci number
//    Console.WriteLine($"The {n}{suffix} Fibonacci number is: {Fibonacci(n)}");
//    Console.WriteLine($"Number of function calls: {f_calls}");

//    // Print the first 11 Fibonacci numbers
//    for (int i = 1; i <= 11; i++)
//    {
//        Console.WriteLine($"{i}: {fibo[i]}");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input! Please enter a positive integer less than or equal to 50.");
//}

#endregion
