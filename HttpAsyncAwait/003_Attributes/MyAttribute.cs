using System;

namespace _003_Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class MyAttribute : Attribute
    {
        private readonly string data;
        private readonly string text;

        public MyAttribute(string data, string text)
        {
            this.data = data;
            this.text = text;
        }

        public void Method()
        {
            Console.WriteLine("Mетод класса Аттрибута");
        }

        public string Data => data;

        public string Text => text;

    }
}
