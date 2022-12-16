using System;

class Program
{
    static void Main()
    {
        string start = Console.ReadLine();
        string finish = " ";

        for (int i = start.Length - 1; i > start.Length / 2; i--)
        {
            finish += start[i];
        }
        for (int i = start.Length / 2; i >= 0; i--)
        {
            finish += start[i];
        }

        Console.WriteLine(finish);

        Console.ReadLine();
    }
}
