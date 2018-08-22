using System;
using System.Collections.Specialized;
using System.Configuration;

namespace _014_NameValueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //В NameValueCollection допускается несколько значений, соответствующих одному ключу.
            //К тому же, значения можно получать не только по ключу, но и по индексу.

            var nv = new NameValueCollection
            {
                {"Key", "Some Text"},
                {"Key", "More Text"}
            };
            nv.Add("Key", "Value");

            //Чтобы выбрать все значения по ключу - нужно вызвать метод GetValues
            foreach (var s in nv.GetValues("Key"))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(new string('-', 50));

            //Испольование индексатора отличается т использования метода Add()
            //Индексатор не добавляет новое значение , а ЗАМЕНЯЕТ существующее.
            nv["first"] = "1st";
            nv["first"] = "FIRST";

            Console.WriteLine(nv.GetValues("First").Length); //1

            foreach (var s in nv.GetValues("First"))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(new string('-', 50));

            //Метод Add добавляет новое значение в коллекцию
            nv.Add("Second", "2nd");
            nv.Add("Second", "SECOND");
            Console.WriteLine(nv.GetValues("Second").Length); //2

            foreach (var s in nv.GetValues("Second"))
            {
                Console.WriteLine(s);
            }

            //Practical usage example with App.Config
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("App.Config appSetings values");

            var appSettings = ConfigurationSettings.AppSettings; //добавил в App.config пару значений
            foreach (string appSetting in appSettings)
            {
                Console.WriteLine($"{appSetting} : {appSettings[appSetting]}");
            }

            Console.WriteLine(appSettings["SomeKey"]);

            //В  ConfigurationSettings.AppSettings используется NameValueCollection
            //Delay
            Console.ReadKey();
        }
    }
}
