using System;
using System.Collections.Generic;

namespace Flyweight_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            browser.DisplayText("sample page");
            browser.DisplayImage("ads.jpg", 50 , 20);
            browser.DisplayImage("header.jpg", 100, 20);
            browser.DisplayImage("ads.jpg", 500, 600);
        }
    }

    class Image
    {
        public Image()
        {
            Console.WriteLine("image loaded...");
        }
    }

    class DisplayingImage
    {
        public Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Browser
    {
        static Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
        public void DisplayText(string text)
        {
            Console.WriteLine($"{text} rendered to page!");
        }

        public void DisplayImage(string imageUrl, int x, int y)
        {
            if (!dictionary.ContainsKey(imageUrl))
            {
                dictionary.Add(imageUrl, new Image());
            }
            Console.WriteLine($"{imageUrl} rendered to page in ({x}, {y})!");
        }
    }
}
