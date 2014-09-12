using System;

class Squence1000numbers
{
    static void Main()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }

        Console.ReadLine();
    }
}