using System;

namespace Creational
{
    /*
        Singleton class vs. Static methods
        The following compares Singleton class vs. Static methods,

        A Static Class cannot be extended whereas a singleton class can be extended.
        A Static Class cannot be initialized whereas a singleton class can be.
        A Static class is loaded automatically by the CLR when the program containing the class is loaded.
     */

    public class Singleton
    {
        public class ConfigurationManager
        {
            // The single instance of the class
            private static ConfigurationManager? _instance;
            // Lock object to ensure thread safety during instance creation
            private static readonly object _lock = new object();

            // Private constructor to prevent instantiation from outside the class
            private ConfigurationManager()
            {
                // Initialize the configuration settings dictionary
                Settings = new Dictionary<string, string>();
            }

            // Public static property to provide global access to the single instance
            public static ConfigurationManager Instance
            {
                get
                {
                    // Ensure thread safety with double-check locking pattern
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigurationManager();
                        }
                        return _instance;
                    }
                }
            }

            // Dictionary to store configuration settings as key-value pairs
            public Dictionary<string, string> Settings { get; private set; }

            // Method to get a configuration setting by key
            public string GetSetting(string key)
            {
                // Return the setting value if the key exists, otherwise return null
                return Settings.ContainsKey(key) ? Settings[key] : null;
            }

            // Method to set a configuration setting
            public void SetSetting(string key, string value)
            {
                // Add or update the setting value in the dictionary
                Settings[key] = value;
            }
        }
        public void Run()
        {
            // Access the Singleton instance and set configuration settings
            ConfigurationManager configManager = ConfigurationManager.Instance;
            configManager.SetSetting("AppTitle", "Singleton Pattern Example");
            configManager.SetSetting("Version", "1.0.0");

            // Access the Singleton instance again from another part of the application
            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            Console.WriteLine("AppTitle: " + anotherConfigManager.GetSetting("AppTitle")); // Outputs: Singleton Pattern Example
            Console.WriteLine("Version: " + anotherConfigManager.GetSetting("Version"));   // Outputs: 1.0.0

            // Verify that both references point to the same instance
            Console.WriteLine(Object.ReferenceEquals(configManager, anotherConfigManager)); // Outputs: True

        }
    }

   
}
