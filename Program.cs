using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auseTxtGame
{
    class Program
    {
        public static void print(String s)
        {
            Console.WriteLine(s);
        }

        public static void setup()
        {
            //sets the console title text
            Console.Title = "ause text game";
            //changes the color of the text
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            print("right click the console, go to fonts and set the size to 24.");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void Main(string[] args)
        {
            //does the setup() arguments
            //usage setup()
            setup();
            //prints you the intro
            //usage intro.startIntro()
            intro.startIntro();
        }
    }
}
