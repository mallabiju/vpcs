namespace g_array_search_a_num;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        //single dimensional array to find a number from an array
        int[] myarray = new int[] { 45, 67, 8, 9, 90, 23, 46, 78, 55 };

        Console.WriteLine("Enter a number to check :");
        int num = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < myarray.Length; i++)
        {
            if (num == myarray[i])
            {
                found = true;
                break;
            }
        }
        if (found == true)
        {
            Console.WriteLine("Number found");
        }
        else
        {
            Console.WriteLine("Number not found");
        }
    }
}
