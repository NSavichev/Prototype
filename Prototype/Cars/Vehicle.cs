using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Cars
{
    //Базовый класс транспортного средства
    public abstract class Vehicle : ITransportCloneable<Vehicle>, ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        protected Vehicle(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        // Копирующий конструктор для реализации Прототипа
        protected Vehicle(Vehicle other)
        {
            Manufacturer = other.Manufacturer;
            Model = other.Model;
            Year = other.Year;
        }

        // Реализация пользовательского интерфейса
        public abstract Vehicle BaseClone();

        // Реализация стандартного интерфейса через пользовательский
        public object Clone() => BaseClone();

        public override string ToString() =>
            $"{Manufacturer} {Model} ({Year})";
    }
}
