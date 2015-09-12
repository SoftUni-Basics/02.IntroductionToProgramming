/*
    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter Birth date in format \"Day-Month-Year\".\r\n   Examples:\t 01.01.1995, 25/11/96 or 1 1 2001 etc.");
        string input = Convert.ToString(Console.ReadLine());
        
        DateTime dateTime;
        if (DateTime.TryParse(input, out dateTime))
        {
            int result = DateTime.Compare(dateTime, DateTime.Now);
            if (result >= 0)
            {
                Console.WriteLine("Enter real birth date.");
                return;
            }
            else
            {
                DateTime today = DateTime.Now;
                TimeSpan span = today - dateTime;
                DateTime ageNow = (DateTime.MinValue + span);
                ageNow = ageNow.AddYears(-1);
                DateTime ageAfter = ageNow.AddYears(10);

                Console.WriteLine("\r\nNow: {0:yy}", ageNow);
                Console.WriteLine("After 10 years: {0:yy}\r\n", ageAfter);
            }
        }
        else
        {
            Console.WriteLine("Invalid format.");
        }
    }
}
