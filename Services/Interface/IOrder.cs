using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void Delete(int id);
        int Count();
        void Save();
    }
}
