using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оператор многозадачного выбора - swithc-case (переключатель)
            Console.WriteLine("Введите число 1 или 2");
            string number = Console.ReadLine();

            //На 20 строке создаем конструкцию многозадачного выбора, переключатель - switch,
            // которому в качастве выражения- селектора , передаем переменную - number.

            switch(number) // (number)- выражение-селектор
            {
                //В теле переключтеля switch -case создаем двао ператора case
                // с постоянными выражениями равными "1" и "2" соответственно.

                //Если значение выражения - селектора совпадет с одним из значений постоянных выражений,
                // то выполнится тело оператора case, постоянное выражение которого совпало с выражением-селектором.

                case "1":  //"1" - постоянное выражение
                    {
                        Console.WriteLine("Один");
                        break; //Выход из переключателя
                    }
                case "2":
                    {
                        Console.WriteLine("Два");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Три");
                        break;
                    }
                //На 45 сточке создаем (необязательный) оператор default, тело которого выполняется в случае,
                // если значение выражения-селектора не совпало ни с одним из значений постоянных выражений.
                default:
                    {
                        Console.WriteLine("Вы ввели значение отличное от 1 и 2");
                        break;
                    }
                    //Если в переключателе отсутствует оператор default, то управление передается за пределы переключателя switch.
            }
            //Delay
            Console.ReadKey();
        }
    }
}
