using System;

namespace Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            HouseDirector director = new HouseDirector(iglooBuilder);

            director.ConstructHouse();

            House house = director.GetHouse();

            Console.WriteLine("Builder constructed: " + house);
        }
    }

    // Director
    class HouseDirector
    {
        private IHouseBuilder houseBuilder;

        public HouseDirector(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return this.houseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            this.houseBuilder.BuildBasement();
            this.houseBuilder.BuildStructure();
            this.houseBuilder.BulidRoof();
            this.houseBuilder.BuildInterior();
        }
    }

    // concrete builder
    class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.Basement = "Ice Bars";
        }

        public void BuildStructure()
        {
            house.Structure = "Ice Blocks";
        }

        public void BuildInterior()
        {
            house.Interior = "Ice Carvings";
        }

        public void BulidRoof()
        {
            house.Roof = "Ice Dome";
        }

        public House GetHouse()
        {
            return this.house;
        }
    }

    // Builder
    interface IHouseBuilder
    {
        void BuildBasement();
        void BuildStructure();
        void BulidRoof();
        void BuildInterior();
        House GetHouse();
    }

    // product
    class House
    {
        public string Basement { get; set; }
        public string Structure { get; set; }
        public string Roof { get; set; }
        public string Interior { get; set; }
    }
}
