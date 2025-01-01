using FakeUnit.Models;
using FakeUnit.Repository.Abstract;
using FakeUnit.Repository.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FakeUnit.Repository.Concret
{
    public class ItemRepository : IBaseRepository<Item>
    {
        private readonly BaseContext _basecontext;

       

        public ItemRepository(BaseContext basecontext)
        {
            _basecontext = basecontext;

            
        }

        public void Add(Item entity)
        {
            
            _basecontext.Items.Add(entity);
        }

        public void Delete(int id)
        {
            var item = _basecontext.Items.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        _basecontext.Items.Remove(item);
        }

        public IEnumerable<Item> GetAll()
        {
            return _basecontext.Items;
        }

        public Item GetById(int id)
        {
            return _basecontext.Items.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
        }

        public void Update(int id)
        {
            var item = _basecontext.Items.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"Id : {id} is false");
            Console.WriteLine("Successfully update");
        }
    }
}


