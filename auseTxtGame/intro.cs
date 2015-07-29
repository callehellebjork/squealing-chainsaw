﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auseTxtGame
{
    class intro
    {
        //makes "trix" talk in a special color and put the trix prefix before the string
        //usage trixPrint(sting)
       public static void trixPrint(String trixtalk)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("trix: " + trixtalk);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //usage systemPrint(string)
        public static void systemPrint(String systemInfo)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(systemInfo);
            Console.ForegroundColor = ConsoleColor.Green;
        }
       public static void playerPrint(String playertalk)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("you: " + playertalk);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void startIntro()
        {
            systemPrint("press any key if you are ready!");
            Console.ReadKey();
            Console.Clear();
            trixPrint("hello traveler");

        }
    }
}
