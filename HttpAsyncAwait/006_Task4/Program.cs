using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Task4
{
    class Book
    {
        public class Note
        {
            private string text = "";

            public string Text
            {
                get => text;
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.Note note = new Book.Note();
            note.Text = "Good Book";
            note.Text = "I like it";

            FindAndReplaceManager.FindNext(note.Text);

            //Delay
            Console.ReadKey();
        }
    }
}
