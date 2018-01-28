using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _004_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое любое число");
                double operand1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе любое число");
                double operand2 = Convert.ToDouble(Console.ReadLine());
                Label:
                Console.WriteLine("Введите введите знак арифметической операции '+','-','*','/','%' ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        Console.WriteLine($" {operand1} {sign} {operand2} = {operand1 + operand2}");
                        break;
                    case "-":
                        Console.WriteLine($" {operand1} {sign} {operand2} = {operand1 - operand2}");
                        break;
                    case "*":
                        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 * operand2}");
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            Console.WriteLine($"ОШИБКА, деление на {operand2} невозможно");
                            goto Label;
                        }
                        else
                            Console.WriteLine($" {operand1} {sign} {operand2} = {operand1 / operand2}");
                        break;
                    case "%":
                        if (operand2 == 0)
                        {
                            Console.WriteLine($"ОШИБКА, деление на {operand2} невозможно");
                            goto Label;
                        }
                        else
                            Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 % operand2}");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу.\nДля выхода нажмите клавишу q");
                string enteredSymbol = Console.ReadLine();
                switch (enteredSymbol)
                {
                    case "q":
                        Environment.Exit(0);
                        break;
                }

                Console.Clear();
            }

        }
    }
}
