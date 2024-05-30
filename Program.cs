namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CalculatorRecord> records = new List<CalculatorRecord>();
            Calculations calculations = new Calculations();
            int[] numbers = [0, 0];

            int selection = UserInput.MenuInput();

            while (selection != 6)
            {
                Console.WriteLine();

                if(selection < 5)
                {
                    Console.Write("Tal 1: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Tal 2: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    numbers = UserInput.MakeIntArray(num1, num2);
                }
                    
                switch (selection)
                {
                    case 1: records.Add(calculations.Sum(numbers)); break;
                    case 2: records.Add(calculations.Subtract(numbers)); break;
                    case 3: records.Add(calculations.Multiply(numbers)); break;
                    case 4: records.Add(calculations.Divide(numbers)); break;
                    case 5: CalculatorRecord.PrintRecords(records); break;
                    default: throw new Exception();
                }

                selection = UserInput.MenuInput();
            }
        }
    }
}
