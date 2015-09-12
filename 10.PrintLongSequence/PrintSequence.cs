/*
    Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
*/

using System;

class PrintSequence
    {
        static void Main()
        {
            int start = 2;
            int count = 1000;

            for (int i = start; i < (start + count); i++)
            {
                int temp = (i % 2 == 1) ? i*(-1) : i;
                Console.Write(temp);
                if (i < (start + count)-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
