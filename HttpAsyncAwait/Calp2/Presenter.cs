using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calp2
{
    class Presenter
    {
        private Model model;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddEvent += MainWindowOnAddEvent;
            this.mainWindow.SubEvent += MainWindowOnSubEvent;
            this.mainWindow.MulEvent += MainWindowOnMulEvent;
            this.mainWindow.DivEvent += MainWindowOnDivEvent;
        }

        private void MainWindowOnDivEvent(object sender, EventArgs eventArgs)
        {
            var variable = model.Div(Convert.ToInt32(mainWindow.Operand_1.Text),
                Convert.ToInt32(mainWindow.Operand_2.Text));
            mainWindow.Result_textbox.Text = variable;
        }

        private void MainWindowOnMulEvent(object sender, EventArgs eventArgs)
        {
            var variable = model.Mul(Convert.ToInt32(mainWindow.Operand_1.Text),
                Convert.ToInt32(mainWindow.Operand_2.Text));
            mainWindow.Result_textbox.Text = variable;
        }

        private void MainWindowOnSubEvent(object sender, EventArgs eventArgs)
        {
            var variable = model.Sub(Convert.ToInt32(mainWindow.Operand_1.Text),
                Convert.ToInt32(mainWindow.Operand_2.Text));
            mainWindow.Result_textbox.Text = variable;
        }

        private void MainWindowOnAddEvent(object sender, EventArgs eventArgs)
        {
            var variable = model.Add(Convert.ToInt32(mainWindow.Operand_1.Text),
                Convert.ToInt32(mainWindow.Operand_2.Text));
            mainWindow.Result_textbox.Text = variable;
        }
    }
}
