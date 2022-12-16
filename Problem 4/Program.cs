using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        string[] text = Console.ReadLine().Split('.','!','?',' ', '-', '_', ',');

        List<string> newText = new();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains(word))
            {
                newText.Add(text[i].Trim());
            }
        }
        
        foreach (string tex in newText)
        {
            Console.WriteLine(tex);
        }
        Console.ReadKey();
    }
}
