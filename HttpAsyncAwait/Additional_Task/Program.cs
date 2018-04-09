using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static DateTime GetDateFromKeyboard()
        {
            Console.WriteLine("Введите дату своего дня рождения в формате 'гггг, мм, дд'");
            return DateTime.Parse(Console.ReadLine());
        }

        static TimeSpan CalculateAmountOfDayToBirthday(DateTime birthdayDate)
        {
            var now = DateTime.Now;
            var thisYear = new DateTime(now.Year, birthdayDate.Month, birthdayDate.Day);
            if (now > thisYear)
            {
                thisYear = new DateTime(now.Year+1, birthdayDate.Month, birthdayDate.Day);
                return thisYear - now;
            }  
            else
                return thisYear - now;
        }
        static void Main(string[] args)
        {
            var date = GetDateFromKeyboard();
            var timeLeft = CalculateAmountOfDayToBirthday(date);

            Console.WriteLine($"До дня рождения осталось {timeLeft.Days} дней," +
                              $" {timeLeft.Hours} часов," +
                              $" {timeLeft.Minutes} минут");

            //Delay
            Console.ReadKey();
        }
    }
}
