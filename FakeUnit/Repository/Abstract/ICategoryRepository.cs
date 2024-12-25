using FakeUnit.Models;

namespace FakeUnit.Repository.Abstract;
public interface ICategoryRepository
{
    public void Add(Category category);

    public void Update(int id);

    public void Delete(int id);

    public Category GetById(int id);

    public List<Category> GetAll();
}
