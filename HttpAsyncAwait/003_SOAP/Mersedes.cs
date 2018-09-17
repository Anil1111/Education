using System;

namespace _003_SOAP
{
    //Класс Mersedes будет доступен для сериализации.
    [Serializable]
    public class Mersedes : Car
    {
        //Два режима работы - Спорт и Люкс
        protected Mode mode;

        public Mersedes(string name, int speed, Mode mode)
        : base(name, speed)
        {
            this.mode = mode;
        }

        public void SetMode(Mode mode)
        {
            this.mode = mode;
            Console.WriteLine($"Mode '{this.mode}' was succefsully set");
        }

        public void ShowMode() => Console.WriteLine(this.mode);
    }
}
