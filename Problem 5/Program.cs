using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string URL = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";


        if (Regex.IsMatch(URL, @"(\w|\W)+://(\w|\W)+"))
        {
            for (int i = 0; i < URL.Length; i++)
            {
                if (i + 1 < URL.Length && URL[i] != '/' && URL[i + 1] != '/')
                {
                    protocol += URL[i];
                }
                else
                {
                    break;
                }
            }
        }
        if (Regex.IsMatch(URL, @"[A-Z,a-z,0-9]+/(\w|\W)+"))
        {
            for (int i = protocol.Length + 3; i < URL.Length; i++)
            {
                if (i + 2 < URL.Length && URL[i] != '/')
                {
                    server +=URL[i];
                }
                else
                {
                    break;
                }
            }
            for (int i = protocol.Length + 3 + server.Length + 1; i < URL.Length; i++)
            {
                resource += URL[i];
            }                
        }

        Console.WriteLine("[protocol] = \"" + protocol + "\"");
        Console.WriteLine("[server] = \"" + server + "\"");
        Console.WriteLine("[resource] = \"" + resource + "\"");

        Console.ReadKey();
    }
}



