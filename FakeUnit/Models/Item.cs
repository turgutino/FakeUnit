namespace FakeUnit.Models;
public class Item
{
    public int Id { get; set; }

    

    public List<Product> products { get; set; }   

    public decimal Price { get; set; }

    public Item() {}

    public Item(int id, List<Product> products, decimal price)
    {
        Id = id;
        
        this.products = products;
        Price = price;
    }
}
