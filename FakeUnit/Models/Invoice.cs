namespace FakeUnit.Models;
public class Invoice
{
    public int Id { get; set; }

    public List<Item> Items { get; set; }

    public decimal Total_Price { get; set; }

    public Invoice(){}

    public Invoice(int id, List<Item> items, decimal total_Price)
    {
        Id = id;
        Items = items;
        Total_Price = total_Price;
    }
}
