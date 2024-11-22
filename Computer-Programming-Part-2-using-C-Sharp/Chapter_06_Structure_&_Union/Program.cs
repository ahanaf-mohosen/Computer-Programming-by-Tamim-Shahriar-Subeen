








#region CpBook_2, Problem: 6.1
using System;

class Program
{
    struct Student
    {
        public int Id;
        public string Name;
    }

    static void Main()
    {
        Student one;

        one.Id = 1;
        one.Name = "Tahmid Rafi";

        Console.WriteLine("ID: {0}", one.Id);
        Console.WriteLine("Name: {0}", one.Name);
    }
}

#endregion

#region CpBook_2, Problem: 6.2
//using System;

//class Program
//{
//    struct Student
//    {
//        public int Id;
//        public string Name;
//    }

//    static void Main()
//    {
//        Student one;

//        one.Id = 1;
//        one.Name = "Tahmid Rafi";

//        Console.WriteLine("ID: {0}", one.Id);
//        Console.WriteLine("Name: {0}", one.Name);
//    }
//}

#endregion

#region CpBook_2, Problem: 6.3
//using System;

//class Program
//{
//    struct Student
//    {
//        public int Id;
//        public string Name;
//    }

//    static void Main()
//    {
//        Student one;

//        one.Id = 1;
//        one.Name = "Tahmid Rafi"; // Direct string assignment in C#

//        Console.WriteLine("ID: {0}", one.Id);
//        Console.WriteLine("Name: {0}", one.Name);
//    }
//}

#endregion

#region CpBook_2, Problem: 6.4
//using System;

//class Program
//{
//    struct Student
//    {
//        public int Id;
//        public string Name;
//    }

//    static void Main()
//    {
//        Student one;

//        // Input for ID with null-check
//        Console.Write("Enter ID: ");
//        string? inputId = Console.ReadLine();
//        if (string.IsNullOrEmpty(inputId) || !int.TryParse(inputId, out one.Id))
//        {
//            Console.WriteLine("Invalid ID. Please enter a valid integer.");
//            return;
//        }

//        // Input for Name with null-check
//        Console.Write("Enter Name: ");
//        one.Name = Console.ReadLine() ?? string.Empty;

//        // Output
//        Console.WriteLine("ID: {0}", one.Id);
//        Console.WriteLine("Name: {0}", one.Name);
//    }
//}

#endregion

#region CpBook_2, Problem: 6.5
//using System;

//class Program
//{
//    struct NameType
//    {
//        public string First;
//        public string Last;
//    }

//    struct Student
//    {
//        public int Id;
//        public NameType Name;
//    }

//    static void Main()
//    {
//        Student one;

//        // Input for ID with validation
//        Console.Write("Enter ID: ");
//        string? inputId = Console.ReadLine();
//        if (string.IsNullOrEmpty(inputId) || !int.TryParse(inputId, out one.Id))
//        {
//            Console.WriteLine("Invalid ID. Please enter a valid integer.");
//            return;
//        }

//        // Input for First Name
//        Console.Write("Enter First Name: ");
//        one.Name.First = Console.ReadLine() ?? string.Empty;

//        // Input for Last Name
//        Console.Write("Enter Last Name: ");
//        one.Name.Last = Console.ReadLine() ?? string.Empty;

//        // Output
//        Console.WriteLine("ID: {0}", one.Id);
//        Console.WriteLine("Name: {0} {1}", one.Name.First, one.Name.Last);
//    }
//}

#endregion

#region CpBook_2, Problem: 6.6
//using System;

//class Program
//{
//    struct NameType
//    {
//        public string First;
//        public string Last;
//    }

//    struct StudentType
//    {
//        public int Id;
//        public NameType Name;
//    }

//    static void Main()
//    {
//        const int n = 5;
//        StudentType[] students = new StudentType[n];

//        // Input loop
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Enter the details for student {i + 1}:");

//            // Input for ID with validation
//            Console.Write("Enter ID: ");
//            string? inputId = Console.ReadLine();
//            if (string.IsNullOrEmpty(inputId) || !int.TryParse(inputId, out students[i].Id))
//            {
//                Console.WriteLine("Invalid ID. Please enter a valid integer.");
//                i--; // Retry the current iteration
//                continue;
//            }

//            // Input for First Name
//            Console.Write("Enter First Name: ");
//            students[i].Name.First = Console.ReadLine() ?? string.Empty;

//            // Input for Last Name
//            Console.Write("Enter Last Name: ");
//            students[i].Name.Last = Console.ReadLine() ?? string.Empty;

//            Console.WriteLine();
//        }

//        // Output loop
//        Console.WriteLine("Output:\n");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"ID: {students[i].Id}");
//            Console.WriteLine($"Name: {students[i].Name.First} {students[i].Name.Last}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 6.7
//using System;

//class Program
//{
//    struct NameType
//    {
//        public string First;
//        public string Last;
//    }

//    struct StudentType
//    {
//        public int Id;
//        public NameType Name;
//        public string Grade;
//    }

//    static void CalculateGrade(ref StudentType student, int mark)
//    {
//        if (mark >= 80)
//        {
//            student.Grade = "A+";
//        }
//        else if (mark >= 70)
//        {
//            student.Grade = "A";
//        }
//        else if (mark >= 60)
//        {
//            student.Grade = "A-";
//        }
//        else if (mark >= 50)
//        {
//            student.Grade = "B";
//        }
//        else if (mark >= 40)
//        {
//            student.Grade = "C";
//        }
//        else
//        {
//            student.Grade = "F";
//        }
//    }

//    static void Main()
//    {
//        const int n = 3;
//        StudentType[] students = new StudentType[n];
//        int[] marks = { 72, 80, 60 };

//        // Input loop
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Enter the details for student {i + 1}:");

//            // Input for ID
//            Console.Write("Enter ID: ");
//            string? inputId = Console.ReadLine();
//            if (string.IsNullOrEmpty(inputId) || !int.TryParse(inputId, out students[i].Id))
//            {
//                Console.WriteLine("Invalid ID. Please enter a valid integer.");
//                i--; // Retry current iteration
//                continue;
//            }

//            // Input for First Name
//            Console.Write("Enter First Name: ");
//            students[i].Name.First = Console.ReadLine() ?? string.Empty;

//            // Input for Last Name
//            Console.Write("Enter Last Name: ");
//            students[i].Name.Last = Console.ReadLine() ?? string.Empty;

//            // Initialize Grade
//            students[i].Grade = string.Empty;

//            Console.WriteLine();
//        }

//        // Grade calculation loop
//        for (int i = 0; i < n; i++)
//        {
//            CalculateGrade(ref students[i], marks[i]);
//        }

//        // Output loop
//        Console.WriteLine("Output:\n");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"ID: {students[i].Id}");
//            Console.WriteLine($"Name: {students[i].Name.First} {students[i].Name.Last}");
//            Console.WriteLine($"Grade: {students[i].Grade}\n");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 6.8
//using System;

//class Program
//{
//    // Pass by value (like `plus_ten1`)
//    static void PlusTen1(int a)
//    {
//        a = a + 10;
//    }

//    // Pass by reference (like `plus_ten2`)
//    static void PlusTen2(ref int a)
//    {
//        a = a + 10;
//    }

//    static void Main()
//    {
//        int a = 5;

//        // Call PlusTen1 (value passed by copy)
//        PlusTen1(a);
//        Console.WriteLine($"a: {a}"); // No change in `a`

//        // Call PlusTen2 (value passed by reference)
//        PlusTen2(ref a);
//        Console.WriteLine($"a: {a}"); // `a` is modified
//    }
//}

#endregion

#region CpBook_2, Problem: 6.9
//using System;

//class Program
//{
//    struct NameType
//    {
//        public string First;
//        public string Last;
//    }

//    struct StudentType
//    {
//        public int Id;
//        public NameType Name;
//        public string Grade;
//    }

//    static void CalculateGrade(ref StudentType student, int mark)
//    {
//        if (mark >= 80)
//        {
//            student.Grade = "A+";
//        }
//        else if (mark >= 70)
//        {
//            student.Grade = "A";
//        }
//        else if (mark >= 60)
//        {
//            student.Grade = "A-";
//        }
//        else if (mark >= 50)
//        {
//            student.Grade = "B";
//        }
//        else if (mark >= 40)
//        {
//            student.Grade = "C";
//        }
//        else
//        {
//            student.Grade = "F";
//        }
//    }

//    static void Main()
//    {
//        const int n = 3;
//        StudentType[] students = new StudentType[n];
//        int[] marks = { 72, 80, 60 };

//        // Input loop
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Enter the details for student {i + 1}:");

//            // Input for ID
//            Console.Write("Enter ID: ");
//            string? inputId = Console.ReadLine();
//            if (string.IsNullOrEmpty(inputId) || !int.TryParse(inputId, out students[i].Id))
//            {
//                Console.WriteLine("Invalid ID. Please enter a valid integer.");
//                i--; // Retry the current iteration
//                continue;
//            }

//            // Input for First Name
//            Console.Write("Enter First Name: ");
//            students[i].Name.First = Console.ReadLine() ?? string.Empty;

//            // Input for Last Name
//            Console.Write("Enter Last Name: ");
//            students[i].Name.Last = Console.ReadLine() ?? string.Empty;

//            // Initialize Grade
//            students[i].Grade = string.Empty;

//            Console.WriteLine();
//        }

//        // Grade calculation loop
//        for (int i = 0; i < n; i++)
//        {
//            CalculateGrade(ref students[i], marks[i]);
//        }

//        // Output loop
//        Console.WriteLine("Output:\n");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"ID: {students[i].Id}");
//            Console.WriteLine($"Name: {students[i].Name.First} {students[i].Name.Last}");
//            Console.WriteLine($"Grade: {students[i].Grade}\n");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 6.10

//using System;

//class Program
//{
//    // Define a struct that mimics the C structure
//    struct S
//    {
//        public char Ch;
//        public int N;
//        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
//        public char[] Str;
//    }

//    // Define a union using a struct in C#
//    // Note: C# does not have direct support for unions, but we can mimic one by using explicit layouts.
//    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
//    struct U
//    {
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        public char Ch;
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        public int N;
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
//        public char[] Str;
//    }

//    static void Main()
//    {
//        // Create instances of the struct and union
//        S sv = new S { Str = new char[16] };
//        U uv = new U { Str = new char[16] };

//        // Get the size of the struct and union
//        int structSize = System.Runtime.InteropServices.Marshal.SizeOf(sv);
//        int unionSize = System.Runtime.InteropServices.Marshal.SizeOf(uv);

//        // Print the sizes
//        Console.WriteLine($"Size of struct S: {structSize} bytes");
//        Console.WriteLine($"Size of union U: {unionSize} bytes");
//    }
//}

#endregion

#region CpBook_2, Problem: 6.11
//using System;

//class Program
//{
//    // Mimicking a union in C# using explicit layout and field offsets
//    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
//    struct U
//    {
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        public char Ch;
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        public int X;
//        [System.Runtime.InteropServices.FieldOffset(0)]
//        public int Y;
//    }

//    static void Main()
//    {
//        // Create an instance of the union
//        U uv = new U();

//        // Set and print the value of 'ch'
//        uv.Ch = 'A';
//        Console.WriteLine($"uv.Ch = {uv.Ch}");

//        // Set and print the value of 'x'
//        uv.X = 17;
//        Console.WriteLine($"uv.X = {uv.X}");
//        Console.WriteLine($"uv.Ch = {uv.Ch}");

//        // Set and print the value of 'y'
//        uv.Y = 18;
//        Console.WriteLine($"uv.Y = {uv.Y}");

//        // Print the value of 'ch' and 'x' again, demonstrating shared memory
//        Console.WriteLine($"uv.Ch = {uv.Ch}");
//        Console.WriteLine($"uv.X = {uv.X}");
//    }
//}

#endregion

#region CpBook_2, Problem: 6.12
//using System;

//class Program
//{
//    struct S1
//    {
//        public int n;
//        public double d;
//        public char c;
//    }

//    struct S2
//    {
//        public char c;
//        public int n;
//        public double d;
//    }

//    static void Main()
//    {
//        // Display the size of primitive types
//        Console.WriteLine($"char size: {System.Runtime.InteropServices.Marshal.SizeOf(typeof(char))} bytes");
//        Console.WriteLine($"int size: {System.Runtime.InteropServices.Marshal.SizeOf(typeof(int))} bytes");
//        Console.WriteLine($"double size: {System.Runtime.InteropServices.Marshal.SizeOf(typeof(double))} bytes");

//        // Display the size of the structs
//        Console.WriteLine($"S1 size: {System.Runtime.InteropServices.Marshal.SizeOf(typeof(S1))} bytes");
//        Console.WriteLine($"S2 size: {System.Runtime.InteropServices.Marshal.SizeOf(typeof(S2))} bytes");
//    }
//}

#endregion