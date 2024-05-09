namespace f_generic_stack;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 78, 56, 12, 5 };
        Stack<int> myStack = new Stack<int>(arr);

        foreach (var item in myStack)
            Console.WriteLine(item);

        Console.Write("Number of elements in Stack: {0}", myStack.Count);

        while (myStack.Count > 0)
            Console.Write(myStack.Pop() + ",");

        Console.WriteLine("\nNumber of elements in Stack: {0}", myStack.Count);
    }
}
