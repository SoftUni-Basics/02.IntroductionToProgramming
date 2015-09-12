/*
    Create console application that prints your first and last name, each at a separate line.
*/

using System;

class PrintFullName
{
    static void Main()
    {
        string firstName = "Bob";
        string lastName = "Dylan";
        string fullName = firstName + " " + lastName;

        Console.WriteLine(fullName);
    }
}
