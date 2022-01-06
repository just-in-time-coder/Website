using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext m_StoreContext;

        public ProductsController(StoreContext storeContext)
        {
            m_StoreContext = storeContext;
        }
        [HttpGet]
        public ActionResult<IList<Product>> GetProducts()
        {
            return Ok(m_StoreContext.Products.ToList());
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "These is a product";
        }
    }
}