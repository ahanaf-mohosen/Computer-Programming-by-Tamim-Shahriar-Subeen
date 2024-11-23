

#region CpBook_3, Chapter_07: Tree

// Creating the root of the tree
Node root = BinaryTree.CreateTree();

if (root != null)
{
    Console.WriteLine("PreOrder: ");
    BinaryTree.PreOrder(root);

    Console.WriteLine("\nInOrder: ");
    BinaryTree.InOrder(root);

    Console.WriteLine("\nPostOrder: ");
    BinaryTree.PostOrder(root);
}
else
{
    Console.WriteLine("The tree is empty.");
}

class Node
{
    public int Data;
    public Node? Left;  // Nullable type
    public Node? Right; // Nullable type

    public Node(int item)
    {
        Data = item;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    // Method to create a new node
    public static Node CreateNode(int item)
    {
        return new Node(item);
    }

    // Method to add a left child
    public static void AddLeftChild(Node node, Node child)
    {
        node.Left = child;
    }

    // Method to add a right child
    public static void AddRightChild(Node node, Node child)
    {
        node.Right = child;
    }

    // Pre-order traversal (Root, Left, Right)
    public static void PreOrder(Node? node)
    {
        if (node == null) return;
        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Post-order traversal (Left, Right, Root)
    public static void PostOrder(Node? node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // In-order traversal (Left, Root, Right)
    public static void InOrder(Node? node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Construct the binary tree
    public static Node CreateTree()
    {
        Node two = CreateNode(2);
        Node seven = CreateNode(7);
        Node nine = CreateNode(9);
        AddLeftChild(two, seven);
        AddRightChild(two, nine);

        Node one = CreateNode(1);
        Node six = CreateNode(6);
        Node eight = CreateNode(8);
        AddLeftChild(seven, one);
        AddRightChild(seven, six);
        AddLeftChild(nine, eight);

        Node five = CreateNode(5);
        Node ten = CreateNode(10);
        Node three = CreateNode(3);
        Node four = CreateNode(4);
        AddLeftChild(six, five);
        AddRightChild(six, ten);
        AddLeftChild(eight, three);
        AddRightChild(eight, four);

        return two;
    }
}

#endregion


