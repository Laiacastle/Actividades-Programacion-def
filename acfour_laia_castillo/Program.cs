// See https://aka.ms/new-console-template for more information
using System;
namespace AcFor
{
    public class AcFor
    {
        public static void Main()
        {
            const string MsgOne = "Write the numbers you want to almacenar";
            const string Error = "WrongFormat";
            const string MsgEnd = "the numbers are: ";

            Console.WriteLine(MsgOne);
            try
            {
                int num = Convert.ToInt32(Console.ReadLine())
            }
        }
    }
}
