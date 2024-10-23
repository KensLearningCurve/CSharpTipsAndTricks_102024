namespace Logic;

public class Product
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int Stock { get; set; }
    public Status Status { get; set; }
    public bool Available { get; set; }
}
