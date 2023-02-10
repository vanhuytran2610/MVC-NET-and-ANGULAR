using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        int Count();
        void Save();
    }
}
