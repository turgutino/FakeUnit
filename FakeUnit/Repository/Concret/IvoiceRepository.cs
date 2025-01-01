using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

namespace FakeUnit.Repository.Concret;

public class InvoiceRepository: IBaseRepository<Invoice>
{
    private readonly BaseContext _basecontext;


    public InvoiceRepository(BaseContext basecontext)
    {
        _basecontext = basecontext;

    }

    public void Add(Invoice entity)
    {
        _basecontext.Invoices.Add(entity);
    }

    public void Delete(int id)
    {
        var invoice = _basecontext.Invoices.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        _basecontext.Invoices.Remove(invoice);
    }

    public IEnumerable<Invoice> GetAll()
    {
        return _basecontext.Invoices;
    }

    public Invoice GetById(int id)
    {
        return _basecontext.Invoices.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
    }

    public void Update(int id)
    {
        var invoice = _basecontext.Invoices.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        Console.WriteLine("Successfully update");
    }
}
