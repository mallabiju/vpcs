namespace e_generic_stack;

class Program
{
    static void Main(string[] args)
    {
        // Stack<int> MyNums = new Stack<int>();
        // MyNums.Push(12);
        // MyNums.Push(2);
        // MyNums.Push(23);
        // MyNums.Push(45);
        // MyNums.Push(123);
        // MyNums.Push(6);
        // MyNums.Push(0);
        // MyNums.Push(9);

        int[] numArr = new int[] { 12, 34, 56, 78, 8, 9, 34 };
        Stack<int> MyNums = new Stack<int>(numArr);

        Console.WriteLine("No of elements in stack = " + MyNums.Count);

        if (MyNums.Count > 0)
        {
            MyNums.Pop();
            foreach (var item in MyNums)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("There is nothing in Stack.");
        }
    }
}
