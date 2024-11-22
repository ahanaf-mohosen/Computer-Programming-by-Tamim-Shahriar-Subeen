






#region CpBook_3, Code: Binary Search Tree
using System;
using System.Collections.Generic;

class BinarySearchTree
{
    private SortedSet<int> bstSet;

    public BinarySearchTree()
    {
        bstSet = new SortedSet<int>();
    }

    // Insert an item into the BST
    public void Insert(int item)
    {
        bstSet.Add(item);
    }

    // Search for an item in the BST
    public bool Search(int item)
    {
        return bstSet.Contains(item);
    }

    // Get the minimum value in the BST
    public int? GetMinimum()
    {
        if (bstSet.Count == 0)
        {
            return null; // Tree is empty
        }
        return bstSet.Min;
    }

    // Get the maximum value in the BST
    public int? GetMaximum()
    {
        if (bstSet.Count == 0)
        {
            return null; // Tree is empty
        }
        return bstSet.Max;
    }

    // Delete an item from the BST
    public bool Delete(int item)
    {
        return bstSet.Remove(item);
    }

    // Pre-order traversal (not directly supported in SortedSet, so we need to do it manually)
    public void PreOrder()
    {
        Console.WriteLine("PreOrder: ");
        foreach (var item in bstSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // In-order traversal (SortedSet maintains sorted order, so this is naturally in-order)
    public void InOrder()
    {
        Console.WriteLine("InOrder: ");
        foreach (var item in bstSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Post-order traversal (Not directly supported in SortedSet, so we need to reverse for post-order)
    public void PostOrder()
    {
        Console.WriteLine("PostOrder: ");
        foreach (var item in bstSet.Reverse())
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Inserting elements into the BST
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(17);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(19);
        bst.Insert(1);
        bst.Insert(4);

        // Display minimum and maximum values in the BST
        Console.WriteLine($"Minimum value: {bst.GetMinimum()}");
        Console.WriteLine($"Maximum value: {bst.GetMaximum()}");

        // Traversals
        bst.PreOrder();
        bst.InOrder();
        bst.PostOrder();

        // Searching for elements in the BST
        int searchItem = 7;
        Console.WriteLine($"Search for {searchItem}: {(bst.Search(searchItem) ? "Found" : "Not Found")}");

        searchItem = 8;
        Console.WriteLine($"Search for {searchItem}: {(bst.Search(searchItem) ? "Found" : "Not Found")}");

        // Deleting elements from the BST
        int deleteItem = 10;
        Console.WriteLine($"Deleting {deleteItem}: {(bst.Delete(deleteItem) ? "Deleted" : "Not Found")}");

        // Traversals after deletion
        bst.PreOrder();
        bst.InOrder();
        bst.PostOrder();

        deleteItem = 5;
        Console.WriteLine($"Deleting {deleteItem}: {(bst.Delete(deleteItem) ? "Deleted" : "Not Found")}");

        // Traversals after deletion
        bst.PreOrder();
        bst.InOrder();
        bst.PostOrder();

        deleteItem = 1;
        Console.WriteLine($"Deleting {deleteItem}: {(bst.Delete(deleteItem) ? "Deleted" : "Not Found")}");

        // Final Traversals
        bst.PreOrder();
        bst.InOrder();
        bst.PostOrder();
    }
}
#endregion

#region CpBook_3, Code: Binary Search
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 2, 3, 4, 10, 40 };
//        int size = arr.Length;
//        int search = 10;
//        int result = BinarySearch(arr, size, search);
//        if (result == -1)
//        {
//            Console.WriteLine("Element is not present in array");
//        }
//        else
//        {
//            Console.WriteLine($"Element is present in array at position {result}");
//        }
//    }

//    static int BinarySearch(int[] arr, int size, int search)
//    {
//        int left = 0, right = size - 1, mid;
//        while (left <= right)
//        {
//            mid = left + (right - left) / 2;
//            if (arr[mid] == search)
//            {
//                return mid;
//            }
//            else if (arr[mid] < search)
//            {
//                left = mid + 1;
//            }
//            else if (arr[mid] > search)
//            {
//                right = mid - 1;
//            }
//        }
//        return -1; // Element not present in array
//    }
//}

#endregion

#region CpBook_3, Code: Bubble Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 4, 5, 2, 1, 8, 6, 4 };
//        int size = arr.Length;

//        Console.Write("Before Sort = ");
//        Print(arr, size);

//        if (IsSorted(arr, size))
//        {
//            Console.WriteLine("\nArray is already sorted.");
//        }
//        else
//        {
//            BubbleSort(arr, size);
//            Console.Write("\nAfter Sort = ");
//            Print(arr, size);
//        }
//    }

//    static void BubbleSort(int[] arr, int size)
//    {
//        int temp;
//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < size - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void Print(int[] arr, int size)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//    }

//    static bool IsSorted(int[] arr, int size)
//    {
//        for (int i = 0; i < size - 1; i++)
//        {
//            if (arr[i] > arr[i + 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}
#endregion

#region CpBook_3, Code: Counting Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
//        int size = arr.Length;

//        Console.Write("Original array: ");
//        Print(arr, size);

//        CountingSort(arr, size);

//        Console.Write("\nSorted array: ");
//        Print(arr, size);
//    }

//    static void CountingSort(int[] arr, int n)
//    {
//        // Find the maximum value in the array
//        int max = arr[0];
//        for (int i = 1; i < n; i++)
//        {
//            if (arr[i] > max)
//            {
//                max = arr[i];
//            }
//        }

//        // Initialize count array
//        int[] count = new int[max + 1];
//        for (int i = 0; i <= max; i++)
//        {
//            count[i] = 0;
//        }

//        // Count the occurrences of each element
//        for (int i = 0; i < n; i++)
//        {
//            count[arr[i]]++;
//        }

//        // Update the count array to store positions
//        for (int i = 1; i <= max; i++)
//        {
//            count[i] += count[i - 1];
//        }

//        // Create an output array
//        int[] output = new int[n];
//        for (int i = n - 1; i >= 0; i--)
//        {
//            output[count[arr[i]] - 1] = arr[i];
//            count[arr[i]]--;
//        }

//        // Copy the sorted elements back into the original array
//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = output[i];
//        }
//    }

//    static void Print(int[] arr, int size)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }
//}
#endregion

#region CpBook_3, Code: Doubly Linked List

//using System;

//class Program
//{
//    public class Node
//    {
//        public int Data;
//        public Node? Prev;  // Nullable type
//        public Node? Next;  // Nullable type

//        public Node(int data, Node? prev = null, Node? next = null)
//        {
//            Data = data;
//            Prev = prev;
//            Next = next;
//        }
//    }

//    static void Main()
//    {
//        Node? head = null;  // Nullable reference type

//        // Test appending nodes
//        Console.WriteLine("Appending 10, 20, 30 to the list:");
//        head = Append(head, 10);
//        head = Append(head, 20);
//        head = Append(head, 30);
//        PrintList(head);

//        // Test prepending a node
//        Console.WriteLine("Prepending 5 to the list:");
//        head = Prepend(head, 5);
//        PrintList(head);

//        // Test removing the head node
//        Console.WriteLine("Removing the head node (5):");
//        head = RemoveNode(head, head);
//        PrintList(head);

//        // Test removing a middle node
//        Console.WriteLine("Removing a middle node (20):");
//        Node? middleNode = head?.Next; // 20 is now the second node
//        if (middleNode != null)
//        {
//            head = RemoveNode(head, middleNode);
//            PrintList(head);
//        }

//        // Test removing the last node
//        Console.WriteLine("Removing the last node (30):");
//        Node? lastNode = head?.Next; // 30 is now the last node
//        if (lastNode != null)
//        {
//            head = RemoveNode(head, lastNode);
//            PrintList(head);
//        }
//    }

//    static Node? Prepend(Node? head, int item)
//    {
//        Node newNode = new Node(item, null, head);
//        if (head != null)
//        {
//            head.Prev = newNode;
//        }
//        return newNode;
//    }

//    static Node? Append(Node? head, int item)
//    {
//        Node newNode = new Node(item);
//        if (head == null)
//        {
//            return newNode;
//        }

//        Node? currentNode = head;
//        while (currentNode?.Next != null)
//        {
//            currentNode = currentNode.Next;
//        }

//        if (currentNode != null)
//        {
//            currentNode.Next = newNode;
//            newNode.Prev = currentNode;
//        }

//        return head;
//    }

//    static Node? RemoveNode(Node? head, Node? node)
//    {
//        if (node == null || head == null)
//        {
//            return head;
//        }

//        if (head == node)
//        {
//            head = head?.Next;
//            if (head != null)
//            {
//                head.Prev = null;
//            }
//            return head;
//        }

//        if (node.Prev != null)
//        {
//            node.Prev.Next = node.Next;
//        }
//        if (node.Next != null)
//        {
//            node.Next.Prev = node.Prev;
//        }
//        return head;
//    }

//    static void PrintList(Node? head)
//    {
//        Node? current = head;
//        Console.Write("List: ");
//        while (current != null)
//        {
//            Console.Write(current.Data + " ");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }
//}

#endregion

#region CpBook_3, Code: Hash Table
//using System;

//public class HashTable
//{
//    // Define a linked list node for storing values
//    public class ValueNode
//    {
//        public int Data;
//        public ValueNode? Next;  // Marked as nullable

//        public ValueNode(int data)
//        {
//            Data = data;
//            Next = null;
//        }
//    }

//    // Define a linked list node for keys
//    public class KeyNode
//    {
//        public int Key;
//        public ValueNode? Values; // Marked as nullable
//        public KeyNode? Next;     // Marked as nullable

//        public KeyNode(int key)
//        {
//            Key = key;
//            Values = null;
//            Next = null;
//        }
//    }

//    // Define the hash table structure
//    private KeyNode?[] _array; // Array of pointers to key linked lists (nullable)
//    private int _capacity;      // Maximum capacity of the hash table
//    private int _size;          // Current number of keys

//    public HashTable(int capacity)
//    {
//        _capacity = capacity;
//        _size = 0;
//        _array = new KeyNode?[capacity]; // Array of nullable KeyNode references

//        for (int i = 0; i < capacity; i++)
//        {
//            _array[i] = null; // Initialize all array entries to NULL
//        }
//    }

//    // Function to hash the key
//    private int HashFunction(int key)
//    {
//        return key % _capacity;
//    }

//    // Function to insert an item into the hash table
//    public void Insert(int key, int data)
//    {
//        int index = HashFunction(key);
//        KeyNode? current = _array[index];

//        // Check if the key already exists
//        while (current != null)
//        {
//            if (current.Key == key)
//            {
//                // Append the value to the values list
//                ValueNode newValue = new ValueNode(data);
//                newValue.Next = current.Values;
//                current.Values = newValue;
//                Console.WriteLine($"\nKey ({key}) has been updated with a new value.");
//                return;
//            }
//            current = current.Next;
//        }

//        // If the key does not exist, create a new key node
//        KeyNode newKeyNode = new KeyNode(key);
//        ValueNode newValueNode = new ValueNode(data);
//        newKeyNode.Values = newValueNode;

//        // Insert the new key node at the head of the list for this index
//        newKeyNode.Next = _array[index];
//        _array[index] = newKeyNode;
//        _size++;
//        Console.WriteLine($"\nKey ({key}) has been inserted.");
//    }

//    // Function to remove an item from the hash table
//    public void RemoveElement(int key)
//    {
//        int index = HashFunction(key);
//        KeyNode? current = _array[index];
//        KeyNode? prev = null;

//        // Traverse the list to find the key
//        while (current != null)
//        {
//            if (current.Key == key)
//            {
//                // Remove the key node
//                if (prev != null)
//                {
//                    prev.Next = current.Next;
//                }
//                else
//                {
//                    _array[index] = current.Next;
//                }

//                // Free all value nodes (Garbage Collection handles this)
//                ValueNode? valueCurrent = current.Values;
//                while (valueCurrent != null)
//                {
//                    ValueNode? temp = valueCurrent;
//                    valueCurrent = valueCurrent.Next;
//                }

//                _size--;
//                Console.WriteLine($"\nKey ({key}) has been removed.");
//                return;
//            }
//            prev = current;
//            current = current.Next;
//        }

//        Console.WriteLine("\nThis key does not exist.");
//    }

//    // Function to display the hash table
//    public void Display()
//    {
//        for (int i = 0; i < _capacity; i++)
//        {
//            Console.Write($"\narray[{i}]: ");
//            KeyNode? current = _array[i];
//            while (current != null)
//            {
//                Console.Write($"Key ({current.Key}): ");
//                ValueNode? valueCurrent = current.Values;
//                while (valueCurrent != null)
//                {
//                    Console.Write($"[data: {valueCurrent.Data}] ");
//                    valueCurrent = valueCurrent.Next;
//                }
//                Console.Write(" -> ");
//                current = current.Next;
//            }
//        }
//        Console.WriteLine();
//    }

//    // Function to get the size of the hash table
//    public int SizeOfHashtable()
//    {
//        return _size;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        HashTable hashTable = new HashTable(10); // Initialize hash table with capacity 10

//        int choice, key, data, c;
//        do
//        {
//            Console.WriteLine("\n1. Insert item in the Hash Table\n" +
//                              "2. Remove item from the Hash Table\n" +
//                              "3. Check the size of the Hash Table\n" +
//                              "4. Display the Hash Table\n" +
//                              "\nPlease enter your choice: ");

//            // Using TryParse to handle invalid input
//            string? input = Console.ReadLine();
//            if (int.TryParse(input, out choice))
//            {
//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter key: ");
//                        input = Console.ReadLine();
//                        if (int.TryParse(input, out key))
//                        {
//                            Console.Write("Enter data: ");
//                            input = Console.ReadLine();
//                            if (int.TryParse(input, out data))
//                            {
//                                hashTable.Insert(key, data);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid data input.");
//                            }
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid key input.");
//                        }
//                        break;

//                    case 2:
//                        Console.Write("Enter the key to delete: ");
//                        input = Console.ReadLine();
//                        if (int.TryParse(input, out key))
//                        {
//                            hashTable.RemoveElement(key);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid key input.");
//                        }
//                        break;

//                    case 3:
//                        int size = hashTable.SizeOfHashtable();
//                        Console.WriteLine($"Size of Hash Table is: {size}");
//                        break;

//                    case 4:
//                        hashTable.Display();
//                        break;

//                    default:
//                        Console.WriteLine("Invalid Input");
//                        break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid choice input.");
//            }

//            // Ask if the user wants to continue
//            Console.Write("\nDo you want to continue? (press 1 for yes): ");
//            input = Console.ReadLine();
//            if (!int.TryParse(input, out c) || c != 1)
//            {
//                break;
//            }

//        } while (true);
//    }
//}

#endregion

#region CpBook_3, Code: Insertion Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 4, 5, 2, 1, 8, 6, 4 };
//        int size = arr.Length;

//        Console.Write("Before Sort = ");
//        Print(arr, size);

//        if (IsSorted(arr, size))
//        {
//            Console.WriteLine("\nArray is already sorted.");
//        }
//        else
//        {
//            InsertionSort(arr, size);
//            Console.Write("\nAfter Sort = ");
//            Print(arr, size);
//        }
//    }

//    static void InsertionSort(int[] arr, int size)
//    {
//        for (int i = 1; i < size; i++)
//        {
//            int temp = arr[i];
//            int j = i - 1;
//            while (j >= 0 && arr[j] > temp)
//            {
//                arr[j + 1] = arr[j];
//                j--;
//            }
//            arr[j + 1] = temp;
//        }
//    }

//    static void Print(int[] arr, int size)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//    }

//    static bool IsSorted(int[] arr, int size)
//    {
//        for (int i = 0; i < size - 1; i++)
//        {
//            if (arr[i] > arr[i + 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

#endregion

#region CpBook_3, Code: Linear Search
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 2, 3, 4, 10, 40 };
//        int size = arr.Length;
//        int search = 10;
//        int result = LinearSearch(arr, size, search);
//        if (result == -1)
//        {
//            Console.WriteLine("Element is not present in array");
//        }
//        else
//        {
//            Console.WriteLine($"Element is present in array at position {result}");
//        }
//    }

//    static int LinearSearch(int[] arr, int size, int search)
//    {
//        for (int i = 0; i < size; ++i)
//        {
//            if (arr[i] == search)
//            {
//                return i;
//            }
//        }
//        return -1;
//    }
//}

#endregion

#region CpBook_3, Code: Linked List Update
//using System;

//class Program
//{
//    // Node class with nullable Next reference
//    class Node
//    {
//        public int Data;
//        public Node? Next; // Nullable Next reference

//        public Node(int data, Node? next = null) // Default next is null
//        {
//            Data = data;
//            Next = next;
//        }
//    }

//    // Method to create a new node
//    static Node? CreateNode(int item, Node? next = null) // Nullable return type
//    {
//        return new Node(item, next); // Returns a new node, next can be null
//    }

//    // Prepend method
//    static Node? Prepend(Node? head, int item) // head is nullable
//    {
//        Node? newNode = CreateNode(item, head); // Create new node with head as the next
//        return newNode; // Return the new head (can be null)
//    }

//    // Append method
//    static Node? Append(Node? head, int item) // head is nullable
//    {
//        Node? newNode = CreateNode(item); // Create a new node without a next reference
//        if (head == null)
//        {
//            return newNode; // If list is empty, return the new node as head
//        }

//        Node? current = head; // current is nullable
//        while (current?.Next != null) // Safe navigation to prevent null reference
//        {
//            current = current.Next;
//        }

//        if (current != null) // We are sure current is not null here
//        {
//            current.Next = newNode; // Add new node to the end
//        }

//        return head; // head could still be null
//    }

//    // Print the linked list
//    static void PrintList(Node? head) // head is nullable
//    {
//        Node? current = head; // current is nullable
//        while (current != null)
//        {
//            Console.WriteLine($"data: {current.Data}");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }

//    // Main function with a nullable head
//    static void Main()
//    {
//        Node? head = null;

//        while (true)
//        {
//            Console.WriteLine("Choose an option:");
//            Console.WriteLine("1. Prepend\n2. Append\n3. Print List\n6. Exit");
//            Console.Write("Enter your choice: ");
//            string? input = Console.ReadLine();
//            if (int.TryParse(input, out int choice))
//            {
//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter value to prepend: ");
//                        input = Console.ReadLine();
//                        if (int.TryParse(input, out int item1))
//                        {
//                            head = Prepend(head, item1); // Prepend and assign to head
//                        }
//                        break;
//                    case 2:
//                        Console.Write("Enter value to append: ");
//                        input = Console.ReadLine();
//                        if (int.TryParse(input, out int item2))
//                        {
//                            head = Append(head, item2); // Append and assign to head
//                        }
//                        break;
//                    case 3:
//                        PrintList(head); // Print the list
//                        break;
//                    case 6:
//                        return; // Exit
//                    default:
//                        Console.WriteLine("Invalid choice.");
//                        break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid input.");
//            }
//        }
//    }
//}

#endregion

#region CpBook_3, Code: Linked List
//#nullable enable

//using System;

//class Node
//{
//    public int Data;
//    public Node? Next;  // Make Next nullable

//    public Node(int data, Node? next = null)
//    {
//        Data = data;
//        Next = next;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Node? head, n;
//        n = CreateNode(10, null);
//        head = n;
//        PrintList(head);

//        head = Prepend(head, 20);
//        head = Prepend(head, 5);
//        PrintList(head);

//        head = Append(head, 30);
//        head = Append(head, 40);
//        PrintList(head);
//    }

//    static Node CreateNode(int item, Node? next)
//    {
//        Node newNode = new Node(item, next);
//        return newNode;
//    }

//    static Node Prepend(Node? head, int item)
//    {
//        Node newNode = new Node(item, head);
//        return newNode;
//    }

//    static Node Append(Node? head, int item)
//    {
//        Node newNode = new Node(item, null);
//        if (head == null)
//        {
//            head = newNode;
//            return head;
//        }

//        Node current = head;
//        while (current.Next != null)
//        {
//            current = current.Next;
//        }
//        current.Next = newNode;
//        return head;
//    }

//    static void PrintList(Node? head)
//    {
//        Node? current = head;
//        while (current != null)
//        {
//            Console.WriteLine($"data: {current.Data}");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }
//}

#endregion

#region CpBook_3, Code: Max Heap Sort
//using System;

//class Program
//{
//    static int Left(int index)
//    {
//        return 2 * index;
//    }

//    static int Right(int index)
//    {
//        return 2 * index + 1;
//    }

//    static int Parent(int index)
//    {
//        return index / 2;
//    }

//    static int IsMaxHeap(int[] heap, int size)
//    {
//        for (int i = size; i >= 1; i--)
//        {
//            int p = Parent(i);
//            if (heap[p] < heap[i])
//            {
//                return 0;
//            }
//        }
//        return 1;
//    }

//    static void MaxHeapify(int[] heap, int size, int index)
//    {
//        int l, r, largest, temp;
//        l = Left(index);
//        r = Right(index);

//        if (l <= size && heap[l] > heap[index])
//        {
//            largest = l;
//        }
//        else
//        {
//            largest = index;
//        }

//        if (r <= size && heap[r] > heap[largest])
//        {
//            largest = r;
//        }
//        if (largest != index)
//        {
//            temp = heap[index];
//            heap[index] = heap[largest];
//            heap[largest] = temp;
//            MaxHeapify(heap, size, largest);
//        }
//    }

//    static void PrintHeap(int[] heap, int size)
//    {
//        for (int i = 1; i <= size; i++)
//        {
//            Console.Write(heap[i] + " ");
//        }
//        Console.WriteLine("\n");
//    }

//    static void BuildMaxHeap(int[] heap, int size)
//    {
//        for (int i = size / 2; i >= 1; i--)
//        {
//            MaxHeapify(heap, size, i);
//        }
//    }

//    static void HeapSort(int[] heap, int size)
//    {
//        int temp;
//        for (int i = size; i >= 1; i--)
//        {
//            temp = heap[1];
//            heap[1] = heap[i];
//            heap[i] = temp;
//            size--;
//            MaxHeapify(heap, size, 1);
//        }
//    }

//    static void Main()
//    {
//        int[] heap = { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 }; // Adjusted for 1-based index
//        int size = heap.Length - 1;

//        int max = IsMaxHeap(heap, size);
//        if (max == 0)
//        {
//            Console.WriteLine("This is not a max heap");
//        }
//        else
//        {
//            Console.WriteLine("This is a max heap");
//        }

//        Console.WriteLine("Initial Heap:");
//        PrintHeap(heap, size);

//        Console.WriteLine("After building max heap:");
//        BuildMaxHeap(heap, size);
//        PrintHeap(heap, size);

//        Console.WriteLine("After sorting in descending order:");
//        HeapSort(heap, size);
//        PrintHeap(heap, size);
//    }
//}

#endregion

#region CpBook_3, Code: Merge Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 5, 7, 2, 9, 1, 8 };
//        int size = arr.Length;

//        Console.Write("Original array: ");
//        Print(arr);

//        MergeSort(arr, 0, size - 1);
//        Console.Write("\nSorted array: ");
//        Print(arr);
//    }

//    static void MergeSort(int[] arr, int left, int right)
//    {
//        if (left >= right)
//        {
//            return;
//        }

//        int mid = left + (right - left) / 2;
//        MergeSort(arr, left, mid);
//        MergeSort(arr, mid + 1, right);
//        Merge(arr, left, mid, right);
//    }

//    static void Merge(int[] arr, int left, int mid, int right)
//    {
//        int sizeLeft = mid - left + 1;
//        int sizeRight = right - mid;

//        int[] L = new int[sizeLeft];
//        int[] R = new int[sizeRight];

//        // Copy data to temporary arrays
//        for (int i = 0; i < sizeLeft; i++)
//        {
//            L[i] = arr[left + i];
//        }
//        for (int i = 0; i < sizeRight; i++)
//        {
//            R[i] = arr[mid + 1 + i];
//        }

//        int indexL = 0, indexR = 0, indexA = left;

//        // Merge the temporary arrays back into the original array
//        while (indexL < sizeLeft && indexR < sizeRight)
//        {
//            if (L[indexL] <= R[indexR])
//            {
//                arr[indexA] = L[indexL];
//                indexL++;
//            }
//            else
//            {
//                arr[indexA] = R[indexR];
//                indexR++;
//            }
//            indexA++;
//        }

//        // Copy remaining elements from L[], if any
//        while (indexL < sizeLeft)
//        {
//            arr[indexA] = L[indexL];
//            indexA++;
//            indexL++;
//        }

//        // Copy remaining elements from R[], if any
//        while (indexR < sizeRight)
//        {
//            arr[indexA] = R[indexR];
//            indexA++;
//            indexR++;
//        }
//    }

//    static void Print(int[] arr)
//    {
//        foreach (int num in arr)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}

#endregion

#region CpBook_3, Code: Priority Queue
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] heap = { 0, 19, 7, 12, 3, 5, 17, 10, 1, 2 }; // 0 is unused
//        int size = heap.Length - 1; // Exclude the first element (0)

//        // Check if it's a max heap
//        bool isMaxHeap = IsMaxHeap(heap, size);
//        if (!isMaxHeap)
//        {
//            Console.WriteLine("This is not a max heap");
//        }
//        else
//        {
//            Console.WriteLine("This is a max heap");
//        }

//        Console.WriteLine("Initial Heap:");
//        PrintHeap(heap, size);

//        // Build max heap
//        Console.WriteLine("After building max heap:");
//        BuildMaxHeap(heap, size);
//        PrintHeap(heap, size);

//        // Get maximum element
//        Console.WriteLine($"Maximum element: {GetMaximum(heap)}");

//        // Extract maximum element
//        int extractedMax = ExtractMax(heap, ref size);
//        Console.WriteLine($"Extracted maximum element: {extractedMax}");
//        Console.WriteLine("Heap after extraction:");
//        PrintHeap(heap, size);

//        // Insert a new element
//        int newNode = 15;
//        size = InsertNode(heap, ref size, newNode);
//        Console.WriteLine($"Heap after inserting {newNode}:");
//        PrintHeap(heap, size);

//        // Sort the heap
//        Console.WriteLine("After sorting in descending order:");
//        HeapSort(heap, size);
//        PrintHeap(heap, size);
//    }

//    static int Left(int index) => 2 * index;
//    static int Right(int index) => 2 * index + 1;
//    static int Parent(int index) => index / 2;

//    static bool IsMaxHeap(int[] heap, int size)
//    {
//        for (int i = size; i >= 1; i--)
//        {
//            int p = Parent(i);
//            if (p > 0 && heap[p] < heap[i])
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static void MaxHeapify(int[] heap, int size, int index)
//    {
//        int l = Left(index);
//        int r = Right(index);
//        int largest = index;
//        int temp;

//        if (l <= size && heap[l] > heap[index])
//        {
//            largest = l;
//        }

//        if (r <= size && heap[r] > heap[largest])
//        {
//            largest = r;
//        }

//        if (largest != index)
//        {
//            temp = heap[index];
//            heap[index] = heap[largest];
//            heap[largest] = temp;
//            MaxHeapify(heap, size, largest);
//        }
//    }

//    static void PrintHeap(int[] heap, int size)
//    {
//        for (int i = 1; i <= size; i++)
//        {
//            Console.Write(heap[i] + " ");
//        }
//        Console.WriteLine();
//    }

//    static void BuildMaxHeap(int[] heap, int size)
//    {
//        for (int i = size / 2; i >= 1; i--)
//        {
//            MaxHeapify(heap, size, i);
//        }
//    }

//    static void HeapSort(int[] heap, int size)
//    {
//        int temp;
//        int originalSize = size;
//        for (int i = size; i >= 2; i--)
//        {
//            temp = heap[1];
//            heap[1] = heap[i];
//            heap[i] = temp;
//            size--;
//            MaxHeapify(heap, size, 1);
//        }
//        size = originalSize; // Restore the original size
//    }

//    static int GetMaximum(int[] heap) => heap[1];

//    static int ExtractMax(int[] heap, ref int size)
//    {
//        int max = heap[1];
//        heap[1] = heap[size];
//        size--;
//        MaxHeapify(heap, size, 1);
//        return max;
//    }

//    static int InsertNode(int[] heap, ref int size, int node)
//    {
//        size++;
//        int i = size;
//        heap[i] = node;

//        while (i > 1 && heap[i] > heap[Parent(i)])
//        {
//            int p = Parent(i);
//            int temp = heap[p];
//            heap[p] = heap[i];
//            heap[i] = temp;
//            i = p;
//        }
//        return size;
//    }
//}

#endregion

#region CpBook_3, Code: Queue
//using System;

//class Queue
//{
//    private int[] data = new int[5]; // Define the maximum size as 5
//    private int head = 0, tail = 0;
//    private const int MAX = 5;

//    public void Enqueue(int item)
//    {
//        if ((tail + 1) % (MAX + 1) == head)
//        {
//            Console.WriteLine("Queue is full!");
//            return;
//        }
//        data[tail] = item;
//        tail = (tail + 1) % (MAX + 1);
//    }

//    public int Dequeue()
//    {
//        if (head == tail)
//        {
//            Console.WriteLine("Queue is empty!");
//            return -1; // Return a value indicating the queue is empty
//        }
//        int item = data[head];
//        head = (head + 1) % (MAX + 1);
//        return item;
//    }

//    public int Tail => tail; // To access the tail value externally
//}

//class Program
//{
//    static void Main()
//    {
//        Queue q = new Queue();
//        int item;

//        q.Enqueue(10);
//        Console.WriteLine("tail: " + q.Tail);

//        q.Enqueue(20);
//        Console.WriteLine("tail: " + q.Tail);

//        q.Enqueue(30);
//        Console.WriteLine("tail: " + q.Tail);

//        item = q.Dequeue();
//        Console.WriteLine($"Dequeued item is {item}");

//        item = q.Dequeue();
//        Console.WriteLine($"Dequeued item is {item}");

//        item = q.Dequeue();
//        Console.WriteLine($"Dequeued item is {item}");

//        item = q.Dequeue();
//        Console.WriteLine($"Dequeued item is {item}");
//    }
//}

#endregion

#region CpBook_3, Code: Quick Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] A = { 1, 5, 6, 3, 5, 8, 7, 2, 9 };
//        int size = A.Length;
//        Console.WriteLine("Original array: ");
//        Print(A, size);
//        Console.WriteLine("Sorted Array: ");
//        QuickSort(A, 0, size - 1);
//        Print(A, size);
//    }

//    static void Print(int[] arr, int size)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }

//    static void QuickSort(int[] A, int low, int high)
//    {
//        if (low >= high)
//        {
//            return;
//        }

//        int p = Partition(A, low, high);
//        QuickSort(A, low, p - 1);
//        QuickSort(A, p + 1, high);
//    }

//    static int Partition(int[] A, int low, int high)
//    {
//        int pivot = A[high];
//        int i = low - 1;

//        for (int j = low; j < high; j++)
//        {
//            if (A[j] <= pivot)
//            {
//                i++;
//                int temp = A[i];
//                A[i] = A[j];
//                A[j] = temp;
//            }
//        }

//        int temp1 = A[high];
//        A[high] = A[i + 1];
//        A[i + 1] = temp1;

//        return i + 1;
//    }
//}

#endregion

#region CpBook_3, Code: Selection Sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        int size = arr.Length;
//        Console.Write("Before Sort = ");
//        Print(arr, size);

//        if (IsSorted(arr, size))
//        {
//            Console.WriteLine("\nArray is already sorted.");
//        }
//        else
//        {
//            SelectionSort(arr, size);
//            Console.Write("\nAfter Sort = ");
//            Print(arr, size);
//        }
//    }

//    static void SelectionSort(int[] arr, int size)
//    {
//        int minValue, temp;
//        for (int i = 0; i < size - 1; i++)
//        {
//            minValue = i;
//            for (int j = i + 1; j < size; j++)
//            {
//                if (arr[j] < arr[minValue])
//                {
//                    minValue = j;
//                }
//            }
//            if (minValue != i)
//            {
//                temp = arr[i];
//                arr[i] = arr[minValue];
//                arr[minValue] = temp;
//            }
//        }
//    }

//    static void Print(int[] arr, int size)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }

//    static bool IsSorted(int[] arr, int size)
//    {
//        for (int i = 0; i < size - 1; i++)
//        {
//            if (arr[i] > arr[i + 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

#endregion

#region CpBook_3, Code: Stack
//using System;

//class Stack
//{
//    private const int MAX = 10;
//    private int top;
//    private int[] data = new int[MAX];

//    public Stack()
//    {
//        top = 0; // Initializing stack with an empty state.
//    }

//    public void Push(int item)
//    {
//        if (top < MAX) // Check if the stack is full
//        {
//            data[top] = item;  // Add item to the stack
//            top += 1;  // Increment the top pointer
//        }
//        else
//        {
//            Console.WriteLine("Stack is full!");
//        }
//    }

//    public int Pop()
//    {
//        int item = -1; // Default return value for empty stack
//        if (top == 0) // Check if the stack is empty
//        {
//            Console.WriteLine("Stack is empty!");
//        }
//        else
//        {
//            top -= 1; // Decrement the top pointer
//            item = data[top]; // Get the item at the top
//        }
//        return item;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Stack s = new Stack();
//        int item;

//        // Pushing items onto the stack
//        s.Push(5);
//        s.Push(7);
//        s.Push(11);

//        // Popping items from the stack
//        item = s.Pop();
//        Console.WriteLine("Popped item is " + item);
//        item = s.Pop();
//        Console.WriteLine("Popped item is " + item);
//        item = s.Pop();
//        Console.WriteLine("Popped item is " + item);
//        item = s.Pop(); // Attempting to pop from an empty stack.
//        Console.WriteLine("Popped item is " + item);
//    }
//}

#endregion

#region CpBook_3, Code: Tree
//using System;

//class Node
//{
//    public int Data;
//    public Node? Left;  // Mark as nullable
//    public Node? Right; // Mark as nullable

//    public Node(int item)
//    {
//        Data = item;
//        Left = null;
//        Right = null;
//    }
//}

//class BinaryTree
//{
//    // Method to create a new node
//    public static Node CreateNode(int item)
//    {
//        return new Node(item);
//    }

//    // Method to add a left child
//    public static void AddLeftChild(Node node, Node child)
//    {
//        node.Left = child;
//    }

//    // Method to add a right child
//    public static void AddRightChild(Node node, Node child)
//    {
//        node.Right = child;
//    }

//    // Pre-order traversal (Root, Left, Right)
//    public static void PreOrder(Node? node)
//    {
//        if (node == null) return;
//        Console.Write(node.Data + " ");
//        PreOrder(node.Left);
//        PreOrder(node.Right);
//    }

//    // Post-order traversal (Left, Right, Root)
//    public static void PostOrder(Node? node)
//    {
//        if (node == null) return;
//        PostOrder(node.Left);
//        PostOrder(node.Right);
//        Console.Write(node.Data + " ");
//    }

//    // In-order traversal (Left, Root, Right)
//    public static void InOrder(Node? node)
//    {
//        if (node == null) return;
//        InOrder(node.Left);
//        Console.Write(node.Data + " ");
//        InOrder(node.Right);
//    }

//    // Construct the binary tree
//    public static Node CreateTree()
//    {
//        Node two = CreateNode(2);
//        Node seven = CreateNode(7);
//        Node nine = CreateNode(9);
//        AddLeftChild(two, seven);
//        AddRightChild(two, nine);

//        Node one = CreateNode(1);
//        Node six = CreateNode(6);
//        Node eight = CreateNode(8);
//        AddLeftChild(seven, one);
//        AddRightChild(seven, six);
//        AddLeftChild(nine, eight);

//        Node five = CreateNode(5);
//        Node ten = CreateNode(10);
//        Node three = CreateNode(3);
//        Node four = CreateNode(4);
//        AddLeftChild(six, five);
//        AddRightChild(six, ten);
//        AddLeftChild(eight, three);
//        AddRightChild(eight, four);

//        return two;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Node root = BinaryTree.CreateTree();

//        if (root != null)
//        {
//            Console.WriteLine("PreOrder: ");
//            BinaryTree.PreOrder(root);

//            Console.WriteLine("\nInOrder: ");
//            BinaryTree.InOrder(root);

//            Console.WriteLine("\nPostOrder: ");
//            BinaryTree.PostOrder(root);
//        }
//        else
//        {
//            Console.WriteLine("The tree is empty.");
//        }

//        Console.WriteLine();
//    }
//}

#endregion