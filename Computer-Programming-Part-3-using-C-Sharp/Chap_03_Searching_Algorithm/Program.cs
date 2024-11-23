
#region CpBook_3, Chapter_03: Linear Search

int[] arr = { 2, 3, 4, 10, 40 };
int size = arr.Length;
int search = 10;
int result = LinearSearch(arr, size, search);

if (result == -1)
{
    Console.WriteLine("Element is not present in array");
}
else
{
    Console.WriteLine($"Element is present in array at position {result}");
}

static int LinearSearch(int[] arr, int size, int search)
{
    for (int i = 0; i < size; ++i)
    {
        if (arr[i] == search)
        {
            return i;
        }
    }
    return -1;
}

#endregion

#region CpBook_3, Chapter_03: Binary Search

//int[] arr = { 2, 3, 4, 10, 40 };
//int size = arr.Length;
//int search = 10;
//int result = BinarySearch(arr, size, search);

//if (result == -1)
//{
//    Console.WriteLine("Element is not present in array");
//}
//else
//{
//    Console.WriteLine($"Element is present in array at position {result}");
//}

//static int BinarySearch(int[] arr, int size, int search)
//{
//    int left = 0, right = size - 1, mid;
//    while (left <= right)
//    {
//        mid = left + (right - left) / 2;
//        if (arr[mid] == search)
//        {
//            return mid;
//        }
//        else if (arr[mid] < search)
//        {
//            left = mid + 1;
//        }
//        else
//        {
//            right = mid - 1;
//        }
//    }
//    return -1; // Element not present in array
//}

#endregion
