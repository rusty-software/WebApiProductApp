using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProductApp.Models;

namespace WebApiProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{ Id = 1, Name = "Shoes", Category = "Footwear", Price = 39.95m },
            new Product{ Id = 2, Name = "Glasses", Category = "Accessories", Price = 27.00m },
            new Product{ Id = 1, Name = "Sambuca", Category = "Libation", Price = 42.50m },
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
