using System;
using System.Collections.Generic;

namespace NonVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new Fruit[]
                {
                    new Orange(), new Apple(), new Banana(),
                    new Banana(), new Banana(), new Orange()
                };
            List<Orange> oranges = new List<Orange>();
            List<Apple> apples = new List<Apple>();
            List<Banana> bananas = new List<Banana>();
            foreach (Fruit fruit in fruits)
            {
                if (fruit is Orange)
                {
                    oranges.Add((Orange)fruit);
                }
                else if (fruit is Apple)
                {
                    apples.Add((Apple)fruit);
                }
                else if (fruit is Banana)
                {
                    bananas.Add((Banana)fruit);
                }
            }
            Console.WriteLine($"we have {oranges.Count} oranges, {apples.Count} apples, {bananas.Count} bananas.");
        }
    }
    class Fruit { }
    class Orange : Fruit { }
    class Apple : Fruit { }
    class Banana : Fruit { }
}
