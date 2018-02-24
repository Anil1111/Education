using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _001_Task2.Classes;

namespace _001_Task2
{
    class Book
    {
        private Author author;
        private Content content;
        private Title title;

        public Book()
        {
            this.author = new Author();
            this.content = new Content();
            this.title = new Title();
        }


        public void Show()
        {
            author.ShowContent();
            content.ShowContent();
            title.ShowContent();
        }

        public Author Author
        {
            set { author.Content = value; }
        }

        public Content Content
        {
            set { content.Contents = value; }
        }
        public Title Title
        {
            set { title.Content = value; }
        }
    }
}

