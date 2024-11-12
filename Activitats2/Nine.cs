using System;
using System.Globalization;


/*namespace Activitats2
{
    public class Nine
    {
        public static int Digit(int num)
        {
            int count = 0;
           
            for(int i = num; i>0; i /= 10)
            {
                Console.WriteLine(i);
                count++;
               
            }
            
            return count;
        }
        public static void EvenOdd( ref int evens, ref int odds, int num)
        {
            int digT = 0;
            for (int i = num; i > 0; i/=10)
            {
                digT = i % 10;
                if (digT % 2 == 0)
                {
                    evens = evens + digT;
                }
                else
                {
                    odds = odds + digT;
                }
            }

        }
        public static void Main()
        {
            const string MsgOne = "Write a number please";
            const string MsgError = "Wrong Format";
            const string MsgOdds = "The total of the odds numbers are: {0}";
            const string MsgEven = "The total of the evens numbers are: {0}";
            const string MsgNum = "The total digits are: {0}";

            int evens = 0, odds = 0 ;
            
            Console.WriteLine(MsgOne);         

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int figures = Digit(num);
                Console.WriteLine(MsgNum, num );
                EvenOdd(ref evens, ref odds, num);
                Console.WriteLine(MsgEven, evens);
                Console.WriteLine(MsgOdds, odds);
            }
            catch (Exception)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
*/