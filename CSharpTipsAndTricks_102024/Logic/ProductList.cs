namespace Logic
{
    public static class ProductList
    {
        public static List<Product> Products = new()
        {
            new() { Id = 1, Title = "7Up", Status = Status.Ordered, Stock = 10, Available = true },
            new() { Id = 2, Title = "Chips", Status = Status.Ordered, Stock = 0, Available = true },
            new() { Id = 3, Title = "Sugar", Status = Status.Delivered, Stock = 67, Available = true },
            new() { Id = 4, Title = "Meatballs", Status = Status.Delivered, Stock = 5, Available = true },
            new() { Id = 5, Title = "Milk", Status = Status.Delivered, Stock = 7, Available = true },
            new() { Id = 6, Title = "Chewinggum", Status = Status.Delivered, Stock = 0, Available = false },
            new() { Id = 7, Title = "Toiletpaper", Status = Status.Delivered, Stock = 1, Available = true },
            new() { Id = 8, Title = "Tea", Status = Status.Delivered, Stock = 5, Available = true },
            new() { Id = 9, Title = "Coffee", Status = Status.Delivered, Stock = 85, Available = true },
            new() { Id = 10, Title = "Biscuits", Status = Status.Delivered, Stock = 12, Available = true },
            new() { Id = 11, Title = "Chocolate", Status = Status.Delivered, Stock = 89, Available = true },
            new() { Id = 12, Title = "Bread", Status = Status.Delivered, Stock = 167, Available = true },
        };
    }
}