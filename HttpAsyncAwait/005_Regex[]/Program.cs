using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _005_Regex__
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex;
            string pattern;
            string text;

            //Возможно указать необходимые символы между скобок []
            pattern = "^[qwerty]+$"; //означает что между началом (^) и концом строки ($) может быть 1 или более (+) символов (qwerty). 
            //Т.е любой из символов из этого набора и не одного другого символа
            text = "qwec"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); // False - потому, что в [qwerty] нету символа "с"

            //Строка может состоять только из символов [qwerty]  и тогда regex.IsMatch вернет true, если будет хоть 1 другой символ - ВЕРНЕТ FALSE
            //Нпример: qqqq, yqyqyqyqy, eeeer ....
            pattern = "^[qwerty]+$"; //означает что между началом (^) и концом строки ($) может быть 1 или более (+) символов (qwerty)
            text = "qrwere"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); //regex.IsMatch(text) - совпадает ли строка text с шаблоном,заложенным в regex

            pattern = "^[abcdefghigklmnopqrstuvwxyz]+$";
            text = "test"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n");

            //Второй способ, a-z это замена боле длиннго шаблона abcdefghigklmnopqrstuvwxyz
            pattern = "^[a-z]+$";
            text = "test"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n");

            //0-9, это замена 0123456789
            pattern = "^[a-z0-9]+$";
            text = "test007"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n");

            //0-9, это замена 0123456789
            pattern = "^[a-z0-9]+$"; //если сделать "^[a-z0-9 ]+$"; с пробелм после 9 , то будет True
            text = "test 007"; //Анализируемая строка
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); //FALSE - потому, что ПРОБЕЛ между test и 007

            //Шаблон даты
            pattern = @"^\d{2}-\d{2}-\d{4}$";
            text = "02-05-1982";
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); //true

            //Квантификатор * означает вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = "dfgsddf";
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); //False

            //Квантификатор * означает вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = "";
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n"); // True

            //Простой шаблон сравнения email
            pattern = @"^[0-9a-zA-Z_-]+@[\S]+\.\S{2,4}$";
            // с начала строки (^) пусть будет один и более из символов [0-9a-zA-Z_-]+, потом @
            //, потом один и более \S  Определяет любой символ, который не является цифрой, буквой или подчеркиванием.
            //потому точка (\.), дальше опять \S, но от 2х до 4х символов
            text = "test@mai123.ru";
            regex = new Regex(pattern);
            Console.WriteLine($"{text} == {pattern} : {regex.IsMatch(text)}\n");

            //Delay
            Console.ReadKey();
        }
    }
}
