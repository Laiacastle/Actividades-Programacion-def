using System;


/*namespace Activitats2
{
    public class Seventeen
    {
        public static int[] Numbers(int lenght)
        {
            int[] numbers = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                while (numbers[i] < 0)
                {
                    Console.WriteLine("That number is not natural");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            return numbers;
        }
        public static void Main()
        {
            const string MsgOne = "Write the amount of numbers you want to save, please";
            const string MsgTwo = "Write a number please";
            const string MsgError = "Wrong format";
            const string MsgEnd = "The numbers are: ";

            Console.WriteLine(MsgOne);
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine(MsgTwo);
                int[] numbers = Numbers(num);

                Console.Write(MsgEnd);
                for (int i = 0; i<num; i++)
                {
                    Console.Write($"{numbers[i]} ");
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