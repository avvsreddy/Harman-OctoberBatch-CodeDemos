using CoolProductsCatelogService.Data;
using CoolProductsCatelogService.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatelogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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



        //[HttpGet("cache")]
        //[OutputCache]
        //public string Get()
        //{
        //    return DateTime.Now.ToString();
        //}


        // GET   .../api/coolproducts
        [HttpGet]
        //[Authorize]
        public async Task<List<Product>> GetProductsAsync()
        {
            return await db.Products.ToListAsync();
        }


        // GET .../api/coolproducts/odata
        [HttpGet("odata")]
        [EnableQuery]
        public IQueryable<Product> GetProductsOdata()
        {
            return db.Products.AsQueryable();
        }

        // get product by id
        // design the uri
        // GET .../api/coolproducts/5


        [HttpGet("{id:int}")]
        //[Route("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[EnableCors(PolicyName = "allowAllClients")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var p = await db.Products.FindAsync(id);
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


        //[OutputCache(Duration = 60)]
        //[EnableCors(PolicyName = "policy2")]
        public async Task<IActionResult> GetProductsByBrandAsync(string brand)
        {
            var products = await db.Products.Where(p => p.Brand == brand).ToListAsync();
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
        public async Task<IActionResult> GetCheapestProductAsync()
        {
            var cheapestProduct = await db.Products.OrderBy(p => p.Price).FirstOrDefaultAsync();
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
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            var productToDel = await db.Products.FindAsync(id);
            if (productToDel == null)
            {
                return NotFound("Product not found for delete");
            }
            db.Products.Remove(productToDel);
            await db.SaveChangesAsync();
            return Ok();
        }

        // edit product
        // PUT .../api/products

        [HttpPut]
        public async Task<IActionResult> EditProductAsync(Product p)
        {
            // do validatation
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            db.Products.Update(p);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
