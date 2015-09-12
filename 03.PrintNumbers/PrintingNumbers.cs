/*
    Write a program to print the numbers 1, 101 and 1001, each at a separate line. Name the program correctly. You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program. 
 */

using System;

class PrintingNumbers
{
    static void Main()
    {
        string result = String.Empty;
        
        for (int i = 0; i <= 2; i++)
        {
            result = Math.Pow(10, i).ToString();
            if (Math.Pow(10, i) > 1)
            {
                result = result + 1;
            }
            Console.WriteLine(result);
        }
    }
}
