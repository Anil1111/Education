using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Task1
{
    class Program
    {
        static double Add(double operand1, double operand2)
        => operand1 + operand2;
        static double Sub(double operand1, double operand2)
        => operand1 - operand2;
        static double Mul(double operand1, double operand2)
        => operand1 * operand2;
        static double Div(double operand1, double operand2)
        {
            while (operand2 == 0)
            {
                Console.WriteLine("Введите число на которое будем делить");
                operand2 = Convert.ToDouble(Console.ReadLine());
            }
            return operand1 / operand2;
        }
        static void CalculateTheValue(double operand1, double operand2, string sign, out double result)
        {
            switch (sign)
            {
                case "+":
                    result = Add(operand1, operand2);
                    break;
                case "-":
                    result = Sub(operand1, operand2);
                    break;
                case "*":
                    result = Mul(operand1, operand2);
                    break;
                case "/":
                    result = Div(operand1, operand2);
                    break;
                default:
                    result = 0;
                    break;
            }
        }
        static public void InitialiseVariables(out double operand1, out double operand2, out string sign)
        {
            Console.WriteLine("Введите первое число");
            operand1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            operand2 = Double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите знак операции, которая будет выполнена");
                sign = Console.ReadLine();
            }
            while (!sign.Equals("+") && !sign.Equals("-") && !sign.Equals("*") && !sign.Equals("/"));
            
        }
        public
        static void Main(string[] args)
        {
            double operand1, operand2, result;
            string sign;
            InitialiseVariables(out operand1, out operand2, out sign);
            CalculateTheValue(operand1, operand2, sign, out result);

            Console.WriteLine($"Результат вычисления при операции {sign}: {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
