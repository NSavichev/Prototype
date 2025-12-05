using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Cars
{
    // КЛАСС ВЕЛОСИПЕДА
    public class Bicycle : Vehicle
    {
        public int Gears { get; set; }
        public string BicycleType { get; set; }

        public Bicycle(string manufacturer, string model, int year,
                      int gears, string bicycleType)
            : base(manufacturer, model, year)
        {
            Gears = gears;
            BicycleType = bicycleType;
        }

        // Копирующий конструктор
        protected Bicycle(Bicycle other) : base(other)
        {
            Gears = other.Gears;
            BicycleType = other.BicycleType;
        }

        // Глубокое клонирование
        public override Vehicle BaseClone() => new Bicycle(this);

        // Специфичный метод клонирования
        public Bicycle CloneBicycle() => (Bicycle)BaseClone();

        public override string ToString() =>
            $"{base.ToString()}, {Gears} gears, Type: {BicycleType}";
    }
}
