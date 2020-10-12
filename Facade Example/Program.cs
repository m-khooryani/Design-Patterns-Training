using System;

namespace Facade_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class CPU
    {
        public void Freeze() { /* code here */ }
        public void Jump(int position) { /* code here */ }
        public void Execute() { /* code here */ }
    }

    class Memory
    {
        public void Load(int position, object data) { /* code here */ }
    }

    class HardDrive
    {
        public object Read(int lba, int size)
        {
            return new object();
        }
    }

    class ComputerFacade
    {
        private CPU processor;
        private Memory ram;
        private HardDrive hd;
        private int BOOT_SECTOR;

        public ComputerFacade()
        {
            this.processor = new CPU();
            this.ram = new Memory();
            this.hd = new HardDrive();
        }

        public int BOOT_ADDRESS { get; private set; }
        public int SECTOR_SIZE { get; private set; }

        public void Start()
        {
            this.processor.Freeze();
            this.ram.Load(this.BOOT_ADDRESS, this.hd.Read(this.BOOT_SECTOR, this.SECTOR_SIZE));
            this.processor.Jump(this.BOOT_ADDRESS);
            this.processor.Execute();
        }
    }
}
