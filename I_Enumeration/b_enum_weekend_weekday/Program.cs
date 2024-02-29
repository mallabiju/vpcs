namespace b_enum_weekend_weekday;

class Program
{
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    static void Main(string[] args)
    {
        var today = Days.Saturday;
        if (today == Days.Saturday || today == Days.Friday)
        {
            Console.WriteLine("Hello ! It's weekend, let's have fun");
        }
        else
        {
            Console.WriteLine("It's weekday... I'm working.");
        }
    }
}
