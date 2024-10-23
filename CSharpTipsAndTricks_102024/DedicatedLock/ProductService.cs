using Logic;
using Microsoft.Extensions.Caching.Memory;

namespace DedicatedLock;

internal class ProductService(IMemoryCache memoryCache) : IProductService
{
private readonly Lock _cacheLock = new();

public IEnumerable<Product> GetAll()
{
    string key = "allmovies";
    if (!memoryCache.TryGetValue(key, out List<Product>? products))
    {
        lock (_cacheLock)
        {
            products = ProductList.Products.ToList();
            memoryCache.Set(key, products);
        }
    }
    return products ?? [];
}
}

internal interface IProductService
{
    IEnumerable<Product> GetAll();
}
