// See https://aka.ms/new-console-template for more information
using Prototype.Cars;

Console.WriteLine("=== ДЕМОНСТРАЦИЯ ПАТТЕРНА 'ПРОТОТИП' ===\n");

// Создаем оригинальные объекты
var tesla = new ElectricCar("Tesla", "Model S", 2023, 100, 600);
var toyota = new Car("Toyota", "Camry", 2022, 2500, "Petrol");
var mountainBike = new Bicycle("Trek", "X-Caliber", 2023, 12, "Mountain");

Console.WriteLine("Оригинальные объекты:");
Console.WriteLine($"1. {tesla}");
Console.WriteLine($"2. {toyota}");
Console.WriteLine($"3. {mountainBike}\n");

// Клонирование через IMyCloneable
Console.WriteLine("Клонирование через IMyCloneable:");
var teslaClone = tesla.BaseClone() as ElectricCar;
var toyotaClone = toyota.BaseClone() as Car;
var bikeClone = mountainBike.BaseClone() as Bicycle;

// Модифицируем клоны для демонстрации независимости
teslaClone!.Range = 650;
toyotaClone!.EngineCapacity = 3000;
bikeClone!.Gears = 10;

Console.WriteLine($"Клон Tesla: {teslaClone}");
Console.WriteLine($"Клон Toyota: {toyotaClone}");
Console.WriteLine($"Клон велосипеда: {bikeClone}\n");

// Проверка, что оригиналы не изменились
Console.WriteLine("Оригиналы (должны остаться без изменений):");
Console.WriteLine($"Tesla: {tesla}");
Console.WriteLine($"Toyota: {toyota}");
Console.WriteLine($"Велосипед: {mountainBike}\n");

// Клонирование через ICloneable
Console.WriteLine("Клонирование через ICloneable:");
var teslaClone2 = (ElectricCar)tesla.Clone();
var toyotaClone2 = (Car)toyota.Clone();

// Демонстрация приведения типов
teslaClone2.Model = "Model 3";
toyotaClone2.Model = "Corolla";

Console.WriteLine($"Клон 2 Tesla: {teslaClone2}");
Console.WriteLine($"Клон 2 Toyota: {toyotaClone2}\n");

// Тестирование полиморфизма
Console.WriteLine("=== ТЕСТИРОВАНИЕ ПОЛИМОРФИЗМА ===");
var vehicles = new List<Vehicle> { tesla, toyota, mountainBike };

foreach (var vehicle in vehicles)
{
    var clone = vehicle.BaseClone();
    Console.WriteLine($"Оригинал: {vehicle.GetType().Name} - {vehicle}");
    Console.WriteLine($"Клон: {clone.GetType().Name} - {clone}");
    Console.WriteLine($"Равны по ссылкам? {ReferenceEquals(vehicle, clone)}");
    Console.WriteLine($"Типы совпадают? {vehicle.GetType() == clone.GetType()}\n");
}

// Демонстрация специфичных методов клонирования
Console.WriteLine("=== СПЕЦИФИЧНЫЕ МЕТОДЫ КЛОНИРОВАНИЯ ===");
var specificTeslaClone = tesla.CloneCar();
var specificBikeClone = mountainBike.CloneBicycle();

Console.WriteLine($"Специфичный клон Tesla: {specificTeslaClone}");
Console.WriteLine($"Специфичный клон велосипеда: {specificBikeClone}");

Console.ReadLine();