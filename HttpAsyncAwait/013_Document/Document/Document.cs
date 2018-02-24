using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _012_Document.Document.Parts;

namespace _013_Document.Document
{
    class Document
    {
        private Title title;
        private Body body;
        private Footer footer;

        public void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

        public string Body
        {
            set => body.Content = value;
        }

        public string Footer
        {
            set { this.footer.Content = value; }
        }
    }
}
