using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please enter your Birth Date in format (dd.mm.yyyy):"); //Please make sure your regional settings are according to the format
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        TimeSpan age = DateTime.Now - birthday;
        TimeSpan after10years = age.Add(DateTime.Now.AddYears(10) - DateTime.Now);
        Console.WriteLine("You are {0} years old", Math.Truncate(age.TotalDays /365.25));
        Console.WriteLine("After 10 years you will be {0} years old", Math.Truncate(after10years.TotalDays /365.25));
    }
}
