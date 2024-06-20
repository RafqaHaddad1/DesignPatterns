using System;
using System.Collections.Generic;

namespace Behavioral
{
    //reference: https://www.c-sharpcorner.com/article/observer-design-pattern-using-c-sharp/
    public class Observer
    {
        public void Run()
        {
            // Create a subject (publisher)
            Subject subject = new Subject();

            // Create observers (subscribers)
            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");
            ConcreteObserver observer3 = new ConcreteObserver("Observer 3");

            // Register observers with the subject
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            subject.RegisterObserver(observer3);

            // Simulate publishing a new article
            subject.Articles++;

            // Unregister observer2
            subject.UnregisterObserver(observer2);

            // Simulate publishing another new article
            subject.Articles++;
        }
        public interface IObserver
        {
            void Update();
        }

        public class ConcreteObserver : IObserver
        {
            public string ObserverName { get; }

            public ConcreteObserver(string name)
            {
                ObserverName = name;
            }

            public void Update()
            {
                // Observer can update their system accordingly  
                Console.WriteLine("Hello " + ObserverName + ", a new article has been published by the author.");
            }
        }

        public interface ISubject
        {
            void RegisterObserver(IObserver observer);
            void UnregisterObserver(IObserver observer);
            void NotifyObservers();
        }

        public class Subject : ISubject
        {
            private readonly List<IObserver> _observers = new List<IObserver>();
            private int _articlesCount = 1;

            public int Articles
            {
                get => _articlesCount;
                set
                {
                    if (value > _articlesCount)
                    {
                        _articlesCount = value;
                        NotifyObservers();
                    }
                }
            }

            public void RegisterObserver(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void UnregisterObserver(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void NotifyObservers()
            {
                foreach (var observer in _observers)
                {
                    observer.Update();
                }
            }
         
        }

    }


}
