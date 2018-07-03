
extern alias T2;
using T2::_018_Task3._1;


namespace _018_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            T2._018_Task3._1.MyClass my = new MyClass();
            my.Method();

            //Delay
            System.Console.ReadKey();
        }
    }
}
