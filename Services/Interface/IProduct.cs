using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
        int Count();
        void Save();
    }
}
