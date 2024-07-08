using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ShopContext _shopContext;
        public ProductController(ShopContext shopContext)
        {
           _shopContext = shopContext;
        }
        [HttpGet]   
        public ActionResult<List<Product>> Get()
        {
            return _shopContext.Products.ToList();
        }
    }
}
