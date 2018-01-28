using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "Roman";
            const string password = "password12345";
            Console.Write("Введите login: ");
            string enteredLogin = Console.ReadLine();
            if (enteredLogin == login)
            {
                Console.Clear();
                Console.Write("Введите пароль: ");
                string enteredPassword = Console.ReadLine();
                if (enteredPassword == password)
                {
                    Console.Clear();
                    Console.WriteLine($"Здравствуйте, {login}.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели неправильный пароль!");
                }
                    
                //Delay
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Пользователя с таким {nameof(login)} нету");
            }
             
            //Delay
            Console.ReadKey();


        }
    }
}
