using System;

namespace SimpleFactory.Models
{
    internal class GooglePhone : IProduct
    {
        public void Describe()
        {
            Console.WriteLine($"I am a Pixel {GetType()}");
        }
    }
}