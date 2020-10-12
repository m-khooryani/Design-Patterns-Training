using Microsoft.Extensions.DependencyInjection;
using System;

namespace Decorator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRepository, Repository>()
                .Decorate<IRepository, LoggedRepository>()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<IRepository>();
            Console.WriteLine(service.Get());
        }
    }

    interface IRepository
    {
        string Get();
    }

    class Repository : IRepository
    {
        public string Get()
        {
            return "some string";
        }
    }

    class LoggedRepository : IRepository
    {
        private readonly IRepository repository;

        public LoggedRepository(IRepository repository)
        {
            this.repository = repository;
        }

        public string Get()
        {
            Console.WriteLine("method Started");
            return this.repository.Get();
        }
    }
}
