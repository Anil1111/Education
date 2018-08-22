using System.Collections.Generic;

namespace _015_DictionaryGeneric
{
    class PhoneBook : Dictionary<int, Contact>
    {
        //Переружаем метод Add
        public void Add(int phone, string fName, string lName)
        {
            //индексатор наследуется от Dictionary<int, Contact>
            //ВОТ И ОБОЛОЧКА. Ключ - телефон, а значение, это объект Contact. Так намного проще все читается - смотри в Program.cs
            this[phone] = new Contact
            {
                FirstName = fName,
                LastName = lName
            };
        }
    }

    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
