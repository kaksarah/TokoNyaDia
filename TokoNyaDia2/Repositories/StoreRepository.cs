using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoNyaDia2.Entities;

namespace TokoNyaDia2.Repositories
{
    internal class StoreRepository : IStoreRepository
    {
        private readonly AppDbContext _appDbContext;
        public StoreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Store store)
        {
            _appDbContext.stores.Remove(store);
            _appDbContext.SaveChanges();
        }

        public List<Store> FindAll()
        {
            return _appDbContext.stores.ToList();
        }

        public Store? FindById(int id)
        {
            return _appDbContext.stores.FirstOrDefault(Store => Store.StoreId.Equals(id));
        }

        public void Save(Store store)
        {
            _appDbContext.stores.Add(store);
            _appDbContext.SaveChanges();
        }

        public void Update(Store store)
        {
            _appDbContext.stores.Update(store);
            _appDbContext.SaveChanges();
        }
    }
}
