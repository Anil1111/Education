using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Перечисления. Получение информации о типе элементов перечисления.
namespace _006_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEnum digit = MyEnum.Ten;
           
            Type @enum = digit.GetType();
            Console.Write($"1. Перечесление {@enum.Name} состоит из элементов типа: ");
            //Enum.GetUnderlyingType() - возвращает тип, который используется для представления
            // числовых значений элементов перечисления.(короче то, что по умолчанию int, но мы можем его указать).
            //(в даннном случае @const)
            Type @const = Enum.GetUnderlyingType(@enum);
            Console.WriteLine(@const);

            //Способ 2.
            //оператор typeof - возврщает экземпляра класса System.Type, который содержит информация
            // о том типе, который был передаен в качестве аргумента данного оператора.
            Console.Write($"2. Перечисление MyEnum состоит из элементов типа: ");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(MyEnum)));

            //Итог: GetType(); и typeof(MyEnum) - это эквивалентные конструкции.
            // GetType() используется когда есть экземпляр класса и мы вызываем этот метод на этом экземпляре.
            //  typeof(MyEnum) используется, когда экзмпляра класса нету, но мы знаем название класса и передаем его в typeof()
            var a = digit.GetType();
            var b = typeof(MyEnum);
            //Delay
            Console.ReadKey();
        }
    }
}
