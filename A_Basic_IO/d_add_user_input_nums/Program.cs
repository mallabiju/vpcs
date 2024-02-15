namespace d_add_user_input_nums;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, (a + b));
    }
}
