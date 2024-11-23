

#region CpBook_3, Chapter_09: Max Heap Sort

int Left(int index) => 2 * index;

int Right(int index) => 2 * index + 1;

int Parent(int index) => index / 2;

int IsMaxHeap(int[] heap, int size)
{
    for (int i = size; i >= 1; i--)
    {
        int p = Parent(i);
        if (heap[p] < heap[i])
        {
            return 0;
        }
    }
    return 1;
}

void MaxHeapify(int[] heap, int size, int index)
{
    int l = Left(index), r = Right(index), largest, temp;
    if (l <= size && heap[l] > heap[index])
    {
        largest = l;
    }
    else
    {
        largest = index;
    }

    if (r <= size && heap[r] > heap[largest])
    {
        largest = r;
    }

    if (largest != index)
    {
        temp = heap[index];
        heap[index] = heap[largest];
        heap[largest] = temp;
        MaxHeapify(heap, size, largest);
    }
}

void PrintHeap(int[] heap, int size)
{
    for (int i = 1; i <= size; i++)
    {
        Console.Write(heap[i] + " ");
    }
    Console.WriteLine("\n");
}

void BuildMaxHeap(int[] heap, int size)
{
    for (int i = size / 2; i >= 1; i--)
    {
        MaxHeapify(heap, size, i);
    }
}

void HeapSort(int[] heap, int size)
{
    int temp;
    for (int i = size; i >= 1; i--)
    {
        temp = heap[1];
        heap[1] = heap[i];
        heap[i] = temp;
        size--;
        MaxHeapify(heap, size, 1);
    }
}

int[] heap = { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 }; // Adjusted for 1-based index
int size = heap.Length - 1;

int max = IsMaxHeap(heap, size);
Console.WriteLine(max == 0 ? "This is not a max heap" : "This is a max heap");

Console.WriteLine("Initial Heap:");
PrintHeap(heap, size);

Console.WriteLine("After building max heap:");
BuildMaxHeap(heap, size);
PrintHeap(heap, size);

Console.WriteLine("After sorting in descending order:");
HeapSort(heap, size);
PrintHeap(heap, size);

#endregion


#region CpBook_3, Chapter_09: Priority Queue

//int Left(int index) => 2 * index;
//int Right(int index) => 2 * index + 1;
//int Parent(int index) => index / 2;

//bool IsMaxHeap(int[] heap, int size)
//{
//    for (int i = size; i >= 1; i--)
//    {
//        int p = Parent(i);
//        if (p > 0 && heap[p] < heap[i])
//        {
//            return false;
//        }
//    }
//    return true;
//}

//void MaxHeapify(int[] heap, int size, int index)
//{
//    int l = Left(index), r = Right(index), largest = index, temp;

//    if (l <= size && heap[l] > heap[index])
//    {
//        largest = l;
//    }

//    if (r <= size && heap[r] > heap[largest])
//    {
//        largest = r;
//    }

//    if (largest != index)
//    {
//        temp = heap[index];
//        heap[index] = heap[largest];
//        heap[largest] = temp;
//        MaxHeapify(heap, size, largest);
//    }
//}

//void PrintHeap(int[] heap, int size)
//{
//    for (int i = 1; i <= size; i++)
//    {
//        Console.Write(heap[i] + " ");
//    }
//    Console.WriteLine();
//}

//void BuildMaxHeap(int[] heap, int size)
//{
//    for (int i = size / 2; i >= 1; i--)
//    {
//        MaxHeapify(heap, size, i);
//    }
//}

//void HeapSort(int[] heap, int size)
//{
//    int temp, originalSize = size;
//    for (int i = size; i >= 2; i--)
//    {
//        temp = heap[1];
//        heap[1] = heap[i];
//        heap[i] = temp;
//        size--;
//        MaxHeapify(heap, size, 1);
//    }
//    size = originalSize; // Restore the original size
//}

//int GetMaximum(int[] heap) => heap[1];

//int ExtractMax(int[] heap, ref int size)
//{
//    int max = heap[1];
//    heap[1] = heap[size];
//    size--;
//    MaxHeapify(heap, size, 1);
//    return max;
//}

//int InsertNode(int[] heap, ref int size, int node)
//{
//    size++;
//    int i = size;
//    heap[i] = node;

//    while (i > 1 && heap[i] > heap[Parent(i)])
//    {
//        int p = Parent(i);
//        int temp = heap[p];
//        heap[p] = heap[i];
//        heap[i] = temp;
//        i = p;
//    }
//    return size;
//}

//int[] heap = { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 }; // 0 is unused
//int size = heap.Length - 1; // Exclude the first element (0)

//// Check if it's a max heap
//bool isMaxHeap = IsMaxHeap(heap, size);
//Console.WriteLine(isMaxHeap ? "This is a max heap" : "This is not a max heap");

//Console.WriteLine("Initial Heap:");
//PrintHeap(heap, size);

//// Build max heap
//Console.WriteLine("After building max heap:");
//BuildMaxHeap(heap, size);
//PrintHeap(heap, size);

//// Get maximum element
//Console.WriteLine($"Maximum element: {GetMaximum(heap)}");

//// Extract maximum element
//int extractedMax = ExtractMax(heap, ref size);
//Console.WriteLine($"Extracted maximum element: {extractedMax}");
//Console.WriteLine("Heap after extraction:");
//PrintHeap(heap, size);

//// Insert a new element
//int newNode = 15;
//size = InsertNode(heap, ref size, newNode);
//Console.WriteLine($"Heap after inserting {newNode}:");
//PrintHeap(heap, size);

//// Sort the heap
//Console.WriteLine("After sorting in descending order:");
//HeapSort(heap, size);
//PrintHeap(heap, size);

#endregion
