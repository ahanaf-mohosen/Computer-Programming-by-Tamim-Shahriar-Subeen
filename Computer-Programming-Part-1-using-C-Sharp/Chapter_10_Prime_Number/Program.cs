




#region CpBook_1, Problem: 10.1
int n;
while (true)
{
    Console.Write("Please enter a number (enter 0 to exit): ");
    string? input = Console.ReadLine();

    // Validate input
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    // Try to parse input
    if (!int.TryParse(input, out n))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue;
    }

    // Exit condition
    if (n == 0)
    {
        break;
    }

    // Check if the number is prime
    if (IsPrime(n))
    {
        Console.WriteLine($"{n} is a prime number.");
    }
    else
    {
        Console.WriteLine($"{n} is not a prime number.");
    }
}

bool IsPrime(int n)
{
    if (n < 2)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(n); i++) // Optimization: check up to sqrt(n)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
#endregion

#region CpBook_1, Problem: 10.2
//int n;
//while (true)
//{
//    Console.Write("Please enter a number (enter 0 to exit): ");
//    n = int.Parse(Console.ReadLine());
//    if (n == 0)
//    {
//        break;
//    }
//    if (IsPrime(n))
//    {
//        Console.WriteLine($"{n} is a prime number.");
//    }
//    else
//    {
//        Console.WriteLine($"{n} is not a prime number.");
//    }
//}
//static bool IsPrime(int n)
//{
//    if (n < 2) // Handle numbers less than 2
//    {
//        return false;
//    }
//    if (n == 2)
//    {
//        return true;
//    }
//    if (n % 2 == 0)
//    {
//        return false;
//    }
//    int root = (int)Math.Sqrt(n); // Square root of n
//    for (int i = 3; i <= root; i += 2)
//    {
//        if (n % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
#endregion

#region CpBook_1, Problem: 10.3
//const int size = 1000; // Set a constant for the sieve range
//int[] ara = new int[size]; // Array to mark prime and non-prime numbers
//Sieve(); // Precompute primes using the Sieve of Eratosthenes

//while (true)
//{
//    Console.Write("Please enter a number (enter 0 to exit): ");
//    string? input = Console.ReadLine();

//    // Validate input
//    if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int n))
//    {
//        Console.WriteLine("Invalid input. Please enter a valid integer.");
//        continue;
//    }

//    if (n == 0)
//    {
//        break; // Exit if the input is 0
//    }

//    if (n >= size)
//    {
//        Console.WriteLine($"The number should be less than {size}.");
//        continue;
//    }

//    if (IsPrime(n))
//    {
//        Console.WriteLine($"{n} is a prime number.");
//    }
//    else
//    {
//        Console.WriteLine($"{n} is not a prime number.");
//    }
//}
//void PrintAra()
//{
//    for (int i = 2; i < size; i++)
//    {
//        Console.Write($"{ara[i],4}");
//    }
//    Console.WriteLine();

//    for (int i = 2; i < size; i++)
//    {
//        Console.Write("----");
//    }
//    Console.WriteLine();

//    for (int i = 2; i < size; i++)
//    {
//        Console.Write($"{i,4}");
//    }
//    Console.WriteLine("\n\n\n");
//}

//void Sieve()
//{
//    // Initialize array with 1 (assume all numbers are prime initially)
//    for (int i = 2; i < size; i++)
//    {
//        ara[i] = 1;
//    }

//    int root = (int)Math.Sqrt(size);

//    for (int i = 2; i <= root; i++)
//    {
//        if (ara[i] == 1)
//        {
//            for (int j = i * i; j < size; j += i) // Start from i*i for optimization
//            {
//                ara[j] = 0; // Mark as non-prime
//            }
//        }
//    }
//}

//bool IsPrime(int n)
//{
//    return ara[n] == 1;
//}
#endregion
