using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAspNetCoreHostedDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        [Route("GetProduct")]
        public ActionResult<List<Product>> GetProduct()
        {
           return productService.GetProduct();
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct([FromBody]Product product)
        {
            productService.AddProduct(product);
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct([FromQuery]string productCode)
        {
            productService.RemoveProduct(productCode);
            return Ok();
        }
      
    }
}
