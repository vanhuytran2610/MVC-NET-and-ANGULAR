using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class CustomerRepository : ICustomer
    {
        private readonly MyDBContext _context;
        public CustomerRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.customers.Count();
        }

        public void Create(Customer customer)
        {
            _context.customers.Add(customer);
        }

        public void Delete(int id)
        {
            var customer = _context.customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _context.customers.Remove(customer);
            }
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.customers;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.customers.Update(customer);
        }
    }
}
