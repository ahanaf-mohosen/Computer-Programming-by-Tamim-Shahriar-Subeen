









#region CpBook_2, Problem: 8.1
using System;
using System.Diagnostics;

class Program
{
    static void Fnc(ref int x, int n)
    {
        x = n * 2;
    }

    static void Main()
    {
        int i, j, x = 0, n;
        Stopwatch stopwatch = new Stopwatch();

        // First block: without function call
        stopwatch.Start();

        n = 12345678;
        for (i = 0; i < 1000000000; i++)
        {
            for (j = 0; j < 10; j++)
            {
                x = n * 2;
            }
        }

        stopwatch.Stop();
        double timeElapsed = stopwatch.Elapsed.TotalSeconds;
        Console.WriteLine($"Time: {timeElapsed} seconds");

        // Second block: with function call
        stopwatch.Restart();

        n = 12345678;
        for (i = 0; i < 1000000000; i++)
        {
            for (j = 0; j < 10; j++)
            {
                Fnc(ref x, n);
            }
        }

        stopwatch.Stop();
        timeElapsed = stopwatch.Elapsed.TotalSeconds;
        Console.WriteLine($"Time: {timeElapsed} seconds");
    }
}

#endregion

#region CpBook_2, Problem: 8.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();

//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(rand.Next());
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 8.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random(0);  // Seed the random number generator

//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(rand.Next());
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 8.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();  // Automatically seeds with the system time

//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(rand.Next());
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 8.5
// dimik.cs
#endregion

#region CpBook_2, Problem: 8.6
//using Chapter_08_Some_Interesting_Programs;
//using System;

//class Program
//{
//    static void Main()
//    {
//        int n1 = 10, n2 = 5;

//        Console.WriteLine($"{n1} + {n2} = {Dimik.Add(n1, n2)}");
//        Console.WriteLine($"{n1} x {n2} = {Dimik.Mul(n1, n2)}");
//    }
//}

#endregion