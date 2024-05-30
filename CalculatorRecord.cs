using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRecord
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public char Sign { get; set; }
        public int Result { get; set; }

        public static void PrintRecords(List<CalculatorRecord> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.Num1);
                Console.Write(item.Sign);
                Console.Write(item.Num2);
                Console.Write("=");
                Console.Write(item.Result);
                Console.WriteLine();
            }
        }
    }
}
