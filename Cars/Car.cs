using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Cars
{
    public class Car : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }

        public Car(string manufacturer, string model, int year,
                   int engineCapacity, string fuelType)
            : base(manufacturer, model, year)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
        }

        // Копирующий конструктор
        protected Car(Car other) : base(other)
        {
            EngineCapacity = other.EngineCapacity;
            FuelType = other.FuelType;
        }

        // Глубокое клонирование с вызовом родительского конструктора
        public override Vehicle BaseClone() => new Car(this);

        // Специфичный метод клонирования для Car
        public Car CloneCar() => (Car)BaseClone();

        public override string ToString() =>
            $"{base.ToString()}, {EngineCapacity}cc, {FuelType}";
    }
}
