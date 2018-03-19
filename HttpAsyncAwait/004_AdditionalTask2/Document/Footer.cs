using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask2.Document
{
    class Footer:Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Футтер документа отсутствует";

            }
            set => content = value;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
