using FakeUnit.Models;

namespace FakeUnit.Repository.Abstract;
public interface IProductRepository
{
    public void Add(Product product);

    public void Update(int id);

    public void Delete(int id);

    public Product GetById(int id);

    public List<Product> GetAll();
}

