﻿namespace d_string_builder_remove;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello ,Welcome to Sanothimi", 20);
        s.Remove(6, 9);
        Console.WriteLine(s);
    }
}
