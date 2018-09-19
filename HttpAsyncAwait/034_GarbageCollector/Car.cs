namespace _034_GarbageCollector
{
    class Car
    {
        private int speed;
        private string name;

        public Car()
        {
            
        }

        public Car(string name, int speed)
        {
            this.speed = speed;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} едет со скоростью {speed} Км/ч";
        }
    }
}
