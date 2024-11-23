





#region CpBook_3, Chapter_05: Stack

var stack = new Stack();
int item;

// Pushing items onto the stack
stack.Push(5);
stack.Push(7);
stack.Push(11);

// Popping items from the stack
item = stack.Pop();
Console.WriteLine("Popped item is " + item);
item = stack.Pop();
Console.WriteLine("Popped item is " + item);
item = stack.Pop();
Console.WriteLine("Popped item is " + item);
item = stack.Pop(); // Attempting to pop from an empty stack.
Console.WriteLine("Popped item is " + item);

class Stack
{
    private const int MAX = 10;
    private int top;
    private int[] data = new int[MAX];

    public Stack()
    {
        top = 0; // Initializing stack with an empty state.
    }

    public void Push(int item)
    {
        if (top < MAX) // Check if the stack is full
        {
            data[top] = item; // Add item to the stack
            top += 1; // Increment the top pointer
        }
        else
        {
            Console.WriteLine("Stack is full!");
        }
    }

    public int Pop()
    {
        if (top == 0) // Check if the stack is empty
        {
            Console.WriteLine("Stack is empty!");
            return -1; // Default return value for empty stack
        }

        top -= 1; // Decrement the top pointer
        return data[top]; // Get the item at the top
    }
}

#endregion


#region CpBook_3, Chapter_05: Queue

//var queue = new Queue();
//int item;

//// Enqueue operations
//queue.Enqueue(10);
//Console.WriteLine("tail: " + queue.Tail);

//queue.Enqueue(20);
//Console.WriteLine("tail: " + queue.Tail);

//queue.Enqueue(30);
//Console.WriteLine("tail: " + queue.Tail);

//// Dequeue operations
//item = queue.Dequeue();
//Console.WriteLine($"Dequeued item is {item}");

//item = queue.Dequeue();
//Console.WriteLine($"Dequeued item is {item}");

//item = queue.Dequeue();
//Console.WriteLine($"Dequeued item is {item}");

//item = queue.Dequeue(); // Attempting to dequeue from an empty queue
//Console.WriteLine($"Dequeued item is {item}");

//class Queue
//{
//    private int[] data = new int[5]; // Maximum size is 5
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
//            return -1; // Indicates the queue is empty
//        }
//        int item = data[head];
//        head = (head + 1) % (MAX + 1);
//        return item;
//    }

//    public int Tail => tail; // Exposes the tail index
//}

#endregion


