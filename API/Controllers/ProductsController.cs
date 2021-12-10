using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "These are products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "These is a product";
        }
    }
}