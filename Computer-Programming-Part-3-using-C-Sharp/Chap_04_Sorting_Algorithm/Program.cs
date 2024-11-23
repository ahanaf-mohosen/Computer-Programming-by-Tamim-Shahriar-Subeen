



#region CpBook_3, Chapter_04: Selection Sort

int[] arr = { 1, 2, 3, 4, 5 };
int size = arr.Length;

Console.Write("Before Sort = ");
Print(arr, size);

if (IsSorted(arr, size))
{
    Console.WriteLine("\nArray is already sorted.");
}
else
{
    SelectionSort(arr, size);
    Console.Write("\nAfter Sort = ");
    Print(arr, size);
}

static void SelectionSort(int[] arr, int size)
{
    int minValue, temp;
    for (int i = 0; i < size - 1; i++)
    {
        minValue = i;
        for (int j = i + 1; j < size; j++)
        {
            if (arr[j] < arr[minValue])
            {
                minValue = j;
            }
        }
        if (minValue != i)
        {
            temp = arr[i];
            arr[i] = arr[minValue];
            arr[minValue] = temp;
        }
    }
}

static void Print(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

static bool IsSorted(int[] arr, int size)
{
    for (int i = 0; i < size - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            return false;
        }
    }
    return true;
}

#endregion


#region CpBook_3, Chapter_04: Bubble Sort

//int[] arr = { 4, 5, 2, 1, 8, 6, 4 };
//int size = arr.Length;

//Console.Write("Before Sort = ");
//Print(arr, size);

//if (IsSorted(arr, size))
//{
//    Console.WriteLine("\nArray is already sorted.");
//}
//else
//{
//    BubbleSort(arr, size);
//    Console.Write("\nAfter Sort = ");
//    Print(arr, size);
//}

//static void BubbleSort(int[] arr, int size)
//{
//    int temp;
//    for (int i = 0; i < size; i++)
//    {
//        for (int j = 0; j < size - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}

//static void Print(int[] arr, int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}

//static bool IsSorted(int[] arr, int size)
//{
//    for (int i = 0; i < size - 1; i++)
//    {
//        if (arr[i] > arr[i + 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}

#endregion


#region CpBook_3, Chapter_04: Insertion Sort

//int[] arr = { 4, 5, 2, 1, 8, 6, 4 };
//int size = arr.Length;

//Console.Write("Before Sort = ");
//Print(arr, size);

//if (IsSorted(arr, size))
//{
//    Console.WriteLine("\nArray is already sorted.");
//}
//else
//{
//    InsertionSort(arr, size);
//    Console.Write("\nAfter Sort = ");
//    Print(arr, size);
//}

//static void InsertionSort(int[] arr, int size)
//{
//    for (int i = 1; i < size; i++)
//    {
//        int temp = arr[i];
//        int j = i - 1;
//        while (j >= 0 && arr[j] > temp)
//        {
//            arr[j + 1] = arr[j];
//            j--;
//        }
//        arr[j + 1] = temp;
//    }
//}

//static void Print(int[] arr, int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}

//static bool IsSorted(int[] arr, int size)
//{
//    for (int i = 0; i < size - 1; i++)
//    {
//        if (arr[i] > arr[i + 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}

#endregion
