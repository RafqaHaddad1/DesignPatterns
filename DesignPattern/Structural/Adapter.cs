using System;

namespace Structural
{
    public class Adapter
    {
        // RoundHole class
        public class RoundHole
        {
            private int radius;

            public RoundHole(int radius)
            {
                this.radius = radius;
            }

            public int GetRadius()
            {
                return radius;
            }

            public bool Fits(RoundPeg peg)
            {
                return radius >= peg.GetRadius();
            }
        }

        // RoundPeg class
        public class RoundPeg
        {
            private int radius;

            public RoundPeg(int radius)
            {
                this.radius = radius;
            }

            public virtual int GetRadius()
            {
                return radius;

                //The reason for marking the GetRadius method as virtual in the RoundPeg class is to allow it to be overridden in derived classes, such as SquarePegAdapter.
                //In C#, a method must be marked as virtual, abstract, or override in the base class if you want to provide a different implementation in a derived class.
            }
        }

        // SquarePeg class
        public class SquarePeg
        {
            private int width;

            public SquarePeg(int width)
            {
                this.width = width;
            }

            public int GetWidth()
            {
                return width;
            }
        }

        // SquarePegAdapter class
        public class SquarePegAdapter : RoundPeg
        {
            private SquarePeg peg;

            public SquarePegAdapter(SquarePeg peg) : base(0)
            {
                this.peg = peg;
            }

            public override int GetRadius()
            {
                // Calculate a fitting radius for the square peg
                return (int)(peg.GetWidth() * Math.Sqrt(2) / 2);
            }
        }
        public void Run()
        {
            // Create a round hole with a given radius
            Console.Write("Enter the radius of the round hole: ");
            int holeRadius = int.Parse(Console.ReadLine());
            RoundHole roundHole = new RoundHole(holeRadius);

            // Create a round peg with a given radius
            Console.Write("Enter the radius of the round peg: ");
            int roundPegRadius = int.Parse(Console.ReadLine());
            RoundPeg roundPeg = new RoundPeg(roundPegRadius);

            // Check if the round peg fits in the round hole
            Console.WriteLine($"Round peg fits in round hole: {roundHole.Fits(roundPeg)}");

            // Create square pegs with given widths
            Console.Write("\nEnter the width of the small square peg: ");
            int smallSquarePegWidth = int.Parse(Console.ReadLine());
            SquarePeg smallSquarePeg = new SquarePeg(smallSquarePegWidth);

            Console.Write("Enter the width of the large square peg: ");
            int largeSquarePegWidth = int.Parse(Console.ReadLine());
            SquarePeg largeSquarePeg = new SquarePeg(largeSquarePegWidth);

            // Adapt square pegs to round hole using adapters
            SquarePegAdapter smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
            SquarePegAdapter largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);

            // Check if the adapted square pegs fit in the round hole
            Console.WriteLine($"Small square peg fits in round hole: {roundHole.Fits(smallSquarePegAdapter)}");
            Console.WriteLine($"Large square peg fits in round hole: {roundHole.Fits(largeSquarePegAdapter)}");
        }
    }
}
