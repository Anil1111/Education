using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask2.Document
{
    class Title:Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Титл документа отсутствует";

            }
            set => content = value;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
