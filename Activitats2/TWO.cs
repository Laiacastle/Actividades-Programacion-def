using System;


/*namespace Activitats2
{
    public class Two
    {
        public static int Potencia(int num, int exp)
        {
            for (int i = exp-1; i>0; i--)
            {
                num *= num;
            }
            if (num == 0)
            {
                Console.WriteLine("Your number id too big");
                
            }
            return num;

            
        }

        public static void Main()
        {
            const string MsgOne = "Write a number please";
            const string MsgTwo = "Write the exp please";
            const string MsgError = "Wrong format";
            const string MsgEnd = "{0}^{1} = {2}";
            

            int num, exp;



            Console.WriteLine(MsgOne);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgTwo);
                exp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(MsgEnd, num, exp, Potencia(num, exp));
            }
            catch (Exception)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
*/