// See https://aka.ms/new-console-template for more information
using System;
namespace AcFor
{

    public class AcFor
    {
        public static int[] OrderDescArr(int[] nums){
            for (int i = 0; i < marks.Length - 1; i++)
            {
	            for (int j = i + 1; j < marks.Length; j++)
	            {
	                //si el primer numero es mes petit que el segon intercanvien posicions
		            if (nums[i] < nums[j])
		            {
			            int aux = marks[i];
			            nums[i] = nums[j];
			            nums[j] = aux;
		            }
            	}

             }
        }
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
                   Console.Write($"{nums[i]}");
                }
                
                //printa la llista ordenada descendent
                Console.WriteLine(MsgEnd);
                for (int i = 0; i < cuantitatNums; i++)
                {
                   Console.Write($"{OrderDescArr(nums)[i]} ");
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
