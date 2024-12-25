using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

namespace FakeUnit.Repository.Concret;
public class ItemRepository : IItemRepository
{
    private readonly BaseContext _basecontext;

    public ItemRepository(BaseContext basecontext)
    {
        _basecontext = basecontext;
    }
    public void Add(Item product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Item> GetAll()
    {
        throw new NotImplementedException();
    }

    public Item GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}
