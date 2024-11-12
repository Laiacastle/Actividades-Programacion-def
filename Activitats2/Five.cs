using System;


/*namespace Activitats2
{
    public class One
    {
        public static string Natural()
        {
            int num = Convert.ToInt32(Console.ReadLine());          
            int attemps =  2;
            while (num < 0 && attemps > 0)
            {
                
                Console.WriteLine($"Wrong number you have {attemps} trys left");
                attemps--;
                num = Convert.ToInt32(Console.ReadLine());
                if (attemps <= 0 && num < 0)
                {
                    return "You lost...";
                }
            } 
            return "Nice job";
            

        }

        public static void Main()
        {
            const string MsgOne = "Write a number please";
            const string MsgError = "Wrong format";

            Console.WriteLine(MsgOne);
            try
            {
                Console.WriteLine(Natural());
            }
            catch (Exception)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
*/