using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Cars
{
    //КЛАСС ЭЛЕКТРОМОБИЛЯ
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int Range { get; set; }

        public ElectricCar(string manufacturer, string model, int year,
                          int batteryCapacity, int range)
            : base(manufacturer, model, year, 0, "Electric")
        {
            BatteryCapacity = batteryCapacity;
            Range = range;
        }

        // Копирующий конструктор
        protected ElectricCar(ElectricCar other) : base(other)
        {
            BatteryCapacity = other.BatteryCapacity;
            Range = other.Range;
        }

        // Глубокое клонирование с вызовом родительских конструкторов
        public override Vehicle BaseClone() => new ElectricCar(this);

        // Специфичный метод клонирования для ElectricCar
        public new ElectricCar CloneCar() => (ElectricCar)BaseClone();

        public override string ToString() =>
            $"{base.ToString()}, Battery: {BatteryCapacity}kWh, Range: {Range}km";
    }
}
