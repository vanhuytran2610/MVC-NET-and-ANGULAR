using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Create(OrderLine orderLine);
        void Update(OrderLine orderLine);
        int Count();
        void Save();
    }
}
