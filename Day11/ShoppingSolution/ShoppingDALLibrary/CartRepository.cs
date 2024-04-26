using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class CartRepository : AbstractRepository<int, Cart>
    {
        public override async Task<Cart> Delete(int key)
        {
            var cart = await GetByKey(key);
            if (cart != null)
            {
                items.Remove(cart);
            }
            return cart;
        }

        public override async Task<Cart> GetByKey(int key)
        {
           return items.FirstOrDefault(c=>c.Id==key)??throw new NoCartWithGivenID(key);
        }

        public override async Task<Cart> Update(Cart item)
        {
            throw new NotImplementedException();
        }
    }
}
