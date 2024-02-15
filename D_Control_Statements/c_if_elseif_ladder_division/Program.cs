namespace c_if_elseif_ladder_division;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks in Nepali:");
        int nepali = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Englidh:");
        int english = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Sciece:");
        int science = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Maths:");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Computer:");
        int computer = Convert.ToInt32(Console.ReadLine());

        int total = nepali + english + science + maths + computer;
        int percentage = total / 5;
        Console.WriteLine();
        Console.WriteLine("You've got " + percentage + "%");

        if (percentage > 79)
        {
            Console.WriteLine("Distinction");
        }
        else if (percentage > 60)
        {
            Console.WriteLine("First");
        }
        else if (percentage > 45)
        {
            Console.WriteLine("Second");
        }
        else if (percentage > 32)
        {
            Console.WriteLine("Third");
        }
        else if (percentage < 32)
        {
            Console.WriteLine("Better luck next time");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}