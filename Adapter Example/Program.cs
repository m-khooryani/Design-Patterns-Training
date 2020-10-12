using System;

namespace Adapter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IBinaryReader binaryReader = new BinaryReader();
            Console.WriteLine(binaryReader.Read("11101"));
        }
    }

    interface INumberReader
    {
        int Read(string s, int @base);
    }

    class NumberReader : INumberReader
    {
        public int Read(string s, int @base)
        {
            // complicated code
            int z = 1;
            int n = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int x = s[i] - 0x30;
                n += x * z;
                z *= @base;
            }
            return n;
        }
    }

    interface IBinaryReader
    {
        int Read(string s);
    }

    class BinaryReader : IBinaryReader
    {
        public int Read(string s)
        {
            return new NumberReader().Read(s, 2);
        }
    }
}
