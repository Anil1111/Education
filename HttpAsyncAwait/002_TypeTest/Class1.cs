using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_TypeTest
{
    //Информацию об этом классе мы получим во время выполнения.
    public class Class1 : Interface1, Interface2
    {
        //Поля
        public int myInt;
        private string myString = "Hello";

        //Конструкторы
        public Class1() { }
        public Class1(int myInt) => this.myInt = myInt;

        //Свойства 
        public int MyProp
        {
            get => myInt;
            set => myInt = value;
        }

        //public int get_MyProp () { } //такой метод уже скрыт в свойстве

        public string MyString
        {
            get => myString;
            set => myString = value;
        }

        //Методы
        public void MethodA() { }
        public void MethodB() { }

        //Даже если член приватный - рефлексии все равно!
        private void MethodC(string str, string str2) => Console.WriteLine(str + str2);

        public void MyMethod(int p1, string p2) { }
    }
}
