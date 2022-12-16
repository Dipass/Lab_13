using System;

class Program
{
    static void Main()
    {
        string email = Console.ReadLine();
        string text = Console.ReadLine();
        string newEmail = " ";
        int newdogs = 0;

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] != '@')
            {
                newEmail += newdogs == 0 ? '*' : email[i];
            }
            else
            {
                newdogs++;
                newEmail = email;
            }
        }
        text = text.Replace(email, newEmail);

        Console.WriteLine(text);

        Console.ReadLine();
    }
}
