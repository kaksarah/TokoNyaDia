using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoNyaDia2.Entities;

namespace TokoNyaDia2.Repositories
{
    public interface IStoreRepository
    {
        void Save(Store store);
        Store? FindById(int id);
        List<Store> FindAll();
        void Update(Store store);
        void Delete(Store store);
    }
}
