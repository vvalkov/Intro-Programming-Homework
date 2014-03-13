using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2, j = -3; i < 12; i = i + 2, j = j - 2)
        {
            Console.Write(i + ", " + j + ", ");
        }
        Console.Write(12);
    }
}