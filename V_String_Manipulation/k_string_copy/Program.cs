﻿namespace k_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string name = "Ram";
        // string myName = string.Copy(name); // not recomended to use
        string myName = new string(name);
        Console.WriteLine(name);
        Console.WriteLine(myName);
    }
}
