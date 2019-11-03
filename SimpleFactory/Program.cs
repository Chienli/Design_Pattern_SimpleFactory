using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Enum;
using SimpleFactory.Factories;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var productFactory = new ProductFactory();
            var applePhone = productFactory.GetProduct(ProductTypeEnum.ApplePhone);
            var googlePhone = productFactory.GetProduct(ProductTypeEnum.GooglePhone);
            applePhone.Describe();
            googlePhone.Describe();
            Console.ReadLine();
        }
    }
}