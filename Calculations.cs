using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        int result = 0;
        char sign = '.';
        public CalculatorRecord Sum(int[] numbers)
        {
            result = numbers[0] + numbers[1];
            sign = '+';
            Console.WriteLine($"{numbers[0]} {sign} {numbers[1]} = {result}");
            return new CalculatorRecord() { Num1 = numbers[0], Num2 = numbers[1], Sign = sign, Result = result };
        }
        public CalculatorRecord Subtract(int[] numbers)
        {
            result = numbers[0] - numbers[1];
            sign = '-';
            Console.WriteLine($"{numbers[0]} {sign} {numbers[1]} = {result}");
            return new CalculatorRecord() { Num1 = numbers[0], Num2 = numbers[1], Sign = sign, Result = result };
        }
        public CalculatorRecord Multiply(int[] numbers)
        {
            result = numbers[0] * numbers[1];
            sign = '*';
            Console.WriteLine($"{numbers[0]} {sign} {numbers[1]} = {result}");
            return new CalculatorRecord() { Num1 = numbers[0], Num2 = numbers[1], Sign = sign, Result = result };
        }
        public CalculatorRecord Divide(int[] numbers)
        {
            result = numbers[0] / numbers[1];
            sign = '/';
            Console.WriteLine($"{numbers[0]} {sign} {numbers[1]} = {result}");
            return new CalculatorRecord() { Num1 = numbers[0], Num2 = numbers[1], Sign = sign, Result = result };
        }
    }
}
