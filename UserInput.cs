using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInput
    {
        public static int MenuInput()
        {
            Console.WriteLine("\nVälj räknesätt: \n");
            Console.WriteLine("[1] Addition ");
            Console.WriteLine("[2] Subtraktion ");
            Console.WriteLine("[3] Multiplikation ");
            Console.WriteLine("[4] Division ");
            Console.WriteLine("[5] Se historik ");
            Console.WriteLine("[6] Avsluta");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[] MakeIntArray(int num1, int num2)
        {
            int[] numbers = [num1, num2];
            return numbers;
        }
    }
}
