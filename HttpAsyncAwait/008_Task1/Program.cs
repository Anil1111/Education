using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Task1
{
    class Program
    {
        static void CalculateTheCreditState()
        {
            double creditDebt = 700;
            double sumLeftToPay;

            do
            {
                Console.WriteLine($"Пришло время платить.Еще осталось внести {creditDebt}, гоните деньги!");
                double payedSum = Convert.ToDouble(Console.ReadLine());
                sumLeftToPay = creditDebt - payedSum;
                creditDebt = sumLeftToPay;
                Console.WriteLine(sumLeftToPay <= 0
                                  ? $"Долг закрыт, сумма переплаты {sumLeftToPay}"
                                  : $"Долг еще не выплачен полностью. Сумма задолженности составляет {sumLeftToPay}");
            }
            while (sumLeftToPay>=0);
        }
        static void Main(string[] args)
        {
            CalculateTheCreditState();

            //Delay
            Console.ReadLine();
        }
    }
}
