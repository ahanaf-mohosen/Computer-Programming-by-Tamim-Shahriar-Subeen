





#region CpBook_3, Chapter_11: Merge Sort

int[] arr = { 5, 7, 2, 9, 1, 8 };
int size = arr.Length;

Console.Write("Original array: ");
Print(arr);

MergeSort(arr, 0, size - 1);
Console.Write("\nSorted array: ");
Print(arr);

void MergeSort(int[] arr, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    int mid = left + (right - left) / 2;
    MergeSort(arr, left, mid);
    MergeSort(arr, mid + 1, right);
    Merge(arr, left, mid, right);
}

void Merge(int[] arr, int left, int mid, int right)
{
    int sizeLeft = mid - left + 1;
    int sizeRight = right - mid;

    int[] L = new int[sizeLeft];
    int[] R = new int[sizeRight];

    // Copy data to temporary arrays
    for (int i = 0; i < sizeLeft; i++)
    {
        L[i] = arr[left + i];
    }
    for (int i = 0; i < sizeRight; i++)
    {
        R[i] = arr[mid + 1 + i];
    }

    int indexL = 0, indexR = 0, indexA = left;

    // Merge the temporary arrays back into the original array
    while (indexL < sizeLeft && indexR < sizeRight)
    {
        if (L[indexL] <= R[indexR])
        {
            arr[indexA] = L[indexL];
            indexL++;
        }
        else
        {
            arr[indexA] = R[indexR];
            indexR++;
        }
        indexA++;
    }

    // Copy remaining elements from L[], if any
    while (indexL < sizeLeft)
    {
        arr[indexA] = L[indexL];
        indexA++;
        indexL++;
    }

    // Copy remaining elements from R[], if any
    while (indexR < sizeRight)
    {
        arr[indexA] = R[indexR];
        indexA++;
        indexR++;
    }
}

void Print(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

#endregion

#region CpBook_3, Chapter_11: Quick Sort

//int[] A = { 1, 5, 6, 3, 5, 8, 7, 2, 9 };
//int size = A.Length;

//Console.WriteLine("Original array: ");
//Print(A, size);

//Console.WriteLine("Sorted Array: ");
//QuickSort(A, 0, size - 1);
//Print(A, size);

//void Print(int[] arr, int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}

//void QuickSort(int[] A, int low, int high)
//{
//    if (low >= high)
//    {
//        return;
//    }

//    int p = Partition(A, low, high);
//    QuickSort(A, low, p - 1);
//    QuickSort(A, p + 1, high);
//}

//int Partition(int[] A, int low, int high)
//{
//    int pivot = A[high];
//    int i = low - 1;

//    for (int j = low; j < high; j++)
//    {
//        if (A[j] <= pivot)
//        {
//            i++;
//            int temp = A[i];
//            A[i] = A[j];
//            A[j] = temp;
//        }
//    }

//    int temp1 = A[high];
//    A[high] = A[i + 1];
//    A[i + 1] = temp1;

//    return i + 1;
//}

#endregion

#region CpBook_3, Chapter_11: Counting Sort

//int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
//int size = arr.Length;

//Console.Write("Original array: ");
//Print(arr, size);

//CountingSort(arr, size);

//Console.Write("\nSorted array: ");
//Print(arr, size);

//void CountingSort(int[] arr, int n)
//{
//    // Find the maximum value in the array
//    int max = arr[0];
//    for (int i = 1; i < n; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }

//    // Initialize count array
//    int[] count = new int[max + 1];
//    for (int i = 0; i <= max; i++)
//    {
//        count[i] = 0;
//    }

//    // Count the occurrences of each element
//    for (int i = 0; i < n; i++)
//    {
//        count[arr[i]]++;
//    }

//    // Update the count array to store positions
//    for (int i = 1; i <= max; i++)
//    {
//        count[i] += count[i - 1];
//    }

//    // Create an output array
//    int[] output = new int[n];
//    for (int i = n - 1; i >= 0; i--)
//    {
//        output[count[arr[i]] - 1] = arr[i];
//        count[arr[i]]--;
//    }

//    // Copy the sorted elements back into the original array
//    for (int i = 0; i < n; i++)
//    {
//        arr[i] = output[i];
//    }
//}

//void Print(int[] arr, int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}

#endregion
