using System;


/*namespace Activitats2
{
    public class Four
    {
        public static bool BiggerOneHundred(int num, int min, int max)
        {
            return num > min && num < max;
        }

        public static void Main()
        {
            const string MsgDes = "Do you wnat to put the default?";
            const string MsgOne = "Write a number please";
            const string MsgTwo = "Write the minimum range";
            const string MsgThree = "Write the maximum range";
            const string MsgError = "Wrong format";
            const string MsgEnd = "Your number is bigger than {0} and smaller than {1}";

            int num, max, min;
            char decision;

            
            try
            {
                do{
                    Console.WriteLine(MsgDes);
                    decision = Converto.ToChar(Conole.ReadLine());
                }while(decision != 'y' && decision != 'n');

                Console.WriteLine(MsgOne);
                num = Convert.ToInt32(Console.ReadLine());    
                Console.WriteLine(MsgTwo);
                if (decision == y)
                {
                    min = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine(MsgThree);
                    max = Convert.ToInt32(Console.ReadLine()); 
                }
                else
                {
                    min == 0;
                    max== 100;
                }
                if (BiggerOneHundred(num, min, max))
                {
                    Console.WriteLine(MsgEnd, min, max);
                }
                else
                {
                    Console.WriteLine(MsgEnd, min, max);
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