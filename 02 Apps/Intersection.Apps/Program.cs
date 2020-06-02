using Intersection.Logic;
using System;

namespace Intersection.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            var arrayInterSection = new ArrayInterSection();
            Console.WriteLine(arrayInterSection.GetInterSection(strArray));
            Console.ReadLine();
        }
    }
}
