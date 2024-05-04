namespace d_generic_queue_string;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> MyChar = new Queue<string>();
        MyChar.Enqueue("S");
        MyChar.Enqueue("a");
        MyChar.Enqueue("n");
        MyChar.Enqueue("o");
        MyChar.Enqueue("t");
        MyChar.Enqueue("h");
        MyChar.Enqueue("i");
        MyChar.Enqueue("m");
        MyChar.Enqueue("i");

        Console.WriteLine("The number of characters = " + MyChar.Count);
        Console.WriteLine(MyChar.Peek()); // Peek function is used to display the first element in the queue without removing it.

        foreach (var item in MyChar)
        {
            Console.Write(item);
        }
    }
}
