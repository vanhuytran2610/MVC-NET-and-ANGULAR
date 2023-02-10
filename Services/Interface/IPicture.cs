using NET_Angular.Models;

namespace NET_Angular.Services.Interface
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void Create(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        void Save();
    }
}
