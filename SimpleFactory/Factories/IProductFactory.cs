using SimpleFactory.Enum;
using SimpleFactory.Models;

namespace SimpleFactory.Factories
{
    internal interface IProductFactory
    {
        IProduct GetProduct(ProductTypeEnum type);
    }
}