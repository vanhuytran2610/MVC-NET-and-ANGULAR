using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly MyDBContext _context;
        public ProductRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.products.Count();
        }

        public void Create(Product product)
        {
            _context.products.Add(product);
        }

        public void Delete(int id)
        {
            var product = _context.products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.products.Remove(product);
            }
        }

        public Product GetProduct(int id)
        {
            var product = _context.products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.products;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.products.Update(product);
        }
    }
}
