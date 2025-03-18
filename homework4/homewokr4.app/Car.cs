namespace homewokr4.app
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }

        public static void RaceCars(Car car1, Car car2)
        {
            int speed1 = car1.CalculateSpeed();
            int speed2 = car2.CalculateSpeed();

            if (speed1 > speed2)
            {
                Console.WriteLine($"{car1.Model} driven by {car1.Driver.Name} won!");
            }
            else if (speed2 > speed1)
            {
                Console.WriteLine($"{car2.Model} driven by {car2.Driver.Name} won!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
