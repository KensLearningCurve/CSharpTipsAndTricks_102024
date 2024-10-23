using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Logic;
using System.Collections.Frozen;

public class Program
{
    public static void Main(string[] args)
    {
        var config = DefaultConfig.Instance;
        var summary = BenchmarkRunner.Run<Benchmarks>(config, args);
    }
}

public class Benchmarks
{
    [Benchmark]
    public void NormalList()
    {
        List<Product> products = ProductList.Products;

        foreach (Product product in products)
        {
            Console.WriteLine(product.Title);
        }
    }

    [Benchmark]
    public void ForzenList()
    {
        FrozenSet<Product> frozenProducts = ProductList.Products.ToFrozenSet();

        foreach (Product product in frozenProducts)
        {
            Console.WriteLine(product.Title);
        }
    }
}