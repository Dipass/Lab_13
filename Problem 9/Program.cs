using System;


class Program
{
    static void Main()
    {
        string comand = Console.ReadLine();
        

        string[] firstUp = comand.Split(' ', '.', ',', '?', '!', ';');

        foreach (string fi in firstUp)
        {
            string text = "";
            for (int i = 0; i < fi.Length; i++)
            {
                text += fi[i];
                if (i == 0)
                {
                    text = text.ToUpper();
                }
                comand = comand.Replace(comand, text);
            }
            Console.Write(comand + " ");
        }


        Console.ReadLine();
    }
}


