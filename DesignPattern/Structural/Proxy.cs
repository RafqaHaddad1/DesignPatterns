using System;

namespace Structural
{
    public interface Image
    {
        void Display();
    }

    public class RealImage : Image
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromDisk(filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + filename);
        }

        private void LoadFromDisk(string filename)
        {
            Console.WriteLine("Loading " + filename);
        }
    }

    public class ProxyImage : Image
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string filename)
        {
            this.fileName = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }

    public class ImageViewer
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Image Viewer!");

            Image image1 = new ProxyImage("image1.jpg");
            Image image2 = new ProxyImage("image2.png");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an image to display:");
                Console.WriteLine("1 - Display Image 1");
                Console.WriteLine("2 - Display Image 2");
                Console.WriteLine("0 - Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Displaying Image 1:");
                        image1.Display();
                        break;
                    case "2":
                        Console.WriteLine("Displaying Image 2:");
                        image2.Display();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0.");
                        break;
                }
            }

            Console.WriteLine("\nExiting Image Viewer. Goodbye!");
        }
    }
}
