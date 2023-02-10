using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);
        int Count();
        void Save();
    }
}
