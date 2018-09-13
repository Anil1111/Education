using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _003_TypeInfo
{
    public sealed class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public event EventHandler Modified;

        private void OnModified()
        {
            EventHandler handler = Modified;

            if (handler != null)
            {
                handler.Invoke(this, EventArgs.Empty);
            }
        }

        private void Save() { /* .......Some code....... */}
    }
   static class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Person);

            //Для удобства сделали TypeInfo. Тут мы можем получить список полей в форме КОЛЛЕКЦИИ
            TypeInfo typeInfo = type.GetTypeInfo(); //Type дает своего "личного ассистента"

            //по сути - в этих свойствах перевызываются методы из класса Type, но теперь мы получаем их в коллекции
            IEnumerable<PropertyInfo> propertyInfos = typeInfo.DeclaredProperties;
            propertyInfos.PrintValues();

            IEnumerable<MethodInfo> methodInfos = typeInfo.DeclaredMethods;
            methodInfos.PrintValues();

            IEnumerable<EventInfo> eventInfos = typeInfo.DeclaredEvents;
            eventInfos.PrintValues();

            //Delay
            Console.ReadKey();
        }

        // PropertyInfo, MethodInfo, EventInfo и т.е ВСЕ НАСЛЕДУЮТСЯ ОТ MemberInfo
        private static void PrintValues(this IEnumerable<MemberInfo> memberInfos)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(memberInfos?.GetType().GetElementType()?.Name); //была коллекция->взяли тип коллекции->взяли тип элемента->взяли имя элемента
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (MemberInfo memberInfo in memberInfos)
            {
                Console.WriteLine(memberInfo);
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
