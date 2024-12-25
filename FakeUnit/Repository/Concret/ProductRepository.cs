using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

namespace FakeUnit.Repository.Concret;
public class ProductRepository : IProductRepository
{
    private readonly BaseContext _basecontext;
    

    public ProductRepository(BaseContext basecontext)
    {
        _basecontext = basecontext;
    }

    public void Add(Product product)
    {
        _basecontext.Products.Add(product);
    }
    public void Delete(int id)
    {
        var product = _basecontext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        _basecontext.Products.Remove(product);
    }

    public List<Product> GetAll()
    {
        return _basecontext.Products;
    }

    public Product GetById(int id)
    {
        return _basecontext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
    }

    public void Update(int id)
    {
        var product = _basecontext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        Console.WriteLine("Successfully update");
    }
}
