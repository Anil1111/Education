using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Комбинированные делегаты
namespace _004_Delegates
{
    //Делегаты - это ссылочный тип
    public delegate void MyDelegate();
    class Program
    {
        public static void Method()
        {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3");
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            //Комбинируем делегаты; оператор +, который используется с делегатами называют знаком 
            //КОМБИНАЦИИ или знаком ГРУПИРОВКИ

            //оператом + порождает обьект из myDelegate1 и myDelegate2(у него внутри создается таблица в которую вписуются адреса методов из двух делегатов, с которых он был сделан)
            //, а потом уже еще один из того, что получился и myDelegate3. после того, как myDelegate создан, то делегат, который был сделан из myDelegate1 и myDelegate2 будет уничтожен garbage collector`ом
            //а все это потому, что делегаты IMMUTABLE
            myDelegate = myDelegate1 + myDelegate2+myDelegate3;

            Console.WriteLine("Введите число от 1 до 7");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                {
                    myDelegate1.Invoke();
                    break;
                }
                case "2":
                {
                    myDelegate2.Invoke();
                    break;
                }
                case "3":
                {
                    myDelegate3.Invoke();
                    break;
                }
                case "4": //Группировкм == комбинация, разгрупировка == разкомбинация.
                {
                    var myDelegate4 = myDelegate - myDelegate1; //Знак "-" - это знак разгрупировки
                    myDelegate4.Invoke();                       //при разгрупировке точно так же делается еще один делегат.
                    break;
                }
                case "5":
                {
                    var myDelegate5 = myDelegate - myDelegate2; //Знак "-" - это знак разгрупировки
                    myDelegate5.Invoke();
                    break;
                }
                case "6":
                {
                    var myDelegate6 = myDelegate - myDelegate2; //Знак "-" - это знак разгрупировки
                    myDelegate6.Invoke();
                    break;
                }
                case "7":
                {
                    myDelegate.Invoke();
                    break;
                }
                default:
                    Console.WriteLine("Вы ввели недопустимое значение");
                    break;
            }
            //Delay
            Console.ReadKey();
        }
    }
}
