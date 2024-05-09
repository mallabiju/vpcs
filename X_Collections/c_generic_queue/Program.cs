namespace c_generic_queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(12);
        nums.Enqueue(2);
        nums.Enqueue(24);
        nums.Enqueue(67);
        nums.Enqueue(4);
        nums.Enqueue(234);
        nums.Enqueue(66);
        nums.Enqueue(890);
        nums.Enqueue(5);
        nums.Enqueue(1);
        nums.Enqueue(45);

        nums.Dequeue();

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }

        // Contains() method checks whether an item exists in a queue or not
        Console.WriteLine(nums.Contains(67)); //true
        Console.WriteLine(nums.Contains(77)); //false
    }
}
