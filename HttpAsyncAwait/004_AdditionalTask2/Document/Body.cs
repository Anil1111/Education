using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask2.Document
{
    class Body:Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Тело документа отсутствует";

            }
            set => content = value;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
