using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _005_Equals_GetHashCode
{
    //Правило: переопределяйте GetHashCode(), переопределяя Equals()
    // При написании тестов - я не сравнивал element1 и element2. Я сравнивал в основном значение.
    // А во время треннинга С# для тестировщиков нужно было сравнивать элементы(строки) и там пришлось 
    // переопределять метод Equals! И там же переопределяется GetHashCode(). Все сходится.
    class Point : Object
    {
        protected int x, y;

        public Point(int xValue, int yValue)
        {
            this.x = xValue;
            this.y = yValue;
        }

        //Мы переопределили Equals так, что он не сравнивает hashCod`ы.
        public override bool Equals(object obj) //если я не переопределил GetHashCode(), то подчеркивает синим метод 
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Point p = (Point)obj;
            return (p.x == this.x) && (p.y == this.y); //посколько тут сравниваются ОБЬЕКТЫ класса Point, а этот МЕТОД ВЫЗЫВАЕТСЯ НА ОБЪЕКТЕ ТИПА Point
                                                       // то один сравниваемый обьект будет this. т.к МЫ ВЫЗВАЛИ МЕТОД НА ОБЪЕКТЕ - а другой - тот, который передается как аргумент.
        }
        //Даже если щас закоментить метод ниже, то все равно будет true при a==b, Т.К В НАШЕМ ПЕРЕОПРЕДЕЛННОМ Equals НЕТУ ПРОВЕРКИ НА ХЭШКОДЫ.
        //public override int GetHashCode()   //а непереопределненный метод Equals() сравнивает хэшкоды
        //{
        //    return x ^ y; //если координаты двух точен одинаковы т.к (p.x == this.x) && (p.y == this.y), то значение  x ^ y  будет тоже одинаково.
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine(a.GetHashCode() + "     " + b.GetHashCode());
            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));
            //Теперь проверим ссылки:
            //И HashCod`ы совпадают и значение в обьектах одинаковое, НО ССЫЛКИ НА ТО ОБЬЕКТЫ РАЗНЫЕ!
            Console.WriteLine(Object.ReferenceEquals(a, b)); // - false! Несмотря на то, что hashcod`ы совпадают, НО ReferenceEquals проверяет не hashcod`ы а ССЫЛКИ на обькты(адреса в памяти).

            Console.WriteLine(a.GetHashCode() + "     " + b.GetHashCode());
            Console.WriteLine(Object.Equals(a, b)); // хз почему true. hash`ы же разные, если закоментить override int GetHashCode
            //если закоментиь  override bool Equals - то будет false

            //Delay
            Console.ReadKey();
        }
    }
}
