
// Пространства имен.

namespace NamespaceA
{
    class MyClassA
    {
        private MyClassA my;

        public MyClassA() //StackOverflowExption
        {
            System.Console.WriteLine("Constructor MyClassA");
            // Рефлексивная самоассициация, после первой попытки инстанцирования приводит к цикличному инстранцированию.

            my = new MyClassA();
        }
    }
}

namespace _009_Namespaces_reflication_self_association
{
    using NamespaceA;
    class Program
    {
        static void Main(string[] args)
        {
            // Попытка инстанцирования класса MyClassA.
            MyClassA  myA = new  MyClassA();
        }
    }
}
