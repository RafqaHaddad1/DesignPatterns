using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    //reference/; https://www.dofactory.com/net/memento-design-pattern
    public class Memento
    {
        public void Run()
        {
            // Create a SalesProspect object
            Memento1.SalesProspect prospect = new Memento1.SalesProspect();
            prospect.Name = "John Doe";
            prospect.Phone = "(555) 123-4567";
            prospect.Budget = 10000.0;

            // Store initial state in a Memento
            Memento1.ProspectMemory memory = new Memento1.ProspectMemory();
            memory.Memento = prospect.SaveMemento();

            // Change the state of the SalesProspect object
            prospect.Name = "Jane Smith";
            prospect.Phone = "(555) 987-6543";
            prospect.Budget = 20000.0;

            // Restore the saved state from the Memento
            Console.WriteLine("\nRestoring saved state --\n");
            prospect.RestoreMemento(memory.Memento);

            // Output the final state of the SalesProspect object
            Console.WriteLine("\nFinal state --\n");
            Console.WriteLine($"Name:   {prospect.Name}");
            Console.WriteLine($"Phone:  {prospect.Phone}");
            Console.WriteLine($"Budget: {prospect.Budget}");
        }
        public class Memento1
        {
            //The Memento design pattern without violating encapsulation, captures and externalizes an object‘s internal state so that the object can be restored to this state later. 


            public class SalesProspect
            {
                private string name;
                private string phone;
                private double budget;
                // Gets or sets name
                public string Name
                {
                    get { return name; }
                    set
                    {
                        name = value;
                        Console.WriteLine("Name:   " + name);
                    }
                }
                // Gets or sets phone
                public string Phone
                {
                    get { return phone; }
                    set
                    {
                        phone = value;
                        Console.WriteLine("Phone:  " + phone);
                    }
                }
                // Gets or sets budget
                public double Budget
                {
                    get { return budget; }
                    set
                    {
                        budget = value;
                        Console.WriteLine("Budget: " + budget);
                    }
                }
                // Stores memento
                public Memento SaveMemento()
                {
                    Console.WriteLine("\nSaving state --\n");
                    return new Memento(name, phone, budget);
                }
                // Restores memento
                public void RestoreMemento(Memento memento)
                {
                    Console.WriteLine("\nRestoring state --\n");
                    Name = memento.Name;
                    Phone = memento.Phone;
                    Budget = memento.Budget;
                }
            }
            /// <summary>
            /// The 'Memento' class
            /// </summary>
            public class Memento
            {
                string name;
                string phone;
                double budget;
                // Constructor
                public Memento(string name, string phone, double budget)
                {
                    this.name = name;
                    this.phone = phone;
                    this.budget = budget;
                }
                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }
                public string Phone
                {
                    get { return phone; }
                    set { phone = value; }
                }
                public double Budget
                {
                    get { return budget; }
                    set { budget = value; }
                }
            }
            /// <summary>
            /// The 'Caretaker' class
            /// </summary>
            public class ProspectMemory
            {
                Memento memento;
                public Memento Memento
                {
                    set { memento = value; }
                    get { return memento; }
                }
            }
          
        }
    }
   
}
