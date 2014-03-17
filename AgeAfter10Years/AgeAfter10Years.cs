using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please enter your Birth Date in format (dd.mm.yyyy):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        long age = DateTime.Now.Subtract(birthday).Ticks;
        if (birthday.Month <= DateTime.Today.Month && birthday.Date <= DateTime.Today.Date) ^ ((birthday.Month < DateTime.Today.Month && birthday.Date > DateTime.Today.Date));
        {
            Console.WriteLine("You are {0} years old", new DateTime(age).Year);
            Console.WriteLine("After 10 years you will be {0} years old", new DateTime(age).AddYears(10).Year);
        }
        else
        {
            Console.WriteLine("You are {0} years old", new DateTime(age).Year - 1);
            Console.WriteLine("After 10 years you will be {0} years old", new DateTime(age).AddYears(9).Year);
        }
    }
}
          
