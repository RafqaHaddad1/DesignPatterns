using System;

namespace Behavioral
{
    // Mediator pattern is used to reduce communication complexity between multiple objects or classes.
    // This pattern provides a mediator class which normally handles all the communications between different classes and supports easy maintenance of the code by loose coupling. 
    public class Mediator
    {
        public class ChatRoom
        {
            public static void ShowMessage(User user, string message)
            {
                Console.WriteLine($"{DateTime.Now.ToString()} [{user.Name}] : {message}");
            }
        }

        public class User
        {
            public string Name { get; private set; }

            public User(string name)
            {
                Name = name;
            }

            public void SendMessage(string message)
            {
                ChatRoom.ShowMessage(this, message);
            }
        }
        public void Run()
        {
            // Create users
            Mediator.User user1 = new Mediator.User("User1");
            Mediator.User user2 = new Mediator.User("User2");

            // User1 sends message
            user1.SendMessage("Hello, User2!");

            // User2 sends message
            user2.SendMessage("Hi, User1!");

            // Additional interaction
            user1.SendMessage("How are you?");
            user2.SendMessage("I'm fine, thanks!");

            // Output messages from the chat room
            // (Since messages are printed directly by ChatRoom.ShowMessage method)
        }
    }
}
