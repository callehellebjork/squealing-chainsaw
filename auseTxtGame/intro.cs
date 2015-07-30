using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace auseTxtGame
{
    class intro
    {
        


        //makes "trix" talk in a special color and put the trix prefix before the string
        //usage trixPrint(sting, int)
        public static void trixPrint(String trixtalk, Int32 delay)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("trix: " + trixtalk);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Thread.Sleep(delay * 1000);
        }
        //usage systemPrint(string)
        public static void systemPrint(String systemInfo)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(systemInfo);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
       public static void playerPrint(String playertalk, Int32 delay)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("you: " + playertalk);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Thread.Sleep(delay * 1000);
        }

        public static void startIntro()
        {
            systemPrint("press any key if you are ready!");
            Console.ReadKey();
            Console.Clear();
            trixPrint("hello traveler", 0);            
            playerPrint("who are you?", 1);            
            trixPrint("im trix and your guide to this new world", 3);
            trixPrint("your memory has been erased and you was chosen to fortify this island", 4);
            trixPrint("lets start by looking around!",  0);
            systemPrint("type 'look' to look around");
           
            string inputLook = Console.ReadLine();
            if (inputLook == "look")
             {
                trixPrint("i see a cow and a small house maybe we can live there!", 3);
                systemPrint("type 'go to home' to go the the house");
                string inputHome = Console.ReadLine();
                if (inputHome == "go to home")
                {
                    trixPrint("this is a pretty nice home!", 2);
                    playerPrint("yeah, it could use some decoration tho.", 2);
                    trixPrint("lets check out the garden!", 2);
                    trixPrint("ohh look there is a gardening house here, maybe we could plant something here", 3);
                    trixPrint("check what seeds we have!", 1);
                    systemPrint("type 'check seeds' to look what seeds you have");
                    string inputSeed = Console.ReadLine();
                    if (inputSeed == "check seeds")
                    {
                        string seed1 = "Cucumber, ", seed2 = "grapes, ", seed3 = "melon, ", seed4 = "raspberry";
                        int seedPlanted;

                        trixPrint("looks like you have " +seed1+seed2+seed3+seed4, 1);
                        trixPrint("well, what do you want to plant+", 0);
                        string plantChoise = Console.ReadLine();
                        switch(plantChoise)
                        {
                            case "cucumber":
                                seedPlanted = 0;
                                break;
                            case "grapes":
                                seedPlanted = 1;
                                break;
                            case "melon":
                                seedPlanted = 2;
                                break;
                            case "raspberry":
                                seedPlanted = 3;
                                break;
                            default:
                                seedPlanted = 4;
                                break;
                        }
                        trixPrint("you need to water the seed!", 2);
                        systemPrint("type 'water plant' to water the plant");
                        string inputWater = Console.ReadLine();
                        if (inputWater == "water plant")
                        {
                            trixPrint("now the plant will grow!", 1);
                            trixPrint("now lets go explore the rest of the island!", 2);
                        }

                    }


                }
             }
            trixPrint("come on lets go explore!", 1);
            systemPrint("type 'go explore' to start exploring!");   
        }
    }
}
