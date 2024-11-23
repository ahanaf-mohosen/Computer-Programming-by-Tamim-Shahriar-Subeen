

#region CpBook_3, Chapter_08: Binary Search Tree

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

#endregion
