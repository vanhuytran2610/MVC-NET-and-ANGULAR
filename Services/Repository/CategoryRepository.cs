using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly MyDBContext _context;

        public CategoryRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.categories.Count();
        }

        public void Create(Category category)
        {
            _context.categories.Add(category);
        }

        public void Delete(int id)
        {
            var category = _context.categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.categories;
        }

        public Category GetCategory(int id)
        {
            var category = _context.categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                return category;
            }
            return null;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.categories.Update(category);
        }
    }
}
