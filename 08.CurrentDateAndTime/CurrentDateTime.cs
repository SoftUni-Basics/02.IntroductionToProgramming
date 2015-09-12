/*
    Create a console application that prints the current date and time. Find in Internet how.
 */

using System;

class CurrentDateTime
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        string format = "HH:mm:ss  dd/MMM/yyyy";
        Console.WriteLine(time.ToString(format));
    }
}
