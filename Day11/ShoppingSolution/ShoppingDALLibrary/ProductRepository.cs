using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class ProductRepository : AbstractRepository<int, Product>
    {
        public override Product Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override Product GetByKey(int key)
        {
            //Predicate<Product> findProduct =(p)=>p.Id==key;
            //Product product = items.ToList().Find(findProduct);

            //Product product = items.ToList().Find((p) => p.Id == key);

            Product product = items.FirstOrDefault(p => p.Id == key);
            return product;

        }

        public override Product Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
