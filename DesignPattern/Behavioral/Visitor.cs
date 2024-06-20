using System;

namespace Behavioral
{
    public class Visitor
    {
        private static int CalculatePrice(IItemElement[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (IItemElement item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Shopping Cart!");

            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("\nChoose an item to add to your cart:");
                Console.WriteLine("1 - Add Book");
                Console.WriteLine("2 - Add Fruit");
                Console.WriteLine("0 - Checkout");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book price: ");
                        int bookPrice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter book ISBN: ");
                        string isbn = Console.ReadLine();
                        Book book = new Book(bookPrice, isbn);
                        AddToCart(book);
                        break;
                    case "2":
                        Console.Write("Enter fruit name: ");
                        string fruitName = Console.ReadLine();
                        Console.Write("Enter price per kg: ");
                        int pricePerKg = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter weight (in kg): ");
                        int weight = Convert.ToInt32(Console.ReadLine());
                        Fruit fruit = new Fruit(pricePerKg, weight, fruitName);
                        AddToCart(fruit);
                        break;
                    case "0":
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0.");
                        break;
                }
            }

            Console.WriteLine("\nCalculating total cost...");
            int total = CalculatePrice(cart.ToArray());
            Console.WriteLine("Total Cost = " + total);
            Console.WriteLine("Thank you for shopping with us!");
        }

        private List<IItemElement> cart = new List<IItemElement>();

        private void AddToCart(IItemElement item)
        {
            cart.Add(item);
            Console.WriteLine("Item added to cart.");
        }

        // ItemElement interface
        interface IItemElement
        {
            int Accept(IShoppingCartVisitor visitor);
        }

        // Book class implementing IItemElement
        class Book : IItemElement
        {
            private int price;
            private string isbnNumber;

            public Book(int cost, string isbn)
            {
                this.price = cost;
                this.isbnNumber = isbn;
            }

            public int GetPrice()
            {
                return price;
            }

            public string GetIsbnNumber()
            {
                return isbnNumber;
            }

            public int Accept(IShoppingCartVisitor visitor)
            {
                return visitor.Visit(this);
            }
        }

        // Fruit class implementing IItemElement
        class Fruit : IItemElement
        {
            private int pricePerKg;
            private int weight;
            private string name;

            public Fruit(int priceKg, int wt, string nm)
            {
                this.pricePerKg = priceKg;
                this.weight = wt;
                this.name = nm;
            }

            public int GetPricePerKg()
            {
                return pricePerKg;
            }

            public int GetWeight()
            {
                return weight;
            }

            public string GetName()
            {
                return name;
            }

            public int Accept(IShoppingCartVisitor visitor)
            {
                return visitor.Visit(this);
            }
        }

        // ShoppingCartVisitor interface
        interface IShoppingCartVisitor
        {
            int Visit(Book book);
            int Visit(Fruit fruit);
        }

        // ShoppingCartVisitor implementation
        class ShoppingCartVisitorImpl : IShoppingCartVisitor
        {
            public int Visit(Book book)
            {
                int cost;
                // Apply $5 discount if book price is greater than $50
                if (book.GetPrice() > 50)
                {
                    cost = book.GetPrice() - 5;
                }
                else
                {
                    cost = book.GetPrice();
                }
                Console.WriteLine("Book ISBN: " + book.GetIsbnNumber() + " cost = " + cost);
                return cost;
            }

            public int Visit(Fruit fruit)
            {
                int cost = fruit.GetPricePerKg() * fruit.GetWeight();
                Console.WriteLine(fruit.GetName() + " cost = " + cost);
                return cost;
            }
        }
    }
}
