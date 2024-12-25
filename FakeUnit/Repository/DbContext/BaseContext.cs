using FakeUnit.Models;

namespace FakeUnit.Repository.DbContext;

public class BaseContext
{
    public List<Product> Products { get; set; }

    public List<Category> Categories { get; set; }  
         
    public List<Item> Items { get; set; }

    public List<Invoice> Invoices { get; set; }
    

    public BaseContext()
    {
        Products = new List<Product>();
        Categories = new List<Category>();
        Items = new List<Item>();
        Invoices = new List<Invoice>();
    }
}
