using CoolProductsCatelogService.Data;
using CoolProductsCatelogService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoolProductsCatelogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolProductsController : ControllerBase
    {
        private readonly ProductsDbContext db;

        public CoolProductsController(ProductsDbContext db)
        {
            this.db = db;
        }


        // add action methods - endpoint
        // maps to one http method


        // step1: design a endpoint uri

        // GET   .../api/coolproducts
        [HttpGet]
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }


        // get product by id
        // design the uri
        // GET .../api/coolproducts/5


        [HttpGet("{id:int}")]
        //[Route("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProduct(int id)
        {
            var p = db.Products.Find(id);
            if (p == null) // not found
            {
                // 404
                return NotFound("Requested product not found");
            }
            // data + 200
            return Ok(p);
        }

        // get products by brand
        // uri: GET .../api/products/brand/apple
        [HttpGet("brand/{brand:alpha}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProductsByBrand(string brand)
        {
            var products = db.Products.Where(p => p.Brand == brand).ToList();
            if (products.Count == 0)
            {
                return NotFound("No products found");
            }
            return Ok(products);
        }

        // return cheapest product
        // URI: GET .../api/products/cheapest
        [HttpGet("cheapest")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCheapestProduct()
        {
            var cheapestProduct = db.Products.OrderBy(p => p.Price).FirstOrDefault();
            if (cheapestProduct == null)
            {
                return NotFound("No cheapest product found");
            }
            return Ok(cheapestProduct);
        }

        // return costliest product
        // URI: GET .../api/products/costliest
        [HttpGet("costliest")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCostliestProduct()
        {
            var costliestProduct = db.Products.OrderByDescending(p => p.Price).FirstOrDefault();
            if (costliestProduct == null)
            {
                return NotFound("No cheapest product found");
            }
            return Ok(costliestProduct);
        }


        // get all products between p1 and p2
        // URI: get   .../api/products/min/{p1}/max/{p2}
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("min/{min:int}/max/{max:int}")]
        public IActionResult GetProductsByPriceRange(int min, int max)
        {
            var products = (from p in db.Products
                            where p.Price >= min && p.Price <= max
                            select p).ToList();
            if (products.Count == 0) return NotFound();
            return Ok(products);
        }


        // add product
        // POST .../api/products
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product p)
        {
            // do validatation
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            // save
            db.Products.Add(p);
            db.SaveChanges();
            // 201+Location+data
            return Created($"api/products/{p.Id}", p);
        }

        // delete product by id
        // DELETE .../api/products/{id}

        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var productToDel = db.Products.Find(id);
            if (productToDel == null)
            {
                return NotFound("Product not found for delete");
            }
            db.Products.Remove(productToDel);
            db.SaveChanges();
            return Ok();
        }

        // edit product
        // PUT .../api/products

        [HttpPut]
        public IActionResult EditProduct(Product p)
        {
            // do validatation
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            db.Products.Update(p);
            db.SaveChanges();
            return Ok();
        }
    }
}
