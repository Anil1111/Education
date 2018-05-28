using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Console
{
    class Presenter
    {
        private Model model;

        public Presenter()
        {
            this.model = new Model();
            Program.MyEvent+=ProgramOnMyEvent;
        }

        private void ProgramOnMyEvent(string s)
        {
           Console.WriteLine(model.ModifyString(s));
        }
    }
}
