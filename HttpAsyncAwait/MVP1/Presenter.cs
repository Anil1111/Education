using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP1
{
    class Presenter
    {
        private Model model;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += this.MutateValue;
        }

        public void MutateValue(object sender, EventArgs eventArgs)
        {
            this.mainWindow.TextBox1.Text = this.model.ModifyStringValue(this.mainWindow.TextBox1.Text);
        }
    }
}
