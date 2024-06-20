using System;
using System.Reflection;

namespace DesignPatternConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                Console.WriteLine("Enter a design pattern category:");
                Console.WriteLine("1. Creational \n2. Structural \n3. Behavioral \n-1. Exit");
                string category = Console.ReadLine()?.Trim();
                if (category == "-1")
                {
                    Console.WriteLine("Exiting program...");
                    break; // Exit the while loop and end the program
                }
                if (string.IsNullOrEmpty(category))
                {
                    Console.WriteLine("Invalid input. Please enter a valid category.");
                    continue; // Restart the loop to prompt user again
                }
                string pattern = string.Empty;
                switch (category.ToLower())
                {
                    case "1":
                        Console.WriteLine("Choose one:");
                        Console.WriteLine("1. AbstractFactory \n2. Builder \n3. Factory \n4. Prototype \n5. Singleton");
                        Dictionary<string, string> Creational = new Dictionary<string, string>
                        {
                            { "1", "AbstractFactory" },
                            { "2", "HouseBuilder" },
                            { "3", "Factory" },
                            { "4", "Prototype" },
                            { "5", "Singleton" }
                        };
                        pattern = Console.ReadLine()?.Trim();
                        string creationalAssemblyPath = @"C:\Users\test1\source\repos\DesignPattern\Creational\bin\Debug\net8.0\Creational.dll";
                        string creationalNamespace = "Creational";
                        string creationalClassName = Creational.GetValueOrDefault(pattern);
                        program.ExecutePattern(creationalAssemblyPath, creationalNamespace, creationalClassName);

                        break;
                    case "2":
                        Console.WriteLine("Choose one:");
                        Console.WriteLine("1. Adapter \n2. Bridge \n3. Composite \n4. Decorator \n5. Facade \n6. FlyWeight \n7. Proxy");

                        Dictionary<string, string> Structural = new Dictionary<string, string>
                        {
                            { "1", "Adapter" },
                            { "2", "Bridge" },
                            { "3", "Composite" },
                            { "4", "Decorator" },
                            { "5", "Facade" },
                            { "6", "FlyWeight" },
                            { "7", "Proxy" }
                        };
                        pattern = Console.ReadLine()?.Trim();
                        string structuralAssemblyPath = @"C:\Users\test1\source\repos\DesignPattern\Structural\bin\Debug\net8.0-windows\Structural.dll";
                        string structuralNamespace = "Structural";
                        string structuralClassName = Structural.GetValueOrDefault(pattern);
                        program.ExecutePattern(structuralAssemblyPath, structuralNamespace, structuralClassName);
                        break;
                    case "3":
                        Console.WriteLine("Choose one:");
                        Console.WriteLine("1. ChainOfResponsibility \n2. Command \n3. Iterator \n4. Mediator \n5. Memento \n6. Observer \n7. Strategy \n8. Template \n9. Visitor");
                        Dictionary<string, string> Behavioral = new Dictionary<string, string>
                        {
                            { "1", "ChainOfResponsibility" },
                            { "2", "Command" },
                            { "3", "Iterator" }, 
                            { "4", "Mediator" },
                            { "5", "Memento" },
                            { "6", "Observer" },
                            { "7", "Strategy" },
                            { "8", "Template" },
                            { "9", "Visitor" }
                        };
                        pattern = Console.ReadLine()?.Trim();
                        string behavioralAssemblyPath = @"./Behavioral.dll";
                        string behavioralNamespace = "Behavioral";
                        string behavioralClassName = Behavioral.GetValueOrDefault(pattern);

                        program.ExecutePattern(behavioralAssemblyPath, behavioralNamespace, behavioralClassName);
                        break;
                    case "-1":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid category.");
                        break;
                }
            }
        }
        public void ExecutePattern(string assemblyFilePath, string namespaceName, string className)
        {
            try
            {
                // Construct the full type name
                string fullTypeName = $"{namespaceName}.{className}";
                // Load the assembly from the specified file path
                Assembly assembly = Assembly.LoadFrom(assemblyFilePath);

               /* List all types in the assembly (for debugging purposes)
                 Type[] types = assembly.GetTypes();
                for (int i = 0; i < types.Length; i++)
                {
                    Console.WriteLine(types[i].FullName);
                }
             */
                // Get the type from the assembly
                Type type = assembly.GetType(fullTypeName);
                if (type != null)
                {
                    // Create an instance of the type
                    object instance = Activator.CreateInstance(type);
                    // Invoke the "Run" method
                    MethodInfo method = type.GetMethod("Run");
                    if (method != null)
                    {
                        Console.WriteLine("============================================================");
                        method.Invoke(instance, null);
                        Console.WriteLine("============================================================");
                    }
                    else
                    {
                        Console.WriteLine($"Method 'Run' not found in class '{className}'.");
                    }
                }
                else
                {
                    Console.WriteLine($"Class '{className}' not found in assembly '{assemblyFilePath}'.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Assembly file '{assemblyFilePath}' not found: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}