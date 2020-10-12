using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyImage proxyImage1 = new ProxyImage("cat.jpg");
            proxyImage1.Draw();
            proxyImage1.Draw();

            ProxyImage proxyImage2 = new ProxyImage("dog.jpg");
            proxyImage2.Draw();

            ProxyImage proxyImage3 = new ProxyImage("cat.jpg");
            proxyImage3.Draw();
        }
    }

    interface Image
    {
        void Draw();
    }

    class RealImage : Image
    {
        public string filePath { get; set; }
        public RealImage(string filePath)
        {
            this.filePath = filePath;
            Console.WriteLine("Read Image From Hard Disk");
        }

        public void Draw()
        {
            Console.WriteLine($"RealImage::Draw {filePath}");
        }
    }

    class ProxyImage : Image
    {
        private static List<RealImage> images = new List<RealImage>();
        private string filePath;

        public ProxyImage(string filePath)
        {
            this.filePath = filePath;
        }

        public void Draw()
        {
            if (!images.Any(x => x.filePath == filePath))
            {
                images.Add(new RealImage(filePath));
            }
            images.First(x => x.filePath == filePath).Draw();
        }
    }
}
