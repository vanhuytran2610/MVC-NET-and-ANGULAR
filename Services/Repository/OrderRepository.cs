using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly MyDBContext _context;
        public OrderRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.orders.Remove(order);
            }
        }

        public Order GetOrder(int id)
        {
            var order = _context.orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;       
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.orders;                 
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
