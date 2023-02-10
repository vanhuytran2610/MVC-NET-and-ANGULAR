using NET_Angular.Data;
using NET_Angular.Models;
using NET_Angular.Services.Interface;

namespace NET_Angular.Services.Repository
{
    public class CartItemRepository : ICartItem
    {
        private readonly MyDBContext _context;

        public CartItemRepository(MyDBContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.cartItems.Count();
        }

        public void Create(CartItem cartItem)
        {
            _context.cartItems.Add(cartItem);
        }

        public void Delete(int id)
        {
            var cartItem = _context.cartItems.FirstOrDefault(c => c.Id == id);
            if (cartItem != null)
            {
                _context.cartItems.Remove(cartItem);
            }
        }

        public CartItem GetCartItem(int id)
        {
            var cartItem = _context.cartItems.FirstOrDefault(c => c.Id == id);
            if (cartItem != null )
            {
                return cartItem;
            }
            return null;
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _context.cartItems;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _context.cartItems.Update(cartItem);
        }
    }
}
