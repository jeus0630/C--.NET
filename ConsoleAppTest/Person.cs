using System;

namespace ConsoleAppTest
{
    public class Person
    {
        public string firstnName;
        public string lastName;
        public void Introduce()
        {
            Console.WriteLine($"My name is {firstnName} {lastName}");
        }
    }
}
