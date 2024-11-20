using System;

/*namespace Activitats2
{
    public class Sixteen
    {
        public static int Roman(string roman)
        {
            roman = roman.ToUpper();
            int num = 0;
            for(int i = 0; i<roman.Length; i++)
            {
                
                switch (roman[i])
                {
                    case 'I': num += (i < roman.Length - 1 && (roman[i + 1] == 'X' || roman[i + 1] == 'V')) ? -1 : 1; break; // si despues hya un 10 o un 5 se resta, si no se suma
                    case 'V': num += 5; break;
                    case 'X': num += (i < roman.Length - 1 && (roman[i + 1] == 'C' || roman[i + 1] == 'L')) ? -10 : 10; break; //si despues hay 100 o 50 se resta si no se suma
                    case 'L': num += 50; break;
                    case 'C': num += (i < roman.Length - 1 && (roman[i + 1] == 'D' || roman[i + 1] == 'M')) ? -100 : 100; break; //si despues hay 500 o 1000 se resta y si no se suma
                    case 'D': num += 500; break;
                    case 'M': num += 1000; break;
                }
            }
            return num;
        }
        public static void Main()
        {
            const string MsgStart = "Write a roman number please";
            const string MsgError = "Wrong Format";
            const string MsgFin = "You number is: {0}";

            Console.WriteLine(MsgStart);
            try
            {
                string roman = Console.ReadLine();
                int num = Roman(roman);
                Console.WriteLine(MsgFin, num);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
            }

        }
    }
}
*/