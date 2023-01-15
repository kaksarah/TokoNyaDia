using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoNyaDia2.Entities;

namespace TokoNyaDia2.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Customer customer)
        {
            _appDbContext.customers.Remove(customer);
            _appDbContext.SaveChanges();
        }

        public List<Customer> FindAll()
        {
            return _appDbContext.customers.ToList();
        }

        public Customer? FindById(int id)
        {
            return _appDbContext.customers.FirstOrDefault(Customer => Customer.CustomerId.Equals(id));
        }

        public void Save(Customer customers)
        {
            _appDbContext.customers.Add(customers);
            _appDbContext.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _appDbContext.customers.Update(customer);
            _appDbContext.SaveChanges();
        }
    }
}
