using System;
//builder design pattern
//Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
namespace Creational
{
    public class HouseBuilder
    {
        private bool walls;
        private bool doors;
        private bool roof;
        private bool garage;

        public HouseBuilder()
        {
            walls = false;
            doors = false;
            roof = false;
            garage = false;
        }

        public HouseBuilder BuildWalls()
        {
            this.walls = true;
            return this;
        }

        public HouseBuilder BuildDoors()
        {
            this.doors = true;
            return this;
        }

        public HouseBuilder BuildRoof()
        {
            this.roof = true;
            return this;
        }

        public HouseBuilder BuildGarage()
        {
            this.garage = true;
            return this;
        }

        public House GetResult()
        {
            return new House(walls, doors, roof, garage);
        }
        public void Run()
        {
            
                Console.WriteLine("Welcome to the House Builder!");

                while (true)
                {
                    Console.WriteLine("\nChoose a component to build:");
                    Console.WriteLine("1 - Walls");
                    Console.WriteLine("2 - Doors");
                    Console.WriteLine("3 - Roof");
                    Console.WriteLine("4 - Garage");
                    Console.WriteLine("5 - Finish and display the house");
                    Console.WriteLine("6 - Exit without finishing");

                    Console.Write("Enter your choice (1-6): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            BuildWalls();
                            Console.WriteLine("Walls built.");
                            break;
                        case "2":
                            BuildDoors();
                            Console.WriteLine("Doors built.");
                            break;
                        case "3":
                            BuildRoof();
                            Console.WriteLine("Roof built.");
                            break;
                        case "4":
                            BuildGarage();
                            Console.WriteLine("Garage built.");
                            break;
                        case "5":
                            House house = GetResult();
                            Console.WriteLine("\nFinal House Details:");
                            Console.WriteLine(house.ToString());
                            return;
                        case "6":
                            Console.WriteLine("Exiting without finishing.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                            break;
                    }
                }

            

        }
    }

    public class House
    {
        public bool Walls { get; }
        public bool Doors { get; }
        public bool Roof { get; }
        public bool Garage { get; }

        public House(bool walls, bool doors, bool roof, bool garage)
        {
            Walls = walls;
            Doors = doors;
            Roof = roof;
            Garage = garage;
        }

        public override string ToString()
        {
            return $"House [Walls: {Walls}, Doors: {Doors}, Roof: {Roof}, Garage: {Garage}]";
        }

        
    }
  
}
