using System;

namespace Structural
{
    // Component interface
    public class Decorator
    {
        public interface INotifier
        {
            string Send(string message);
        }

        // Concrete component
        public class BaseNotifier : INotifier
        {
            public string Send(string message)
            {
                // Simulate sending message through base notifier
                return $"Base Notifier: {message}";
            }
        }

        // Decorator base class
        public abstract class NotifierDecorator : INotifier
        {
            protected INotifier notifier;

            public NotifierDecorator(INotifier notifier)
            {
                this.notifier = notifier;
            }

            public virtual string Send(string message)
            {
                return notifier.Send(message); // Delegates sending to the wrapped component
            }
        }

        // Concrete decorator - SMS notifier
        public class SMSNotifier : NotifierDecorator
        {
            public SMSNotifier(INotifier notifier) : base(notifier)
            {
            }

            public override string Send(string message)
            {
                // Decorate with SMS notification
                return $"{base.Send(message)} + SMS Notification";
            }
        }

        // Concrete decorator - Email notifier
        public class EmailNotifier : NotifierDecorator
        {
            public EmailNotifier(INotifier notifier) : base(notifier)
            {
            }

            public override string Send(string message)
            {
                // Decorate with Email notification
                return $"{base.Send(message)} + Email Notification";
            }
        }

        // Client application
        public class Application
        {
            private INotifier notifier;

            public Application SetNotifier(INotifier notifier)
            {
                this.notifier = notifier;
                return this;
            }

            public void DoSomething()
            {
                if (notifier != null)
                {
                    string result = notifier.Send("Sending message using Decorator Design Pattern!");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Notifier is not set.");
                }
            }
        }

        
            public void Run()
            {
                // Create a base notifier
                INotifier baseNotifier = new BaseNotifier();

                // Prompt user to add SMS notification
                Console.Write("Do you want to add SMS notification? (yes/no): ");
                string addSMS = Console.ReadLine().Trim().ToLower();

                if (addSMS == "yes")
                {
                    baseNotifier = new SMSNotifier(baseNotifier);
                }

                // Prompt user to add Email notification
                Console.Write("Do you want to add Email notification? (yes/no): ");
                string addEmail = Console.ReadLine().Trim().ToLower();

                if (addEmail == "yes")
                {
                    baseNotifier = new EmailNotifier(baseNotifier);
                }

                // Use the application with the decorated notifier
                Application app = new Application();
                app.SetNotifier(baseNotifier);

                // Demonstrate sending a message through the decorated notifier
                app.DoSomething();
            }
        


    }

}
