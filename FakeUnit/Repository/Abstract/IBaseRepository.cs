namespace FakeUnit.Repository.Abstract;

public interface IBaseRepository<T> 
{
    

    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(int id);
    void Delete(int id);

}
