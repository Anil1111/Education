using System;
using System.Reflection;
namespace _028_Attributes
{
    //Атрибуты - конструкция, присущая только .Net. В других языках вы такую конструкцию вряд ли найдете.

    //ЗАДАЧА АТРИБУТА - помечать какие-то типы, т.е оставлять для них информацию в метаданных, для
    //того, чтобы другие типы с помощью рефлексии смогли их обнаружить и в зависимости от этох маркеров
    //могли предпринять какие-то действия, т.е каким-то образом скоординировать свои действия немножко по другому
    //Например - запускать перед каждым тестов метод, помеченным атриутом TestInitialize

    //AttributeTargets.Class | AttributeTargets.Interface означает - только класс или только интерфейс!
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
    public class MyAttribute : Attribute  // Inherited = true - означает, что атрибут MyAttribute будет унаследован 
    {                                     // от базового класса к производному, или к переопределяющим членам
        private readonly string data;
        private readonly string text;

        public MyAttribute(string data, string text)
        {
            this.data = data;
            this.text = text;
        }

        //[Obsolete] //Показывает, что метод уже устаревший. [Obsolete] - конструктор без параметров
        //[Obsolete("Some message explaining why the method is obsolee", true)]  - если true - то будет ошибка компиляции
        [Obsolete("Some message explaining why the method is obsolee")]
        public void Method()
        {
            Console.WriteLine("Mетод класса Аттрибута");
        }

        public string Data => data;

        public string Text => text;
    }

    [My("XXX","1/1/1111")]
    [My("XXX1", "1/1/1111")]
    class BaseClass
    {
        static BaseClass()
        {
            Console.WriteLine("Static constuctor");
        }

        public BaseClass()
        {
            Console.WriteLine("Ctor BaseClass");
        }
    }

    [My("Hello", "31/01/2008")]
    [My("World", "31/01/2009")]
    class MyClass : BaseClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Атрибуты никак не влияют на работу классов, которые они помечают
            //Атрибуты - это маркер(маячек) для других классов. Т.е через рефлексию можно увидеть, что 
            //у этого класса есть особые свойства и с ним нужно поступать особым образом.

            MyClass instance = new MyClass();

            // MemberInfo - абстрактный класс, ИСПОЛЬЗУЕТСЯ ДЛЯ ПОЛУЧАНИЯ ИНФОРМАЦИИ О ЧЛЕНАХ КЛАССА
            MemberInfo type = typeof(MyClass);

            //Метод GetCustomAttributes() - возвращает массив объектов, которые при выполнении приложения
            //представляют собой эквиваленты атрибутов, созданных в исходном коде.
            //Извлекаем из элементов массива элементы типа - MyAttribute
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            //Если в массиве есть соответствующие записи, то первый элемент представляет собой атрибут
            if (attributes.GetLength(0) != 0)
            {
                //Отображаем получанные значения.
                foreach (MyAttribute attribute in attributes)
                {
                    //Сначала будут тображаться атрибуты из базового класса, а потом уже из производного
                    Console.WriteLine(attribute.Text);
                    Console.WriteLine(attribute.Data);
                    attribute.Method();
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
