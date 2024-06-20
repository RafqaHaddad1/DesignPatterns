using System;

namespace Creational
{
    public  class Factory
    {
        // Abstract shape class
        public abstract class Shape
        {
            public abstract void Draw();
        }

        // Rectangle class implementing Shape
        internal class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Inside Rectangle::Draw() method.");
            }
        }

        // Square class implementing Shape
        public class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Inside Square::Draw() method.");
            }
        }

        // Factory method to create shapes
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("Square", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }

            return null;
        }
    public void Run()
        {
            Console.WriteLine("Welcome to the Shape Factory!");

            while (true)
            {
                Console.WriteLine("\nChoose a shape to create:");
                Console.WriteLine("1 - Rectangle");
                Console.WriteLine("2 - Square");
                Console.WriteLine("3 - Exit");

                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();

                Shape shape = null;

                switch (choice)
                {
                    case "1":
                        shape = GetShape("Rectangle");
                        break;
                    case "2":
                        shape = GetShape("Square");
                        break;
                    case "3":
                        Console.WriteLine("Exiting Shape Factory.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                        break;
                }

                if (shape != null)
                {
                    shape.Draw();
                }
            }
        }
    
    }

}
