using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Additional_Task
{
    struct NoteBok
    {
        private string model;
        private string manufactorer;
        private double price;

        public string Model => model;
        public string Manufactorer => manufactorer;
        public double Price => price;

        public NoteBok(string model, string manufactorer, double price)
        {
            this.model = model;
            this.manufactorer = manufactorer;
            this.price = Math.Abs(price); //передал -1000 а присвоил полю 1000
        }

        public NoteBok(string model)
            : this(model, "", 0)
        {
        }

        public NoteBok(double price)
            : this("", "", price)
        {
        }

        public void Show()
        {
            Console.WriteLine($"Notebook model {Model}\r\n" +
                              $"         manufactorer {Manufactorer}\r\n" +
                              $"         price {Price}$\r\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NoteBok notebook = new NoteBok("N35VZ","Asus",-1000.666666666666666669);

            notebook.Show();

            NoteBok notebook1 = new NoteBok("N35VZ");
             
            notebook1.Show();

            NoteBok notebook2 = new NoteBok(-1000.666666666666666669);

            notebook2.Show();

            NoteBok notebook3 = new NoteBok();

            notebook3.Show();

            //Delay
            Console.ReadKey();
        }
    }
}
