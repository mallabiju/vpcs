namespace g_type_conversion_int_parse_class;
class Program
{
    static void Main(string[] args)
    {
        string stringValue = "123";
        int intValue = int.Parse(stringValue);


        System.Console.WriteLine("String Value: " + stringValue);
        System.Console.WriteLine("Converted Integer Value: " + intValue);

        int num = 100;
        // Adding num(100) and Converted Integer Value(123)
        int sum = num + intValue;
        System.Console.WriteLine("The sum of " + num + " and " + intValue + " is = " + sum);

    }
}
