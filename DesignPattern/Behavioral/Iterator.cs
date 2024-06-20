namespace Behavioral
{
    public class Iterator
    {
        public void Run()
        {
            // Using the Iterator pattern with NameRepository

            // Create a NameRepository instance
            IteratorPattern.NameRepository namesRepository = new IteratorPattern.NameRepository();

            // Get the iterator
            IteratorPattern.IIterator iterator = namesRepository.GetIterator();

            // Traverse and print all names using the iterator
            Console.WriteLine("Names:");
            while (iterator.HasNext())
            {
                string name = (string)iterator.Next();
                Console.WriteLine(name);
            }
        }
        public class IteratorPattern
        {
            public interface IIterator
            {
                bool HasNext();
                object Next();
            }

            public interface IContainer
            {
                IIterator GetIterator();
            }

            public class NameRepository : IContainer
            {
                public string[] names = { "John", "Jane", "Jack", "Jill" };

                public IIterator GetIterator()
                {
                    return new NameIterator(this);
                }

                private class NameIterator : IIterator
                {
                    private int index;
                    private NameRepository _nameRepository;

                    public NameIterator(NameRepository nameRepository)
                    {
                        _nameRepository = nameRepository;
                    }

                    public bool HasNext()
                    {
                        return index < _nameRepository.names.Length;
                    }

                    public object Next()
                    {
                        if (this.HasNext())
                        {
                            return _nameRepository.names[index++];
                        }
                        return null;
                    }
                }
            }
          
        }
    }
    
}
