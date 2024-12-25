using FakeUnit.Models;
using FakeUnit.Repository.Concret;

namespace FakeUnit.Repository.Abstract;

public interface IIvoiceRepository
{
    public void Add(Concret.IvoiceRepository product);

    public void Update(int id);

    public void Delete(int id);

    public Concret.IvoiceRepository GetById(int id);

    public List<Concret.IvoiceRepository> GetAll();
}
