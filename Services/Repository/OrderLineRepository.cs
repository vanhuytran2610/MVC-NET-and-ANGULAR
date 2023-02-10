using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class OrderLineRepository : IOrderLine
    {
        private readonly MyDBContext _context;
        public OrderLineRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.orderLines.Count();
        }

        public void Create(OrderLine orderLine)
        {
            _context.orderLines.Add(orderLine);
        }

        public OrderLine GetOrderLine(int id)
        {
            var orderLine = _context.orderLines.FirstOrDefault(o => o.Id == id);
            if (orderLine == null)
            {
                return orderLine;
            }
            return null;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.orderLines;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine orderLine)
        {
            _context.orderLines.Update(orderLine);
        }
    }
}
