namespace ConsoleColorChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool exit = false;
            Console.WriteLine("Welcome in the Console!\n");
            Console.WriteLine("Write /help for the commands.");
                input = Console.ReadLine();
            Console.Clear();
            while(!exit)
            {

                switch(input)
                {
                    case "/red":
                        Console.ForegroundColor = ConsoleColor.Red;
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
                        Console.WriteLine("/clear - Clear the Console.\n");
                        Console.WriteLine("/exit - Leave the program.");
                        break;
                    case "/exit":
                        exit = true;
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
