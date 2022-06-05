using System;

namespace ConsoleAppTest
{
    public enum ShippingMethod
    {
        RegularAirMail,
        RegisteredAirMail,
        Express
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.RegularAirMail;
            Console.WriteLine((int)method);
            Console.WriteLine((ShippingMethod)method);
            Console.WriteLine(method.ToString());
        }   
    }
}
