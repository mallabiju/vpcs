namespace a_generic_list;

class Program
{
    static void Main(string[] args)
    {
        // List<int> nums = new List<int>();

        // var nums = new List<int>();
        // nums.Add(23);
        // nums.Add(3);
        // nums.Add(20);
        // nums.Add(9);

        var nums = new List<int>() { 23, 45, 67, 89, 9 };

        nums.Insert(3, 123);
        nums.Remove(67); // removes the particular element
        nums.RemoveAt(4); // removes the item at position

        nums.Clear();

        // nums.ForEach(nums=>Console.WriteLine(nums));

        // Console.WriteLine(nums[0]);
        // Console.WriteLine(nums[1]);
        // Console.WriteLine(nums[2]);
        // Console.WriteLine(nums[3]);

        // for (int i = 0; i < 4; i++)
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
