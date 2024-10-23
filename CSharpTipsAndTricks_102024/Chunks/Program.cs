using Logic;

IEnumerable<Product[]> chunks = ProductList.Products.Chunk(3);

foreach (Product[] chunk in chunks)
{
    foreach (Product product in chunk)
    {
        Console.WriteLine(product.Title);
    }
}