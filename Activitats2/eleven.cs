using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Activitats2
{
    internal class Eleven
    {
        public static void Main()
        {
            const string MsgOne = "What amount of items you want?";
            const string MsgTwo = "Write the items";
            const string MsgError = "Error, wrong format";
            const string MsgEnd = "--------List----------";
            const string MsgTrys = "That's out of range, you have {0} attems left";
            const string MsgLost = "You lost all your trys";
            int num, trys = 3;
            try
            {
                Console.WriteLine(MsgOne);
                num = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine(MsgTrys, trys);
                    Console.WriteLine(MsgOne);
                    num = Convert.ToInt32(Console.ReadLine());
                    trys--;
                } while ((num < 15 || num > 100) && trys > 0);
                if (trys == 0)
                {
                    Console.WriteLine(MsgLost);
                }
                else
                {
                    string[] buy = new string[num];
                    Console.WriteLine(MsgTwo);
            
                    for (int i = 0; i < buy.Length; i++)
                    {
                        buy[i] = Console.ReadLine();
                    }
                    Console.WriteLine(MsgEnd);
                    for (int i = 0; i < buy.Length; i++)
                    {
                        Console.WriteLine($"- {buy[i]}");
                    }
                    }
                
            }
            catch (Exception)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
*/