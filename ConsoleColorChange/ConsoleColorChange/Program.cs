using System;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleColorChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.Clear();
            string input;
            //string currentApplication = Process.GetCurrentProcess().MainModule.FileName; //We get the file's location (and it's name) for the restart.
            bool exit = false;
            Console.WriteLine("Welcome in the Console!\n");
            Console.WriteLine("Write /help for the commands.");
            //Console.WriteLine(currentApplication);
            input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(input);
            while(!exit)
            {

                switch(input)
                {
                    case "/red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "/white":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "/blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "/green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "/help":
                        Console.WriteLine("Console commands:\n/red - Change the font color to red.");
                        Console.WriteLine("/blue - Change the font color to blue.");
                        Console.WriteLine("/green - Change the font color to green.");
                        Console.WriteLine("/white - Change the font color to white.\n");
                        Console.WriteLine("/clear - Clear the Console.\n");
                        Console.WriteLine("/restart - Restart the program.");
                        Console.WriteLine("/exit - Leave the program.");
                        break;
                    case "/exit":
                        exit = true;
                        break;
                    case "/restart":
                        Process.Start(Environment.ProcessPath); //alternative variable for get the location of the file on line 15
                        Environment.Exit(0);
                        break;
                    case "/clear":
                        Console.Clear();
                        break;
                }
                if(input != "/exit")
                input = Console.ReadLine();
            }
        }
    }
}
