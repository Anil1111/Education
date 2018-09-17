using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace _001_XML_Serialization
{
    //СНАЧАЛА ЗАКОММЕНТИ ВСЕ АТТРИБУТЫ, сериализируй - десериализируй, а потом раскомменти ПО ОДНОМУ и посмотри в чем разница!
    //Перед тем как открыть файл Serialization.xml не забусь обновить(иногда он не появляется в папке и для этого нужно его обновить)

    //ВАЖНО!!!
    //Если нету никаких атрибутов, то по умолчанию - класс - это рутовая нода, а остальные элементы - это ПУБЛИЧНЫЕ поля и свойства класса!
    //Методы сериализуются? Конечно же НЕТ. Зачем нас сериалозовать методы? Они ВСЕГДА ОДИНАКОВЫ, они НЕ МЕНЯЮТСЯ.
    //Методы живут не в экземпляре, а в объекте.

    //XmlRoot - Переименовывает корневой узел(рутовую ноду)
    [XmlRoot("MyButton")]
    public class MyClass
    {
        //Эти поля и будут хранить состояние объекта потому, что состояние объекта определяется значением его полей.
        //ПРИВАТНЫЕ, protected поля и свойства НЕ сериализуются, а ПУБЛИЧНЫЕ - сериализуются!
        public string name = "Roman"; // будет сериализовано!
        protected string name2 = "Roman2"; // НЕ будет сериализовано
        private string id = "button";
        private int size = 10;
        private Point position = new Point(20, 30);
        private string password = "123456789_password";
        private List<string> items = new List<string>();

        //XmlAttribute - переименовывает и делает атрибутом того элемента XML, а который на уровень выше нас - в данном случае [XmlRoot("MyButton")
        [XmlAttribute("SerialID")]
        public string Id
        {
            get => id;
            set => id = value;
        }

        [XmlAttribute("Length")] //точно то же самое, что и с Id
        public int Size
        {
            get => size;
            set => size = value;
        }

        //Xml элемент, а не атрибут
        [XmlElement("Pos")] //ничего не поменялось, только имя "Position" изменилось на "Pos"
        public Point Position
        {//если посмотреть, то у Point есть ещё свойство - IsEmpty, но оно помечено атрибутом [Browsable(false)]и 
            //скорей всего из-за этого оно не записалось в файл
            get => position;
            set => position = value;
        }

        //Исключаем свойство из процесса сериализации/десериализации
        [XmlIgnore] //пропал пароль. т.е мы просто не сериализовали его
        public string Password
        {
            get => password;
            set => password = value;
        }

        //Характеристика массива
        [XmlArray("List")]  //ничего не поменялось, только имя "Items" изменилось на "List"
        //Характеристика каждого элемента этого массива
        [XmlArrayItem("Element")] //ничего не поменялось, только имя "string" изменилось на "Element"
        public List<string> Items
        {
            get => items;
            set => items = value;
        }

    }
}
