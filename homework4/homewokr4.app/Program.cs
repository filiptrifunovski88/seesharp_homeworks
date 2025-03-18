using System;

namespace homewokr4.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Filip", 231);
            Driver driver2 = new Driver("Mihail", 211);
            Driver driver3 = new Driver("Dimitar", 200);
            Driver driver4 = new Driver("Simon", 250);

            Car car1 = new Car("Mercedes", 150, driver1);
            Car car2 = new Car("BMW", 170, driver2);
            Car car3 = new Car("Audi", 200, driver3);
            Car car4 = new Car("Volkswagen", 160, driver4);

            Car[] cars = { car1, car2, car3, car4 };
            Driver[] drivers = { driver1, driver2, driver3, driver4 };

            Console.Write($"Select first car: ( {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model} ): ");
            string firstCarInput = Console.ReadLine();

            Car firstCar = null;
            foreach (Car car in cars)
            {
                if (car.Model.ToLower() == firstCarInput.ToLower())
                {
                    firstCar = car;
                    break;
                }
            }

            Console.Write($"Select second car: ( {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model} ): ");
            string secondCarInput = Console.ReadLine();

            Car secondCar = null;
            foreach (Car car in cars)
            {
                if (car.Model.ToLower() == secondCarInput.ToLower())
                {
                    secondCar = car;
                    break;
                }
            }

            Console.Write($"Select first driver: ( {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name} ): ");
            string firstDriverInput = Console.ReadLine();

            Driver firstDriver = null;
            foreach (Driver driver in drivers)
            {
                if (driver.Name.ToLower() == firstDriverInput.ToLower())
                {
                    firstDriver = driver;
                    break;
                }
            }

            Console.Write($"Select second driver: ( {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name} ): ");
            string secondDriverInput = Console.ReadLine();

            Driver secondDriver = null;
            foreach (Driver driver in drivers)
            {
                if (driver.Name.ToLower() == secondDriverInput.ToLower())
                {
                    secondDriver = driver;
                    break;
                }
            }

            firstCar.Driver = firstDriver;
            secondCar.Driver = secondDriver;

            Car.RaceCars(firstCar, secondCar);
            Console.ReadLine();
        }
    }
}
