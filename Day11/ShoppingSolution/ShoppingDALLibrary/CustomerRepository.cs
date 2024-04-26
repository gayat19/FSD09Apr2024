using ShoppingModelLibrary;
using ShoppingModelLibrary.Exceptions;

namespace ShoppingDALLibrary
{
    public class CustomerRepository : AbstractRepository<int, Customer>
    {
        public override async Task<Customer> Add(Customer item)
        {
            item.IsActive = true;
            return base.Add(item).Result;
        }
        public override async Task<Customer> Delete(int key)
        {
            Customer customer = items.SingleOrDefault(c=>c.Id == key);
            if(customer != null) 
            { 
                //items.Remove(customer);
                customer.IsActive = false;
            }
            return customer;
        }

        public override async Task<Customer> GetByKey(int key)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == key)
                    return items[i];
            }
            throw new NoCustomerWithGiveIdException();
        }

        public override async Task<Customer> Update(Customer item)
        {
            Customer customer = await GetByKey(item.Id);
            if (customer != null)
            {
                customer = item;
            }
            return customer;
        }
    }
}
