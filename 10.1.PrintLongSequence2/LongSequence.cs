/*
    Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
*/

using System;

class LongSequence
{
    static void Main()
    {
        int start = 2;
        int count = 1000;

        for (int i = start; i < (start + count); i+=2)
        {
            Console.Write("{0}, {1}, ", i, ~(i));
        }
        Console.WriteLine("\b\b ");
    }
}
