using System;
using ConsoleAppTest.Math;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var John = new Person();
            John.firstnName = "John";
            John.lastName = "Smith";
            John.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }   
    }
}
