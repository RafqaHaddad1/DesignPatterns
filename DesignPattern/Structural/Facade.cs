using System;

namespace Structural
{
    internal class Facade
    {
        public class Plumbing
        {
            private double pressure;

            public void SetPressure(double value)
            {
                pressure = value;
            }

            public void TurnOn()
            {
                Console.WriteLine($"Plumbing system turned on with pressure: {pressure}");
            }

            public void TurnOff()
            {
                Console.WriteLine("Plumbing system turned off.");
            }
        }

        public class Electrical
        {
            private double voltage;

            public void SetVoltage(double value)
            {
                voltage = value;
            }

            public void TurnOn()
            {
                Console.WriteLine($"Electrical system turned on with voltage: {voltage}");
            }

            public void TurnOff()
            {
                Console.WriteLine("Electrical system turned off.");
            }
        }

        public class HouseFacade
        {
            private Plumbing plumbing;
            private Electrical electrical;

            public HouseFacade()
            {
                plumbing = new Plumbing();
                electrical = new Electrical();
            }

            public void TurnOnSystem(double voltage, double pressure)
            {
                electrical.SetVoltage(voltage);
                electrical.TurnOn();
                plumbing.SetPressure(pressure);
                plumbing.TurnOn();
            }

            public void ShutDown()
            {
                electrical.TurnOff();
                plumbing.TurnOff();
            }
        }

        public void Run()
        {
            // Using the Facade to manage complex subsystems (Plumbing and Electrical systems) of a House
            HouseFacade houseFacade = new HouseFacade();

            // Simulate user interaction to control house systems
            Console.WriteLine("Welcome to the House Control Panel!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Turn On Systems");
                Console.WriteLine("2 - Turn Off Systems");
                Console.WriteLine("0 - Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter electrical system voltage (e.g., 120.0): ");
                        double voltage;
                        if (double.TryParse(Console.ReadLine(), out voltage))
                        {
                            Console.Write("Enter plumbing system pressure (e.g., 500.0): ");
                            double pressure;
                            if (double.TryParse(Console.ReadLine(), out pressure))
                            {
                                houseFacade.TurnOnSystem(voltage, pressure);
                                Console.WriteLine("\nSystems turned on.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for pressure. Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for voltage. Try again.");
                        }
                        break;
                    case "2":
                        houseFacade.ShutDown();
                        Console.WriteLine("\nSystems turned off.");
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("\nExiting House Control Panel. Goodbye!");
        }
    }
}
