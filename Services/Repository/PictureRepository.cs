using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class PictureRepository : IPicture
    {
        private readonly MyDBContext _context;
        public PictureRepository(MyDBContext context)
        {
            _context = context;
        }

        public void Create(Picture picture)
        {
            _context.pictures.Add(picture);
        }

        public void Delete(int id)
        {
            var picture = _context.pictures.FirstOrDefault(p => p.Id == id);
            if (picture != null)
            {
                _context.pictures.Remove(picture);
            }
        }

        public Picture GetPicture(int id)
        {
            var picture = _context.pictures.FirstOrDefault(p => p.Id == id);
            if (picture != null)
            {
                return picture;
            }
            return null;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.pictures.Update(picture);
        }
    }
}
