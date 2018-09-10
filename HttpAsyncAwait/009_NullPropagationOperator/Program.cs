using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_NullPropagationOperator
{
    #region Classes

    class Clinet
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }

    #endregion
    /// <summary>
    /// В С# 6.0 облегчает проверку на null (Элвис оператор ?)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Clinet client = new Clinet();
            client.Phone = new Phone { Company = new Company() };

            string companyName = null;

            //1. Без проверки на null
            companyName = client.Phone.Company.Name;
            Console.WriteLine(companyName);

            //2. Превый способ проверки на null.
            if (client != null)
            {
                if (client.Phone != null)
                {
                    if (client.Phone.Company != null)
                    {
                        companyName = client.Phone.Company.Name;
                        Console.WriteLine(companyName);
                    }
                }
            }

            //3. Ещё одна проверка на null
            if (client != null && client.Phone != null && client.Phone.Company != null)
            {
                companyName = client.Phone.Company.Name;
                Console.WriteLine(companyName);
            }

            //1. Решение с Null Propagation operator.
            companyName = client?.Phone?.Company?.Name;
            Console.WriteLine(companyName);

            //2. Решение с Null Propagation operator.

            /*
            Выражение ?. и представляет оператор условного null. Здесь последовательно проверяется равен ли объект user и вложенные объекты значению null. 
            Если же на каком-то этапе один из объектов окажется равным null, то companyName будет иметь значение по умолчанию, то есть null.

            И в этом случае мы можем пойти дальше и применить операцию ?? для установки значения по умолчанию, если название компании не установлено:

             */
            companyName = client?.Phone?.Company?.Name ?? "Информация отсутствует"; //если тут хоть 1 объект будет null, то companyName будет "Информация отсутствует"
            Console.WriteLine(companyName);
            

            //Delay
            Console.ReadKey();
        }
    }
}
