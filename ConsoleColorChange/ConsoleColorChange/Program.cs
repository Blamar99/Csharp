using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleColorChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManage f = new FileManage();
            f.LoadSaves();
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
                        f.DeleteFile();
                        Console.ForegroundColor = ConsoleColor.Red;
                        f.WriteFile(input);
                        break;
                    case "/white":
                        f.DeleteFile();
                        Console.ForegroundColor = ConsoleColor.White;
                        f.WriteFile(input);
                        break;
                    case "/blue":
                        f.DeleteFile();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        f.WriteFile(input);
                        break;
                    case "/green":
                        f.DeleteFile();
                        Console.ForegroundColor = ConsoleColor.Green;
                        f.WriteFile(input);
                        break;
                    case "/help":
                        Console.WriteLine("Console commands:\n/red - Change the font color to red.");
                        Console.WriteLine("/blue - Change the font color to blue.");
                        Console.WriteLine("/green - Change the font color to green.");
                        Console.WriteLine("/white - Change the font color to white.\n");
                        Console.WriteLine("/clear - Clear the Console.\n");
                        Console.WriteLine("/restart - Restart the program.");
                        Console.WriteLine("/exit or /stop - Leave the program.");
                        break;
                    case "/exit":
                    case "/stop":
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
                if(input != "/exit" && input != "/stop")
                input = Console.ReadLine();
            }
        }
    }
}
