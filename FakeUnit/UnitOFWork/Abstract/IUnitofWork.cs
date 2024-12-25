using FakeUnit.Repository.Abstract;

namespace FakeUnit.UnitOFWork.Abstract;
public interface IUnitofWork
{
    public ICategoryRepository CategoryRepository { get;  }
    public IProductRepository ProductRepository { get; }
    public IItemRepository ItemRepository { get; }

    public IIvoiceRepository VoiceRepository { get; }

}
