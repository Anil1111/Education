using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast
            BaseClass instanceUp = instance; // При UpCast`e не обязательно 
            //явно указывать к чему мы UpCast`имся!
            instanceUp.Method();   //-Не смотря на UpCast вызовется метод из DerivedClass
                                   //т.к 1я форма полиморфизма сильнее 2й!
                                   //Если бы мы ЗАМЕЩАЛИ метод из базового класса, 
                                   //а НЕ ПЕРЕОПРЕДЕЛЯЛИ ЕГО, то вызвался бы метод из BaseClass!

            //DownCast
            DerivedClass instanceDown = (DerivedClass) instanceUp;
            instanceDown.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
