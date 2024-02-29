namespace c_enum_user_input;

class Program
{
    static void Main(string[] args)
    {
        String name;
        Day day;
        Console.WriteLine("Enter your friend's name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter day (0-6) : ");
        int index = int.Parse(Console.ReadLine());
        day = (Day)index;
        Console.WriteLine("Hello " + name + ", today is " + day + ".");
        Console.ReadLine();
    }
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}
