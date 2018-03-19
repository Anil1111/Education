using _004_AdditionalTask2.Document;

namespace _004_AdditionalTask2
{
    class DocumentClass
    {
        private Part title ;
        private Part body ;
        private Part footer ;

        public DocumentClass(string title)
        {
            this.title=new Title();
            this.body=new Body();
            this.footer=new Footer();
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
            set => this.body.Content = value;
        }
        public string Footer
        {
            set => this.footer.Content = value;
        }

    }
}
