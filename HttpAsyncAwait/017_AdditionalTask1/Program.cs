using static System.Console;

namespace _017_AdditionalTask1
{
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b) => a + b;
        public dynamic Sub(dynamic a, dynamic b) => a - b;
        public dynamic Mul(dynamic a, dynamic b) => a * b;
        public dynamic Div(dynamic a, dynamic b) => b == 0 ? "На ноль делить нельзя" : a / b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int operand1 = 20, operand2 = 13;

            WriteLine($"{operand1} + {operand2} = {calculator.Add(operand1, operand2)}");
            WriteLine($"{operand1} - {operand2} = {calculator.Sub(operand1, operand2)}");
            WriteLine($"{operand1} * {operand2} = {calculator.Mul(operand1, operand2)}");
            WriteLine($"{operand1} / {operand2} = {calculator.Div(operand1, operand2)}");

            //Delay
            ReadKey();
        }
    }
}
