









#region CpBook_2, Problem: 2.1
using System;

int x = 10;

Console.WriteLine($"Value of x is {x}");
// Simulating the address of x using GetHashCode, as memory address access is restricted in C#
Console.WriteLine($"Simulated address of x is {x.GetHashCode():X}");

#endregion

#region CpBook_2, Problem: 2.2
//using System;

//int x = 10;
//ref int p = ref x;  // Using 'ref' to simulate pointer behavior

//Console.WriteLine($"*p = {p}");
//Console.WriteLine($"Value of p (reference): {p.GetHashCode():X}");

#endregion

#region CpBook_2, Problem: 2.3
//using System;

//double pi = 3.14159265358;
//ref double ptr = ref pi;

//Console.WriteLine($"Value of pi: {pi}");
//Console.WriteLine($"Dereferenced value of pi using ref: {ptr}");

#endregion

#region CpBook_2, Problem: 2.4
//using System;

//int x = 10;
//int* p;

//p = &x;  // Assign the address of x to p

//Console.WriteLine($"Value of x: {x}");

//*p = 20;  // Dereferencing the pointer to change the value of x

//Console.WriteLine($"Value of x after modifying via pointer: {x}");
//Console.WriteLine($"Address of x: {(int)&x:X}");
//Console.WriteLine($"Address of x via pointer p: {(int)p:X}");

#endregion

#region CpBook_2, Problem: 2.5
//using System;

//int x = 10;

//unsafe
//{
//    int* p = &x; // Pointer to x

//    Console.WriteLine("Value of x: " + x);

//    *p = 20; // Dereferencing and changing the value of x

//    Console.WriteLine("Value of x after changing via pointer: " + x);

//    x = 15; // Updating x directly

//    Console.WriteLine("Final value of x: " + x);
//    Console.WriteLine("Value stored at location (pointer) is: " + *p);

//    Console.WriteLine("Address of x: " + (IntPtr)p);
//}

#endregion

#region CpBook_2, Problem: 2.6
//using System;

//int x = 10;
//int y;
//unsafe
//{
//    int* p;

//    Console.WriteLine("Value of x: " + x);

//    p = &x; // Set p to the address of x
//    y = *p; // Dereference p to get the value of x and assign it to y
//    *p = 15; // Dereference p and change the value of x to 15

//    Console.WriteLine("Value of x: " + x);
//    Console.WriteLine("Value of y: " + y);
//    Console.WriteLine("Value of *p: " + *p);

//    Console.WriteLine("Address of x: " + (IntPtr)(&x));
//    Console.WriteLine("Address of y: " + (IntPtr)(&y));
//    Console.WriteLine("Value of p: " + (IntPtr)p);
//}

#endregion

#region CpBook_2, Problem: 2.7
//using System;

//int x = 10, y;

//unsafe
//{
//    int* p = null;
//    int* q = null;

//    p = &x;
//    y = *p;

//    *p = 15;
//    q = &x;

//    *q = 20;

//    Console.WriteLine("Value of x: " + x);  // Expected: 20
//    Console.WriteLine("Value of y: " + y);  // Expected: 10
//    Console.WriteLine("Value of *p: " + *p); // Expected: 20
//    Console.WriteLine("Value of *q: " + *q); // Expected: 20
//}

#endregion

#region CpBook_2, Problem: 2.8
//using System;

//int x = 10, y;
//int* p;

//p = &x;

//y = *p;

//*p = 15;

//y = 20;

//Console.WriteLine($"Value of x: {x}");
//Console.WriteLine($"Value of y: {y}");
//Console.WriteLine($"Value of *p: {*p}");

#endregion

#region CpBook_2, Problem: 2.9
//using System;

//int x = 100;
//int* p = null;

//Console.WriteLine($"Value of x: {x}");

//if (p != null)
//{
//    Console.WriteLine($"Value of *p: {*p}");
//}
//else
//{
//    Console.WriteLine("Pointer p is null, cannot dereference.");
//}

#endregion

#region CpBook_2, Problem: 2.10
//using System;

//int x = 100;
//int* p = null;

//Console.WriteLine($"Value of x: {x}");

//p = &x;

//Console.WriteLine($"Value of *p: {*p}");

#endregion

#region CpBook_2, Problem: 2.11
//using System;

//int* p = null;

//if (p == null)
//{
//    Console.WriteLine("Pointer p is null, cannot dereference.");
//}
//else
//{
//    *p = 100;
//    Console.WriteLine($"Value of *p: {*p}");
//}

#endregion

#region CpBook_2, Problem: 2.12
//using System;

//string s = "Bangladesh";

//Console.WriteLine($"Name of our country: {s}");

//fixed (char* p = s)
//{
//    Console.WriteLine($"Address of s: {(IntPtr)p}");
//}

#endregion

#region CpBook_2, Problem: 2.13
//using System;

//string s = "Bangladesh";
//fixed (char* p = s)
//{
//    Console.WriteLine($"Name of our country: {new string(p)}");
//}

#endregion

#region CpBook_2, Problem: 2.14
//using System;

//char c1 = 'A', c2 = 'B', c3 = 'C';
//char* p1, p2, p3;

//p3 = &c3;
//p2 = &c2;
//p1 = &c1;

//Console.WriteLine($"{*p1}, {*p2}, {*p3}");

#endregion

#region CpBook_2, Problem: 2.15
//using System;

//char c = 'A';
//char* p;

//p = &c;

//Console.WriteLine($"Address of c: {(long)p}");

//Console.WriteLine($"Address of p: {(long)&p}");

#endregion

#region CpBook_2, Problem: 2.16
//using System;

//char c = 'A';
//char* p = &c;
//char** q = &p;

//Console.WriteLine($"Value of c: {c}");
//Console.WriteLine($"Value of c (via *p): {*p}");
//Console.WriteLine($"Value of c (via **q): {**q}");

#endregion

#region CpBook_2, Problem: 2.17
//using System;

//char c = 'A';  
//char* p, q;    

//p = &c;         
//q = p;          

//*p = 'B';  

//Console.WriteLine($"Value of c: {c}");
//Console.WriteLine($"Value of c via *p: {*p}");
//Console.WriteLine($"Value of c via **q: {*p}");

#endregion
