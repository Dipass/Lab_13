using System;

class Program
{
    static void Main()
    {
        string comand = Console.ReadLine();

        if (comand.Length > 20)
        {
            comand = comand.Substring(0, 20);
        }
        else if (comand.Length < 20)
        {
            comand = comand.PadRight(20, '*');
        }
        Console.WriteLine(comand);

        Console.ReadLine();
    }
}
