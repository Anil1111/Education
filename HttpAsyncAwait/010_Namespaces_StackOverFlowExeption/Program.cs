//Пространства имен.

//Внимание: Распространенные ошибки самоассоциации после первой попытки инстанцирования.
using NamespacesA;
using NamespacesA.NamespaceB;
using NamespacesA.NamespaceB.NamespaceC;

namespace NamespacesA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA();
                MyClassB myB = new MyClassB();
                MyClassC myC = new MyClassC();
            }
        }

        class MyClassB
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();
        }
    }

    class MyClassA
    {
        MyClassA myA = new MyClassA();
        MyClassB myB = new MyClassB();
        MyClassC myC = new MyClassC();
    }
}

namespace _010_Namespaces_StackOverFlowExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тут будут вызывыться конструкторы по умолчанию, которые будут инициализироваться все поля в классе
            //при этом вызывая другие конструкторы!
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();
        }
    }
}
