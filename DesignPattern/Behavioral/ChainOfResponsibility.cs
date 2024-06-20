using System;

namespace Behavioral
{
    public class ChainOfResponsibility
    {
        public void Run()
        {
            // Create handlers
            IHandler handler1 = new ConcreteHandler1();
            IHandler handler2 = new ConcreteHandler2();

            // Chain them together
            handler1 = new ConcreteHandler1(handler2);

            Console.WriteLine("Welcome to the Chain of Responsibility Example\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter your request (type 'exit' to quit):");
                Console.WriteLine("to handle it should be Handler1 or Handler2 else no response");
                string requestContent = Console.ReadLine();

                if (requestContent.ToLower() == "exit")
                {
                    running = false;
                    continue;
                }

                // Create request object
                Request request = new Request(requestContent);

                // Process the request
                handler1.HandleRequest(request);

                Console.WriteLine(); // Empty line for better readability
            }

            Console.WriteLine("\nExiting Chain of Responsibility Example. Goodbye!");
        }

        // Handler interface
        public interface IHandler
        {
            void HandleRequest(Request request);
        }

        // Request class
        public class Request
        {
            public string Content { get; }

            public Request(string content)
            {
                Content = content;
            }
        }

        // Concrete handler 1
        public class ConcreteHandler1 : IHandler
        {
            private IHandler nextHandler;

            public ConcreteHandler1(IHandler nextHandler = null)
            {
                this.nextHandler = nextHandler;
            }

            public void HandleRequest(Request request)
            {
                if (request.Content.Contains("Handler1"))
                {
                    Console.WriteLine($"Request handled by ConcreteHandler1: {request.Content}");
                }
                else if (nextHandler != null)
                {
                    nextHandler.HandleRequest(request);
                }
                else
                {
                    Console.WriteLine($"Request cannot be handled by any handler.");
                }
            }
        }

        // Concrete handler 2
        public class ConcreteHandler2 : IHandler
        {
            private IHandler nextHandler;

            public ConcreteHandler2(IHandler nextHandler = null)
            {
                this.nextHandler = nextHandler;
            }

            public void HandleRequest(Request request)
            {
                if (request.Content.Contains("Handler2"))
                {
                    Console.WriteLine($"Request handled by ConcreteHandler2: {request.Content}");
                }
                else if (nextHandler != null)
                {
                    nextHandler.HandleRequest(request);
                }
                else
                {
                    Console.WriteLine($"Request cannot be handled by any handler.");
                }
            }
        }
    }
}
