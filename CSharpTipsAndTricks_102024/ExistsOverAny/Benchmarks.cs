using BenchmarkDotNet.Attributes;
using Logic;
using System;
using System.Linq;

namespace ExistsOverAny;

public class Benchmarks
{
    [Benchmark]
    public void UsingAny()
    {
        string hasProductsBeingOrderedAny = ProductList.Products.Any(x => x.Status == Status.Ordered)
            ? "There are products being ordered."
            : "There are no products being orderd right now.";

        Console.WriteLine(hasProductsBeingOrderedAny);
    }

    [Benchmark]
    public void UsingExists()
    {
        string hasProductsBeingOrderedExists = ProductList.Products.Exists(x => x.Status == Status.Ordered)
            ? "There are products being ordered."
            : "There are no products being orderd right now.";

        Console.WriteLine(hasProductsBeingOrderedExists);
    }
}
