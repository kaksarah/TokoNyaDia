using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoNyaDia2.Entities;

namespace TokoNyaDia2.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customers);
        Customer? FindById(int id);
        List<Customer> FindAll();
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
