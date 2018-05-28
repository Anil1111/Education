using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Timer
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
            view.timer1.Start();
            view.Enabled = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ViewReset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.
        }

        private void ViewStop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ViewStart(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
