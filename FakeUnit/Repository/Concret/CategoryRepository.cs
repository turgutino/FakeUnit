using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

namespace FakeUnit.Repository.Concret;
public class CategoryRepository : ICategoryRepository
{
    private readonly BaseContext _basecontext;



    public CategoryRepository(BaseContext basecontext)
    {
        _basecontext = basecontext;
    }
    public void Add(Category category)
    {
        _basecontext.Categories.Add(category);
    }

    public void Delete(int id)
    {
        var category = _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        _basecontext.Categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _basecontext.Categories;
    }

    public Category GetById(int id)
    {
        return _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
    }

    public void Update(int id)
    {
        var product = _basecontext.Categories.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        Console.WriteLine("Successfully update");
    }
}







