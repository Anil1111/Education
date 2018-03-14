using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inheritance
{
    public class BaseClass
    {
        //Поля
        public string anotherPublicField = "some text";

        //Открытое поле.
        public string publicField = "BaseClass.PublicField";
        //Защищенное поле.
        protected string protectedField = "BaseClass.ProtectedField";
        //Закрытое после.
        private string privateField = "BaseClass.PrivateField";

        public void ShowPrivateField()
        {
            Console.WriteLine(privateField);
        }
    }
}
