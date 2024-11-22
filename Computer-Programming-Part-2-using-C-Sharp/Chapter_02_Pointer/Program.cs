









#region CpBook_2, Problem: 2.1
using System;

class Program
{
    static void Main()
    {
        int x = 10;

        Console.WriteLine($"Value of x is {x}");
        // Simulating the address of x using GetHashCode, as memory address access is restricted in C#
        Console.WriteLine($"Simulated address of x is {x.GetHashCode():X}");
    }
}

#endregion

#region CpBook_2, Problem: 2.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10;
//        ref int p = ref x;  // Using 'ref' to simulate pointer behavior

//        // Simulate dereferencing by printing the value
//        Console.WriteLine($"*p = {p}");
//        // Simulate printing the "address" (it's not the actual address but the reference id)
//        Console.WriteLine($"Value of p (reference): {p.GetHashCode():X}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        double pi = 3.14159265358;

//        // Using 'ref' to simulate pointer behavior
//        ref double ptr = ref pi;

//        Console.WriteLine($"Value of pi: {pi}");
//        Console.WriteLine($"Dereferenced value of pi using ref: {ptr}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.4
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        int x = 10;
//        int* p;

//        p = &x;  // Assign the address of x to p

//        Console.WriteLine($"Value of x: {x}");

//        *p = 20;  // Dereferencing the pointer to change the value of x

//        Console.WriteLine($"Value of x after modifying via pointer: {x}");
//        Console.WriteLine($"Address of x: {(int)&x:X}");
//        Console.WriteLine($"Address of x via pointer p: {(int)p:X}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10;

//        unsafe
//        {
//            int* p = &x; // Pointer to x

//            // Printing the value of x
//            Console.WriteLine("Value of x: " + x);

//            *p = 20; // Dereferencing and changing the value of x

//            // Printing the updated value of x
//            Console.WriteLine("Value of x after changing via pointer: " + x);

//            x = 15; // Updating x directly

//            // Printing the final value of x
//            Console.WriteLine("Final value of x: " + x);
//            Console.WriteLine("Value stored at location (pointer) is: " + *p);

//            // Printing the memory address of x (using IntPtr for pointer address)
//            Console.WriteLine("Address of x: " + (IntPtr)p);
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10;
//        int y;
//        unsafe
//        {
//            int* p;

//            // Print the initial value of x
//            Console.WriteLine("Value of x: " + x);

//            p = &x; // Set p to the address of x
//            y = *p; // Dereference p to get the value of x and assign it to y
//            *p = 15; // Dereference p and change the value of x to 15

//            // Print the modified values
//            Console.WriteLine("Value of x: " + x);
//            Console.WriteLine("Value of y: " + y);
//            Console.WriteLine("Value of *p: " + *p);

//            // Print the memory addresses using IntPtr
//            Console.WriteLine("Address of x: " + (IntPtr)(&x));
//            Console.WriteLine("Address of y: " + (IntPtr)(&y));
//            Console.WriteLine("Value of p: " + (IntPtr)p);
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10, y;

//        unsafe
//        {
//            // Declare pointers p and q
//            int* p = null;
//            int* q = null;

//            // Initialize p to point to x
//            p = &x;

//            // Copy value of x through pointer p into y
//            y = *p;

//            // Change the value of x through pointer p
//            *p = 15;

//            // Initialize q to point to x
//            q = &x;

//            // Change the value of x through pointer q
//            *q = 20;

//            // Output the results
//            Console.WriteLine("Value of x: " + x);  // Expected: 20
//            Console.WriteLine("Value of y: " + y);  // Expected: 10
//            Console.WriteLine("Value of *p: " + *p); // Expected: 20
//            Console.WriteLine("Value of *q: " + *q); // Expected: 20
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.8
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        int x = 10, y;
//        int* p;  // Only p is a pointer

//        // Assign the address of x to p (pointer)
//        p = &x;

//        // Dereference p and assign its value to y
//        y = *p;

//        // Change value of x through the pointer p
//        *p = 15;

//        // Assign a value to y (no pointer needed here)
//        y = 20;

//        // Display the values
//        Console.WriteLine($"Value of x: {x}");
//        Console.WriteLine($"Value of y: {y}");
//        Console.WriteLine($"Value of *p: {*p}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.9
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        int x = 100;
//        int* p = null;

//        Console.WriteLine($"Value of x: {x}");

//        // Check if the pointer is null before dereferencing
//        if (p != null)
//        {
//            Console.WriteLine($"Value of *p: {*p}");
//        }
//        else
//        {
//            Console.WriteLine("Pointer p is null, cannot dereference.");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.10
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        int x = 100;
//        int* p = null;  // Initializing p to null

//        Console.WriteLine($"Value of x: {x}");

//        // Assigning the address of x to p
//        p = &x;

//        // Dereferencing the pointer p to access the value of x
//        Console.WriteLine($"Value of *p: {*p}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.11
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        int* p = null;

//        // Check if the pointer is null before dereferencing
//        if (p == null)
//        {
//            Console.WriteLine("Pointer p is null, cannot dereference.");
//        }
//        else
//        {
//            *p = 100; // Dereference the pointer and assign a value
//            Console.WriteLine($"Value of *p: {*p}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.12
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        string s = "Bangladesh";

//        // Print the string
//        Console.WriteLine($"Name of our country: {s}");

//        // Since strings are reference types in C#, printing the address would be different.
//        // We can simulate it with the address of the string's first character in an unsafe block.
//        fixed (char* p = s)
//        {
//            Console.WriteLine($"Address of s: {(IntPtr)p}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.13
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        string s = "Bangladesh";
//        fixed (char* p = s)
//        {
//            // Print the string using the pointer p
//            Console.WriteLine($"Name of our country: {new string(p)}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 2.14
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        char c1 = 'A', c2 = 'B', c3 = 'C';
//        char* p1, p2, p3;

//        p3 = &c3;
//        p2 = &c2;
//        p1 = &c1;

//        // Dereferencing the pointers to print the characters
//        Console.WriteLine($"{*p1}, {*p2}, {*p3}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.15
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        char c = 'A';
//        char* p;

//        p = &c;

//        // Print the address of the variable c (via pointer p)
//        Console.WriteLine($"Address of c: {(long)p}");

//        // Print the address of the pointer p itself
//        Console.WriteLine($"Address of p: {(long)&p}");
//    }
//}

#endregion

#region CpBook_2, Problem: 2.16
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        char c = 'A';
//        char* p = &c; // p points to c
//        char** q = &p; // q is a pointer to p (pointer-to-pointer)

//        // Print the value of c using direct access, pointer, and pointer to pointer
//        Console.WriteLine($"Value of c: {c}");         // Direct access
//        Console.WriteLine($"Value of c (via *p): {*p}"); // Dereference p
//        Console.WriteLine($"Value of c (via **q): {**q}"); // Dereference q twice (pointer-to-pointer)
//    }
//}

#endregion

#region CpBook_2, Problem: 2.17
//using System;

//class Program
//{
//    static unsafe void Main()
//    {
//        char c = 'A';  // Declare a character
//        char* p, q;    // Declare pointer p, and pointer q

//        p = &c;         // p points to c
//        q = p;          // q also points to p, essentially it's a pointer-to-pointer.

//        // Dereference q twice to change the value of c to 'B'
//        *p = 'B';  // Or alternatively: **&q = 'B';

//        // Print the value of c via different dereference methods
//        Console.WriteLine($"Value of c: {c}");  // Should print 'B'
//        Console.WriteLine($"Value of c via *p: {*p}");  // Should print 'B'
//        Console.WriteLine($"Value of c via **q: {*p}");  // Should print 'B'
//    }
//}

#endregion