using System;
using System.Collections.Generic;

namespace Structural
{
public class Composite{
        public void Run()
        {
            // Create individual graphics
            Dot dot1 = new Dot(10, 20);
            Circle circle1 = new Circle(30, 40, 5.0);

            // Create a compound graphic and add individual graphics to it
            CompoundGraphic compound = new CompoundGraphic();
            compound.Add(dot1);
            compound.Add(circle1);

            // Draw and move the compound graphic
            Console.WriteLine("Drawing and moving compound graphic:");
            compound.Draw();
            compound.Move(5, 5);

            // Remove a graphic from the compound and draw again
            compound.Remove(circle1);
            Console.WriteLine("\nDrawing compound graphic after removing Circle:");
            compound.Draw();
        }
        public abstract class Graphic
        {
            public abstract void Move(int x, int y);
            public abstract void Draw();
        }

        public class Dot : Graphic
        {
            protected int X;
            protected int Y;

            public Dot(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override void Move(int x, int y)
            {
                X += x;
                Y += y;
                Console.WriteLine($"Dot moved to ({X}, {Y})");
            }

            public override void Draw()
            {
                Console.WriteLine($"Drawing Dot at ({X}, {Y})");
            }
        }

        public class Circle : Dot
        {
            private double Radius;

            public Circle(int x, int y, double radius) : base(x, y)
            {
                Radius = radius;
            }

            public override void Draw()
            {
                Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
            }
        }

        public class CompoundGraphic : Graphic
        {
            private List<Graphic> _children = new List<Graphic>();

            public void Add(Graphic graphic)
            {
                _children.Add(graphic);
            }

            public void Remove(Graphic graphic)
            {
                _children.Remove(graphic);
            }

            public override void Move(int x, int y)
            {
                foreach (var child in _children)
                {
                    child.Move(x, y);
                }
            }

            public override void Draw()
            {
                foreach (var child in _children)
                {
                    child.Draw();
                }
            }
           
        }
    }
    //Composite with chatgpt improvement 
    //Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.
    

}
