using System;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "My", "Name", "Is", "Jewoo", "Ham" };

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }   
    }
}
