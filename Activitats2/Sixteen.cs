using System;
using System.Reflection.Metadata;


/*namespace Activitats2
{
    public class Sixteen
    {
        public static int Roman(char rom)
        {
            
            int num;
            
            rom = char.ToUpper(rom);
            switch (rom)
            {
                case 'I': num = 1; break;
                case 'V': num = 5; break;
                case 'X': num = 10; break;
                case 'L': num = 50; break;
                case 'C': num = 100; break;
                case 'D': num = 500; break;
                default: num = 1000; break;
            }
            
            return num;
        }
        public static int LookString(string rom)
        {
            int num = Roman(rom[0]);
            int numant = num;
            int aux = num;
            int nums = 0;
            for (int i = 1; i < rom.Length; i++)
            {
                               
                if (nums == 3)
                {
                    num = num + num;
                    nums = 0;
                }
                if (numant < num)
                {
                    numant = num;
                    aux = aux + num - numant; //
                    
                }
                else if (numant > num)
                {
                    numant = numant + num;
                    aux = aux + numant;//agrupa si son iguales o el anterior es mayor
                    
                }
                else
                {
                    nums ++;
                    numant += num;
                }

                num = Roman(rom[i]);


            }

            return aux;
        }
        public static void Main()
        {
            const string MsgOne = "Write a number in roman please";
            const string MsgError = "Wrong Format";
            const string MsgEnd = "You number is : {0}";
            Console.WriteLine(MsgOne);
            try
            {
                string roman = "I";
                do
                {

                    roman = Console.ReadLine();
                } while (roman == null);

                Console.WriteLine(MsgEnd, LookString(roman));

            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}
*/