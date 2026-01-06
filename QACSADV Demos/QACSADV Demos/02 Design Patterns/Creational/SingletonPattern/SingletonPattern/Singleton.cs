using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Singleton
    {
        // Private static variable that holds the single instance.
        private static Singleton instance = null;

        // Lock synchronization object
        private static readonly object padlock = new object();

        // Private constructor to prevent instance creation.
        private Singleton()
        {
        }

        // Public static property to access the instance.
        public static Singleton Instance
        {
            get
            {
                lock (padlock) // Ensures thread safety
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        // Example method that can be called on the singleton
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
}
