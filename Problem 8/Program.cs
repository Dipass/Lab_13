using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string comand = Console.ReadLine();
        int check = 0;
        List<string> list = new();

        string[] words = comand.Split(' ', ',', '.', '?', '!');

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {

                if (word[i] == word[word.Length - i - 1])
                {
                    list.Add(word);
                }
            }
        }
        
        foreach (string l in list)
        {
            Console.WriteLine(l);
        }
        

        Console.ReadLine();
    }
}
