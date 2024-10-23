using DedicatedLock;
using Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddMemoryCache();
        services.AddScoped<IProductService, ProductService>();
    })
    .Build();


IProductService productService = host.Services.GetService<IProductService>() ?? throw new NotImplementedException();
IEnumerable<Product> products = productService.GetAll();

foreach (Product product in products)
{
    Console.WriteLine($"{product.Title} - {product.Stock}");
}



