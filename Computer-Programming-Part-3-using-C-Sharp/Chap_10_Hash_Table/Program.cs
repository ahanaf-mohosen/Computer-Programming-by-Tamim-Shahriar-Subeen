

#region CpBook_3, Chapter_10: Hash Table

int choice, key, data, c;
HashTable hashTable = new HashTable(10);

do
{
    Console.WriteLine("\n1. Insert item in the Hash Table\n" +
                      "2. Remove item from the Hash Table\n" +
                      "3. Check the size of the Hash Table\n" +
                      "4. Display the Hash Table\n" +
                      "\nPlease enter your choice: ");

    string? input = Console.ReadLine();
    if (int.TryParse(input, out choice))
    {
        switch (choice)
        {
            case 1:
                Console.Write("Enter key: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out key))
                {
                    Console.Write("Enter data: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out data))
                    {
                        hashTable.Insert(key, data);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid key input.");
                }
                break;

            case 2:
                Console.Write("Enter the key to delete: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out key))
                {
                    hashTable.RemoveElement(key);
                }
                else
                {
                    Console.WriteLine("Invalid key input.");
                }
                break;

            case 3:
                int size = hashTable.SizeOfHashtable();
                Console.WriteLine($"Size of Hash Table is: {size}");
                break;

            case 4:
                hashTable.Display();
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid choice input.");
    }

    Console.Write("\nDo you want to continue? (press 1 for yes): ");
    input = Console.ReadLine();
    if (!int.TryParse(input, out c) || c != 1)
    {
        break;
    }

} while (true);

// Hash Table class definition

public class HashTable
{
    // Define a linked list node for storing values
    public class ValueNode
    {
        public int Data;
        public ValueNode? Next;

        public ValueNode(int data)
        {
            Data = data;
            Next = null;
        }
    }

    // Define a linked list node for keys
    public class KeyNode
    {
        public int Key;
        public ValueNode? Values;
        public KeyNode? Next;

        public KeyNode(int key)
        {
            Key = key;
            Values = null;
            Next = null;
        }
    }

    private KeyNode?[] _array;
    private int _capacity;
    private int _size;

    public HashTable(int capacity)
    {
        _capacity = capacity;
        _size = 0;
        _array = new KeyNode?[capacity];
        for (int i = 0; i < capacity; i++)
        {
            _array[i] = null;
        }
    }

    private int HashFunction(int key) => key % _capacity;

    public void Insert(int key, int data)
    {
        int index = HashFunction(key);
        KeyNode? current = _array[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                ValueNode newValue = new ValueNode(data);
                newValue.Next = current.Values;
                current.Values = newValue;
                Console.WriteLine($"\nKey ({key}) has been updated with a new value.");
                return;
            }
            current = current.Next;
        }

        KeyNode newKeyNode = new KeyNode(key);
        ValueNode newValueNode = new ValueNode(data);
        newKeyNode.Values = newValueNode;
        newKeyNode.Next = _array[index];
        _array[index] = newKeyNode;
        _size++;
        Console.WriteLine($"\nKey ({key}) has been inserted.");
    }

    public void RemoveElement(int key)
    {
        int index = HashFunction(key);
        KeyNode? current = _array[index];
        KeyNode? prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev != null)
                {
                    prev.Next = current.Next;
                }
                else
                {
                    _array[index] = current.Next;
                }

                ValueNode? valueCurrent = current.Values;
                while (valueCurrent != null)
                {
                    ValueNode? temp = valueCurrent;
                    valueCurrent = valueCurrent.Next;
                }

                _size--;
                Console.WriteLine($"\nKey ({key}) has been removed.");
                return;
            }
            prev = current;
            current = current.Next;
        }

        Console.WriteLine("\nThis key does not exist.");
    }

    public void Display()
    {
        for (int i = 0; i < _capacity; i++)
        {
            Console.Write($"\narray[{i}]: ");
            KeyNode? current = _array[i];
            while (current != null)
            {
                Console.Write($"Key ({current.Key}): ");
                ValueNode? valueCurrent = current.Values;
                while (valueCurrent != null)
                {
                    Console.Write($"[data: {valueCurrent.Data}] ");
                    valueCurrent = valueCurrent.Next;
                }
                Console.Write(" -> ");
                current = current.Next;
            }
        }
        Console.WriteLine();
    }

    public int SizeOfHashtable() => _size;
}

#endregion
