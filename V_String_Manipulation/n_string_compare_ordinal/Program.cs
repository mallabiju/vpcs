﻿namespace n_string_compare_ordinal;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = "hello";
        string s3 = "Hello";
        string s4 = "Sanothimi";
        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s2, s3));
        Console.WriteLine(s1.CompareTo(s4));
    }
}
