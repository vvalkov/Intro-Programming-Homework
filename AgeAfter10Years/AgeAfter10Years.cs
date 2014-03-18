using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please enter your Birth Date in format (dd.mm.yyyy):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        long age = DateTime.Now.Subtract(birthday).Ticks;
        if ((DateTime.Now.Month > birthday.Month || 
            (DateTime.Now.Month == birthday.Month) && 
            DateTime.Now.Day > birthday.Day))
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

//using System;

//class AgeAfter10Years
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter your Birth Date in format (dd.mm.yyyy):");
//        DateTime birthday = DateTime.Parse(Console.ReadLine());
//        TimeSpan age = DateTime.Now - birthday;
//        TimeSpan after10years = DateTime.Now.AddYears(10) - DateTime.Now;
//        Console.WriteLine("You are {0:MM.dd/yy} years old", age.TotalDays / 365.2);
//        Console.WriteLine("After 10 years you will be {0:} years old", age.Add(after10years));
//    }
//}