namespace ConsoleApp4
{
    internal class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TopSpeed { get; set; }
        public int Handling { get; set; }

        public Car(string name, string type, int topSpeed, int handling)
        {
            Name = name;
            Type = type;
            TopSpeed = topSpeed;
            Handling = handling;
        }

        public void UpdateParameter(string parameter, int value)
        {
            switch (parameter.ToLower())
            {
                case "topspeed":
                    TopSpeed = value;
                    break;
                case "handling":
                    Handling = value;
                    break;
                default:
                    Console.WriteLine("Invalid parameter.");
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Type}) - Top Speed: {TopSpeed}, Handling: {Handling}";
        }
        static void Main(string[] args)
        {
            List<Car> inventory = new List<Car>();

           
            inventory.Add(new Car("Car 1", "Super car", int.MaxValue, 0));
            inventory.Add(new Car("Car 2", "Sedan car", 200, 5));
            inventory.Add(new Car("Car 3", "SUV", 180, 3));
            inventory.Add(new Car("Car 4", "Minivan", 180, 6));

            
            Console.WriteLine("Current Inventory:");
            foreach (var car in inventory)
            {
                Console.WriteLine(car);
            }

            
            Console.WriteLine("\nEnter the car number to update parameters (1, 2, 3, 4):");
            int carIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the parameter to update (topspeed, handling):");
            string parameter = Console.ReadLine();

            Console.WriteLine("Enter the new value:");
            int value = int.Parse(Console.ReadLine());

            inventory[carIndex].UpdateParameter(parameter, value);

            
            Console.WriteLine("\nUpdated Inventory:");
            foreach (var car in inventory)
            {
                Console.WriteLine(car);
            }
        }
    }
}
