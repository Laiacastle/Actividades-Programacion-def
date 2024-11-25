// See https://aka.ms/new-console-template for more information
using System;
namespace AcFor
{

    public class AcFor
    {
        public static void Main()
        {
            const string MsgOne = "Write the numbers you want to almacenar", 
                MsgNums = "Write your number please", 
                Error = "WrongFormat", 
                MsgEnd = "the numbers are: ";
            

            Console.WriteLine(MsgOne);
            try
            {
                //pregunta cuants nombres vol emmegatzenar
                int cuantitatNums = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[cuantitatNums];

                //pregunta la llista
                for (int i = 0; i< cuantitatNums; i++)
                {
                    Console.WriteLine(MsgNums);
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                //printa la llista
                Console.WriteLine(MsgEnd);
                for (int i = 0; i < cuantitatNums; i++)
                {
                   Console.WriteLine(nums[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
