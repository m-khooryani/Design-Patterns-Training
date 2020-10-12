using System;

namespace Singleton_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ClassicSingleton.MyInt);
            Console.ReadKey();
        }
    }

    sealed class ClassicSingleton
    {
        public static int MyInt = 25;
        static ClassicSingleton()
        {
            Instance = new ClassicSingleton();
            Console.WriteLine("instance created");
        }

        private ClassicSingleton()
        {

        }

        public static ClassicSingleton Instance { get; private set; }
    }

    sealed class LazySingleton
    {
        private static Lazy<LazySingleton> lazy;

        static LazySingleton()
        {
            lazy = new Lazy<LazySingleton>(() => new LazySingleton());
        }

        private LazySingleton() { }
    }
}
