using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void MyDelegate(object sender, EventArgs eventArgs);
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public MyDelegate myEvent;
        public event MyDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.myEvent.Invoke(sender, e);
        }
    }
}
