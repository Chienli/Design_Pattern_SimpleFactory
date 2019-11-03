using System;

namespace SimpleFactory.Models
{
    internal class ApplePhone : IProduct
    {
        public void Describe()
        {
            Console.WriteLine($"I am an IPhone {GetType()}");
        }
    }
}