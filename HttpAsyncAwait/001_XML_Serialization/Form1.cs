using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _001_XML_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Тип для сериализации и десериализации
        readonly XmlSerializer serializer = new XmlSerializer(typeof(MyClass));

        MyClass instanceForSerialization = new MyClass();
        private MyClass instanceForDeserialization;

        //СЕРИАЛИЗАЦИЯ
        private void Serialization_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                instanceForSerialization.Items.Add("Element" + i); //просто заполняем список
            }

            using (FileStream stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                //Сохраняем объект в XML-файле на диске (СЕРИАЛИЗАЦИЯ)
                //Это делается с помощью рефлексии: 1)ловим волшебника, 2)находим все FieldInfo 3)выдираем все значения полей с помощью GetValue 4)тупо мантулим их в файловый поток
                //И точно так же будет восстанавливаем
                serializer.Serialize(stream, instanceForSerialization);
                this.Text = "Объект сериализован!";
            }
        }


        //ДЕСЕРИАЛИЗАЦИЯ
        private void DeSerialization_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    //В методе Deserialize мы запускаем Activator.CreateInstance(type), где type то, что мы передавали в конструктор new XmlSerializer(typeof(MyClass));
                    //Т.е через техники позднего связывания нам динамечески создается пустой экземпляр класса MyClass и потом Deserialize лезет в файловый поток и 
                    //записывает те значения, которые сохранились из предидушего объекта
                    instanceForDeserialization = serializer.Deserialize(stream) as MyClass;
                    this.Text = "Объект Десериализован";

                    textBox1.Text = "ID       : " + instanceForDeserialization.Id + Environment.NewLine +
                                    "Size     : " + instanceForDeserialization.Size + Environment.NewLine +
                                    "Position : " + instanceForDeserialization.Position + Environment.NewLine +
                                    "List     : " + Environment.NewLine;

                    foreach (var listItem in instanceForDeserialization.Items)
                    {
                        textBox1.Text += "\t" + listItem + Environment.NewLine;
                    }

                    textBox1.Text += "Password" + instanceForDeserialization.Password;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
