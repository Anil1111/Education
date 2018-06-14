using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _004_Expection
{
    class MyClass
    {
        public void Method()
        {
            var expection = new Exception("Мое исключение");

            expection.HelpLink = "http://MyCompany.com"; // - ссылка для отправки информации исключения. Делается чтобы разрабы погли пофиксить его
            expection.Data.Add("Причина исключения", "Тестовое исключение");
            expection.Data.Add("Время возникновения исключения", DateTime.Now);

            throw expection;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass instance = new MyClass();
                instance.Method();
            }
            catch (Exception e) //ловим и проглатываем исключение
            {
                Console.WriteLine("Имя члена:                  {0}", e.TargetSite);
                Console.WriteLine("Класс определяющий член:    {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип члена:                  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:                    {0}", e.Message);
                Console.WriteLine("Source:                     {0}", e.Source);
                Console.WriteLine("Help Link:                  {0}", e.HelpLink);
                Console.WriteLine("Stack:                      {0}", e.StackTrace);

                foreach (DictionaryEntry element in e.Data)
                {
                    Console.WriteLine($"{element.Key} : {element.Value}");
                }
            }


            //Delay
            Console.ReadKey();
        }
    }
}
