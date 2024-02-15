namespace e_reference_type;

class Program
{
    static void Main(string[] args)
    {
        // declaring string 
        string a = "Hello";

        //append in a 
        a += " Sanothimi";
        a = a + " Bhaktapur";
        Console.WriteLine(a);

        // declare object obj 
        object obj;
        obj = 20;
        Console.WriteLine(obj);
        // to show type of object 
        // using GetType() 
        Console.WriteLine(obj.GetType());

    }
}
