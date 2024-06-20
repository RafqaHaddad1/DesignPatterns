using System;
using System.Collections.Generic;

namespace Structural
{
    internal class FlyWeight
    {
        public class Font
        {
            private readonly string _style;
            private readonly int _size;
            private readonly string _color;

            public Font(string style, int size, string color)
            {
                _style = style;
                _size = size;
                _color = color;
            }

            public void Display(string text)
            {
                Console.WriteLine($"Text: '{text}' | Size: {_size} | Style: {_style} | Color: {_color}");
            }
        }

        public class FontFactory
        {
            private readonly Dictionary<string, Font> _fonts = new Dictionary<string, Font>();

            public Font GetFont(string style, int size, string color)
            {
                string key = $"{style}-{size}-{color}";
                if (!_fonts.ContainsKey(key))
                {
                    _fonts[key] = new Font(style, size, color);
                }
                return _fonts[key];
            }
        }
        public void Run()
        {
            // Create a font factory
            FlyWeight.FontFactory factory = new FlyWeight.FontFactory();

            // Get fonts from the factory
            FlyWeight.Font font1 = factory.GetFont("Arial", 12, "Black");
            FlyWeight.Font font2 = factory.GetFont("Times New Roman", 14, "Red");
            FlyWeight.Font font3 = factory.GetFont("Arial", 12, "Black"); // Reusing existing font

            // Display texts using the fonts
            font1.Display("Hello, World!");
            font2.Display("Flyweight Pattern Example");
            font3.Display("Reuse Arial 12 Black");

            // Demonstrate that font3 is the same instance as font1
            Console.WriteLine($"font1 == font3 ? {ReferenceEquals(font1, font3)}"); // Should be true
        }
    }
}
