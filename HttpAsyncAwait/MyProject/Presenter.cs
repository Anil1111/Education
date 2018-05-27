using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyProject
{
    class Presenter
    {
        private Model model;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.SomeEvent += MainWindowOnSomeEvent;
        }

        private void MainWindowOnSomeEvent(object sender, EventArgs eventArgs)
        {
            this.mainWindow.TextBox1.Text = this.model.SomeMethod(this.mainWindow.TextBox1.Text);
        }
    }
}
