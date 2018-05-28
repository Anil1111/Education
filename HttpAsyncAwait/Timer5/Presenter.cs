using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer5
{
    class Presenter
    {
        private readonly Model model;
        private readonly Form1 view;

        public Presenter(Form1 v)
        {
            model = new Model();
            view = v;
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer1.Tick += TimerTick;
            view.timer1.Interval = 1000;
            view.timer1.Start();
            view.timer1.Enabled = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.textBox1.Text = model.Tick();
        }

        private void ViewReset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.textBox1.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e)
        {
            view.timer1.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)
        {
            view.timer1.Enabled= true;
        }
    }
}
