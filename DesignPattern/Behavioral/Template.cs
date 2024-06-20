using System;

namespace Behavioral
{
    // Template Method pattern example with user interaction
    public class Template
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose a beverage to make:");
                Console.WriteLine("1 - Make Tea");
                Console.WriteLine("2 - Make Coffee");
                Console.WriteLine("0 - Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nMaking Tea:");
                        BeverageMaker teaMaker = new TeaMaker();
                        teaMaker.MakeBeverage();
                        break;
                    case "2":
                        Console.WriteLine("\nMaking Coffee:");
                        BeverageMaker coffeeMaker = new CoffeeMaker();
                        coffeeMaker.MakeBeverage();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0.");
                        break;
                }
            }

            Console.WriteLine("\nExiting Template Method Example. Goodbye!");
        }

        abstract class BeverageMaker
        {
            // Template method defining the overall process
            public void MakeBeverage()
            {
                BoilWater();
                Brew();
                PourInCup();
                AddCondiments();
            }

            // Abstract methods to be implemented by subclasses
            protected abstract void Brew();
            protected abstract void AddCondiments();

            // Common methods
            private void BoilWater()
            {
                Console.WriteLine("Boiling water");
            }

            private void PourInCup()
            {
                Console.WriteLine("Pouring into cup");
            }
        }

        class TeaMaker : BeverageMaker
        {
            protected override void Brew()
            {
                Console.WriteLine("Steeping the tea");
            }

            protected override void AddCondiments()
            {
                Console.WriteLine("Adding lemon");
            }
        }

        class CoffeeMaker : BeverageMaker
        {
            protected override void Brew()
            {
                Console.WriteLine("Dripping coffee through filter");
            }

            protected override void AddCondiments()
            {
                Console.WriteLine("Adding sugar and milk");
            }
        }
    }
}
