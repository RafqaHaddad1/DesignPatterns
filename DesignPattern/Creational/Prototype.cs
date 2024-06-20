using System;

namespace Creational
{
    public class Prototype
    {
        public abstract class Shape : ICloneable
        {
            public string Id { get; set; }
            public string Type { get; protected set; }

            public abstract object Clone();
        }

        public class Circle : Shape
        {
            public Circle()
            {
                Type = "Circle";
            }

            public override object Clone()
            {
                return this.MemberwiseClone();
            }
        }

        public class Rectangle : Shape
        {
            public Rectangle()
            {
                Type = "Rectangle";
            }

            public override object Clone()
            {
                return this.MemberwiseClone();
                //MemberwiseClone is a protected method in the System.Object class in .NET
                //that creates a shallow copy of the current object.
                //When you call MemberwiseClone, it creates a new object and copies the non-static fields
                //of the current object to the new object. For reference types, it copies the references but not the objects they point to.
            }
        }
        public void Run()
        {
            // Create instances of Circle and Rectangle
            Prototype.Shape circle = new Prototype.Circle { Id = "1" };
            Prototype.Shape rectangle = new Prototype.Rectangle { Id = "2" };

            // Clone the shapes
            Prototype.Shape clonedCircle = (Prototype.Shape)circle.Clone();
            Prototype.Shape clonedRectangle = (Prototype.Shape)rectangle.Clone();

            // Display original and cloned shapes
            Console.WriteLine("Original Circle: Id = {0}, Type = {1}", circle.Id, circle.Type);
            Console.WriteLine("Cloned Circle: Id = {0}, Type = {1}", clonedCircle.Id, clonedCircle.Type);
            Console.WriteLine("Original Rectangle: Id = {0}, Type = {1}", rectangle.Id, rectangle.Type);
            Console.WriteLine("Cloned Rectangle: Id = {0}, Type = {1}", clonedRectangle.Id, clonedRectangle.Type);
        }
        
    }
}
