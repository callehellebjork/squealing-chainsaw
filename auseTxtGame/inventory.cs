using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorytest
{
    class Program
    {
        public static void invent()
        {
            string[] inv = new string[20];
            inv[0] = "empty";
            inv[1] = "empty";
            inv[2] = "empty";
            inv[3] = "empty";
            inv[4] = "empty";
            inv[5] = "empty";
            inv[6] = "empty";
            inv[7] = "empty";
            inv[8] = "empty";
            inv[9] = "empty";
            inv[10] = "empty";
            inv[11] = "empty";
            inv[12] = "empty";
            inv[13] = "empty";
            inv[14] = "empty";
            inv[15] = "empty";
            inv[16] = "empty";
            inv[17] = "empty";
            inv[18] = "empty";
            inv[19] = "empty";
            
           
                Console.Write("show the item in slot: ");
                string preInvint = Console.ReadLine();
                int invint = Convert.ToInt32(preInvint);
                invint--;

                try
                {
                  Console.WriteLine(inv[invint]);
                    Console.WriteLine("");
                }
                catch
                {

                }
            }
        }
    
    }

