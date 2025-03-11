public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public bool ShowProperties { get; set; }
    public decimal Price { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; }
}
