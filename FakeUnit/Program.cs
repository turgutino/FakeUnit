using FakeUnit.Models;

namespace FakeUnit;

using FakeUnit.Repository.DbContext;
using FakeUnit.UnitOFWork.Concret;

class Program
{

    static void Main(string[] args)
    {
        BaseContext context = new BaseContext();
        UnitOfWork unitOfWork=new UnitOfWork(context);
        Category category = new Category(1,"Et Mehsullari");
        Category category2 = new Category(1,"Sud Mehsullari");
        Product product = new Product(1,"Kolbasa",category,12);
        
        unitOfWork.CategoryRepository.Add(category);
        unitOfWork.CategoryRepository.Add(category2);

        unitOfWork.ProductRepository.Add(product);

        var product3 = unitOfWork.ProductRepository.GetById(1);
        Console.WriteLine(product3);
        
    }
}
        
        


