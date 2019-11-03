using System.Collections.Generic;
using SimpleFactory.Enum;
using SimpleFactory.Models;

namespace SimpleFactory.Factories
{
    internal class ProductFactory : IProductFactory
    {
        private readonly Dictionary<ProductTypeEnum, IProduct> _productMap = new Dictionary<ProductTypeEnum, IProduct>()
        {
            {ProductTypeEnum.ApplePhone, new ApplePhone()},
            {ProductTypeEnum.GooglePhone, new GooglePhone()}
        };

        public IProduct GetProduct(ProductTypeEnum type)
        {
            return _productMap[type];
        }
    }
}