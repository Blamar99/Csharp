using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

namespace ConsoleColorChange
{
    internal class FileManage
    {

        private string filePath = Path.GetFullPath("save.txt");
        public void LoadSaves()
        {
            String line;
            if(File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                line = sr.ReadLine();
                sr.Close();
            }
            else
            {
                File.Create(filePath);
                StreamReader sr = new StreamReader(filePath);
                line = sr.ReadLine();
                sr.Close();
            }

            switch (line)
            {
                case "sv_red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "sv_white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "sv_blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "sv_green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        public void DeleteFile()
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public void WriteFile(string input)
        {
            StreamWriter sw = new StreamWriter(filePath);
            switch(input)
            {
                case "/red":
                    sw.WriteLine("sv_red");
                    break;
                case "/white":
                    sw.WriteLine("sv_white");
                    break;
                case "/blue":
                    sw.WriteLine("sv_blue");
                    break;
                case "/green":
                    sw.WriteLine("sv_green");
                    break;
            }

            sw.Close();
        }
    }
}
