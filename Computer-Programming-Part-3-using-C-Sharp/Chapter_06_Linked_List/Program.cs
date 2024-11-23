






#region CpBook_3, Chapter_06: Linked List

Node? head, n;
n = CreateNode(10, null);
head = n;
PrintList(head);

head = Prepend(head, 20);
head = Prepend(head, 5);
PrintList(head);

head = Append(head, 30);
head = Append(head, 40);
PrintList(head);

Node CreateNode(int item, Node? next)
{
    return new Node(item, next);
}

Node Prepend(Node? head, int item)
{
    Node newNode = new Node(item, head);
    return newNode;
}

Node Append(Node? head, int item)
{
    Node newNode = new Node(item, null);
    if (head == null)
    {
        head = newNode;
        return head;
    }

    Node current = head;
    while (current.Next != null)
    {
        current = current.Next;
    }
    current.Next = newNode;
    return head;
}

void PrintList(Node? head)
{
    Node? current = head;
    while (current != null)
    {
        Console.WriteLine($"data: {current.Data}");
        current = current.Next;
    }
    Console.WriteLine();
}

class Node
{
    public int Data;
    public Node? Next;

    public Node(int data, Node? next = null)
    {
        Data = data;
        Next = next;
    }
}

#endregion


#region CpBook_3, Chapter_06: Linked List Update

//Node? head = null;

//while (true)
//{
//    Console.WriteLine("Choose an option:");
//    Console.WriteLine("1. Prepend\n2. Append\n3. Print List\n6. Exit");
//    Console.Write("Enter your choice: ");
//    string? input = Console.ReadLine();

//    if (int.TryParse(input, out int choice))
//    {
//        switch (choice)
//        {
//            case 1:
//                Console.Write("Enter value to prepend: ");
//                input = Console.ReadLine();
//                if (int.TryParse(input, out int item1))
//                {
//                    head = Prepend(head, item1); // Prepend and assign to head
//                }
//                break;
//            case 2:
//                Console.Write("Enter value to append: ");
//                input = Console.ReadLine();
//                if (int.TryParse(input, out int item2))
//                {
//                    head = Append(head, item2); // Append and assign to head
//                }
//                break;
//            case 3:
//                PrintList(head); // Print the list
//                break;
//            case 6:
//                return; // Exit
//            default:
//                Console.WriteLine("Invalid choice.");
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input.");
//    }
//}

//Node? Prepend(Node? head, int item)
//{
//    Node? newNode = CreateNode(item, head); // Create new node with head as the next
//    return newNode; // Return the new head (can be null)
//}

//Node? Append(Node? head, int item)
//{
//    Node? newNode = CreateNode(item); // Create a new node without a next reference
//    if (head == null)
//    {
//        return newNode; // If list is empty, return the new node as head
//    }

//    Node? current = head; // current is nullable
//    while (current?.Next != null) // Safe navigation to prevent null reference
//    {
//        current = current.Next;
//    }

//    if (current != null) // We are sure current is not null here
//    {
//        current.Next = newNode; // Add new node to the end
//    }

//    return head; // head could still be null
//}

//void PrintList(Node? head)
//{
//    Node? current = head; // current is nullable
//    while (current != null)
//    {
//        Console.WriteLine($"data: {current.Data}");
//        current = current.Next;
//    }
//    Console.WriteLine();
//}

//Node? CreateNode(int item, Node? next = null) // Nullable return type
//{
//    return new Node(item, next); // Returns a new node, next can be null
//}

//class Node
//{
//    public int Data;
//    public Node? Next; // Nullable Next reference

//    public Node(int data, Node? next = null) // Default next is null
//    {
//        Data = data;
//        Next = next;
//    }
//}

#endregion


#region CpBook_3, Chapter_06: Doubly Linked List

//Node? head = null;  // Nullable reference type

//// Test appending nodes
//Console.WriteLine("Appending 10, 20, 30 to the list:");
//head = Append(head, 10);
//head = Append(head, 20);
//head = Append(head, 30);
//PrintList(head);

//// Test prepending a node
//Console.WriteLine("Prepending 5 to the list:");
//head = Prepend(head, 5);
//PrintList(head);

//// Test removing the head node
//Console.WriteLine("Removing the head node (5):");
//head = RemoveNode(head, head);
//PrintList(head);

//// Test removing a middle node
//Console.WriteLine("Removing a middle node (20):");
//Node? middleNode = head?.Next; // 20 is now the second node
//if (middleNode != null)
//{
//    head = RemoveNode(head, middleNode);
//    PrintList(head);
//}

//// Test removing the last node
//Console.WriteLine("Removing the last node (30):");
//Node? lastNode = head?.Next; // 30 is now the last node
//if (lastNode != null)
//{
//    head = RemoveNode(head, lastNode);
//    PrintList(head);
//}

//Node? Prepend(Node? head, int item)
//{
//    Node newNode = new Node(item, null, head);
//    if (head != null)
//    {
//        head.Prev = newNode;
//    }
//    return newNode;
//}

//Node? Append(Node? head, int item)
//{
//    Node newNode = new Node(item);
//    if (head == null)
//    {
//        return newNode;
//    }

//    Node? currentNode = head;
//    while (currentNode?.Next != null)
//    {
//        currentNode = currentNode.Next;
//    }

//    if (currentNode != null)
//    {
//        currentNode.Next = newNode;
//        newNode.Prev = currentNode;
//    }

//    return head;
//}

//Node? RemoveNode(Node? head, Node? node)
//{
//    if (node == null || head == null)
//    {
//        return head;
//    }

//    if (head == node)
//    {
//        head = head?.Next;
//        if (head != null)
//        {
//            head.Prev = null;
//        }
//        return head;
//    }

//    if (node.Prev != null)
//    {
//        node.Prev.Next = node.Next;
//    }
//    if (node.Next != null)
//    {
//        node.Next.Prev = node.Prev;
//    }
//    return head;
//}

//void PrintList(Node? head)
//{
//    Node? current = head;
//    Console.Write("List: ");
//    while (current != null)
//    {
//        Console.Write(current.Data + " ");
//        current = current.Next;
//    }
//    Console.WriteLine();
//}

//class Node
//{
//    public int Data;
//    public Node? Prev;  // Nullable type
//    public Node? Next;  // Nullable type

//    public Node(int data, Node? prev = null, Node? next = null)
//    {
//        Data = data;
//        Prev = prev;
//        Next = next;
//    }
//}

#endregion
