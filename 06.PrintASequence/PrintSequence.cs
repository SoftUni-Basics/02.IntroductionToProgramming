/*
    Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

using System;

class PrintSequence
    {
        static void Main()
        {
            int start = 2;
            int count = 10;

            for (int i = start; i < (start + count); i++)
            {
                int temp = i;
                int mask = 1;
                if (i % 2 != 1)
                {
                    temp = i * (-1);
                }
                Console.Write(temp);
                
                if (i < (start + count) - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
