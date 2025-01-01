using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;

using FakeUnit.Repository.Concret;

namespace FakeUnit.UnitOFWork.Concret
{
    public class UnitOfWork 
    {
        public BaseContext _basecontext;
        public ProductRepository ProductRepository;
        public CategoryRepository CategoryRepository;
        public ItemRepository ItemRepository;
        public InvoiceRepository InvoiceRepository; 

        public UnitOfWork(BaseContext context)
        {
            _basecontext = context;
            ProductRepository = new ProductRepository(_basecontext);
            CategoryRepository = new CategoryRepository(_basecontext);
            ItemRepository = new ItemRepository(_basecontext);
            InvoiceRepository = new InvoiceRepository(_basecontext); 
        }
    }
}
