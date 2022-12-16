using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string upc = "";

        List<string> list = new List<string>();
        for (int i = 0; i < text.Length; i++)
        {
            if (i + 7 < text.Length)
            {
                if (text[i] == '<' && text[i + 1] == 'u' && text[i + 2] == 'p' && text[i + 3] == 'c' &&
                    text[i + 4] == 'a' && text[i + 5] == 's' && text[i + 6] == 'e' && text[i + 7] == '>')
                {
                    for (int j = 0; j < text.Length; i++)
                    {
                        if (j + 8 < text.Length && text[i + 1] == '<' && text[i + 2] == '/' && text[i + 2] == 'u' &&
                            text[i + 3] == 'p' && text[i + 4] == 'c' && text[i + 5] == 'a' && text[i + 6] == 's'
                            && text[i + 7] == 'e' && text[i + 8] == '>')
                        {
                            i = j;
                        }
                        upc += text[j];
                        list.Add(upc);
                    }
                }

            }
        }

        foreach (string s in list)
        {
            if (text.Contains(s))
            {
                text = text.Replace(s, s.ToUpper());
            }
        }

        text = text.Replace("<uparcase>", "");
        text = text.Replace("</uparcase>", "");

        Console.WriteLine(text);

        Console.ReadLine();
    }
}
