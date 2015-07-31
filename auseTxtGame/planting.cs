using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auseTxtGame
{
    class planting
    {
        public static void plant()
        {
            String[] seeds = new string[4];
            seeds[0] = "empty";
            seeds[1] = "empty";
            seeds[2] = "empty";
            seeds[3] = "cuccumber";
            seeds[4] = "watermelom";
            try {
              
                Program.trixPrint("what seed do you want to plant?");
                Console.Write(seeds[0] + seeds[1] +seeds[2]+ seeds[3]+ seeds[4]);
            }
            catch
            {

            }
        }


    }
}
