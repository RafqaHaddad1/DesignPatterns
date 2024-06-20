using System;

namespace Creational
{
    public class AbstractFactory
    {
        public abstract class Product
        {
            public abstract void Use();
        }

        public class Shape : Product
        {
            public override void Use()
            {
                Console.WriteLine("Drawing a shape");
            }
        }

        public class Color : Product
        {
            public override void Use()
            {
                Console.WriteLine("Filling with color");
            }
        }

        public class Rectangle : Shape
        {
            public override void Use()
            {
                Console.WriteLine("Drawing a rectangle");
            }
        }

        public class Square : Shape
        {
            public override void Use()
            {
                Console.WriteLine("Drawing a square");
            }
        }

        public class Red : Color
        {
            public override void Use()
            {
                Console.WriteLine("Filling with red color");
            }
        }

        public class Blue : Color
        {
            public override void Use()
            {
                Console.WriteLine("Filling with blue color");
            }
        }

        public interface IAbstractFactory
        {
            Product CreateProduct(string productType);
        }

        public class GeometricFactory : IAbstractFactory
        {
            public Product CreateProduct(string productType)
            {
                if (productType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
                {
                    return new Rectangle();
                }
                else if (productType.Equals("Square", StringComparison.OrdinalIgnoreCase))
                {
                    return new Square();
                }
                else
                {
                    return null;
                }
            }
        }

        public class ColorFactory : IAbstractFactory
        {
            public Product CreateProduct(string productType)
            {
                if (productType.Equals("Red", StringComparison.OrdinalIgnoreCase))
                {
                    return new Red();
                }
                else if (productType.Equals("Blue", StringComparison.OrdinalIgnoreCase))
                {
                    return new Blue();
                }
                else
                {
                    return null;
                }
            }
        }

        public void Run()
        {
            IAbstractFactory factory = null;

            while (true)
            {
                Console.WriteLine("** Choose a Factory (s/c): **");
                Console.WriteLine("s - Shape Factory");
                Console.WriteLine("c - Color Factory");

                string factoryChoice = Console.ReadLine().ToLower();

                if (factoryChoice == "s")
                {
                    factory = new GeometricFactory();
                    break;
                }
                else if (factoryChoice == "c")
                {
                    factory = new ColorFactory();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 's' or 'c'.");
                }
            }

            while (true)
            {
                Console.WriteLine("** Choose a Product (Based on the chosen Factory): **");
                if (factory is GeometricFactory)
                {
                    Console.WriteLine("Rectangle");
                    Console.WriteLine("Square");
                }
                else if (factory is ColorFactory)
                {
                    Console.WriteLine("red - Red Color");
                    Console.WriteLine("blue - Blue Color");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Factory Type");
                    break;
                }

                string productChoice = Console.ReadLine().ToLower();
                Product product = factory.CreateProduct(productChoice);

                if (product != null)
                {
                    product.Use();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid product option.");
                }
            }
        }
    }
}
