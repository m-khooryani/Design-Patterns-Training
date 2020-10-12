using System;
using System.Collections.Generic;

namespace Visitor_Example
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
            FruitPartitioner partitioner = new FruitPartitioner();
            foreach (Fruit fruit in fruits)
            {
                fruit.Accept(partitioner);
            }
            Console.WriteLine("Oranges.Count: {0}", partitioner.Oranges.Count);
            Console.WriteLine("Apples.Count: {0}", partitioner.Apples.Count);
            Console.WriteLine("Bananas.Count: {0}", partitioner.Bananas.Count);
        }
    }

    interface IFruitVisitor
    {
        void Visit(Orange fruit);
        void Visit(Apple fruit);
        void Visit(Banana fruit);
    }

    class FruitPartitioner : IFruitVisitor
    {
        public List<Orange> Oranges { get; private set; }
        public List<Apple> Apples { get; private set; }
        public List<Banana> Bananas { get; private set; }

        public FruitPartitioner()
        {
            Oranges = new List<Orange>();
            Apples = new List<Apple>();
            Bananas = new List<Banana>();
        }

        public void Visit(Orange fruit)
        {
            Oranges.Add(fruit);
        }
        public void Visit(Apple fruit)
        {
            Apples.Add(fruit);
        }
        public void Visit(Banana fruit)
        {
            Bananas.Add(fruit);
        }
    }

    abstract class Fruit
    {
        public abstract void Accept(IFruitVisitor visitor);
    }
    class Orange : Fruit
    {
        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Apple : Fruit
    {
        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Banana : Fruit
    {
        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
