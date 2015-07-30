using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace auseTxtGame
{
    class Program
    {
        public static void trixPrint(String trixtalk)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("trix: " + trixtalk);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
           
        }
        //usage systemPrint(string)
        public static void systemPrint(String systemInfo)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(systemInfo);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void playerPrint(String playertalk)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("you: " + playertalk);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            
        }


        public static void print(String s)
        {
            Console.WriteLine(s);
        }

        public static void setup()
        {
            //sets the console title text
            Console.Title = "ause text game";
            //changes the color of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            print("right click the console, go to fonts and set the size to 24.");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void Main(string[] args)
        {
            Boolean gameOn = true;
            string input;


            //does the setup() arguments
            //usage setup()
            setup();
            //prints you the intro
            //usage intro.startIntro()
           // intro.startIntro();
            trixPrint("type help to see what you can do.");
            while(gameOn)
            {
                trixPrint("what do you want to do?");
                input = Console.ReadLine();
                switch(input)
                {
                    case "go exploring":
                        break;

                    case "plant a seed":
                        break;

                    case "inventory":
                        inventorytest.Program.invent();
                        break;

                    case "":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
