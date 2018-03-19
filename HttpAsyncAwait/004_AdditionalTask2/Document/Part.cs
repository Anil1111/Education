using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask2.Document
{
    public abstract class Part
    {
        protected string content;
        public abstract string Content { get; set; }
        public abstract void Show();
    }
}
