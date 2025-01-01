using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

namespace FakeUnit.Repository.Concret;
public class CategoryRepository : IBaseRepository<Category>
{
    private readonly BaseContext _basecontext;



    public CategoryRepository(BaseContext basecontext)
    {
        _basecontext = basecontext;
    }

    public void Add(Category entity)
    {
        _basecontext.Categories.Add(entity);
    }

    public void Delete(int id)
    {
        var category = _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        _basecontext.Categories.Remove(category);
    }

    public IEnumerable<Category> GetAll()
    {
        return _basecontext.Categories;
    }

    public Category GetById(int id)
    {
        return _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
    }

    public void Update(int id)
    {
        var category = _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        Console.WriteLine("Successfully update");
    }

}





 



