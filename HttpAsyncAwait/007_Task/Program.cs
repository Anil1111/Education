using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Task
{
    struct Train
    {
        private readonly string destinationPoint;
        private readonly int trainNumber;
        private readonly DateTime departureTime;

        public string DestinationPoint => destinationPoint;
        public int TrainNumber => trainNumber;
        public DateTime DepartureTime => departureTime;

        public Train(string destinationPoint, int trainNumber, DateTime departureTime)
        {
            this.destinationPoint = destinationPoint;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }
    }

    class TrainHandler
    {

        private Train[] trainarray;
        public void ReceiveData()
        {
            var trainMassive = new Train[8];
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine($"Enter destination point name, number for train for Note №{i}, departure time.");
                var enteredLine = Console.ReadLine();
                var splitedValues = enteredLine.Split(',');
                var train = new Train(splitedValues[0],
                    Convert.ToInt32(splitedValues[1]),
                    DateTime.Parse(splitedValues[2])); //или можно Convert.ToDateTime(splitedValues[2])
                trainMassive[i - 1] = train;
            }

            this.trainarray = trainMassive;
        }

        public Train[] SortUp(Train[] array) //сортировка по возрастанию!
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = array.Length - 1; j > i; j--)
                {
                    if (array[i].TrainNumber > array[j].TrainNumber)
                    {
                        var x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }
                }
            }

            return array;
        }

        public void ShowSelectedTrainInfo()
        {
            Console.WriteLine("Enter info about the train whose info you want to be displayed");
            var trainNumber = Convert.ToInt32(Console.ReadLine());
            if (trainarray.Any(x => x.TrainNumber == trainNumber))
            {
                var info = this.trainarray.First(x => x.TrainNumber == trainNumber);
                Console.WriteLine($"The train with destination point {info.DestinationPoint} and " +
                                  $"number {info.TrainNumber} leaves at {info.DepartureTime}.");
            }
            else
            {
                Console.WriteLine("You entered wrong train number.");
            }                      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var train = new TrainHandler();
            train.ReceiveData();
            train.ShowSelectedTrainInfo();

            //Delay
            Console.ReadKey();
        }
    }
}
