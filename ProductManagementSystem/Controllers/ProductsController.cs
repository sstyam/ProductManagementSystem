using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Data;
using ProductManagementSystem.Models;
using ProductManagementSystem.Models.Entities;

namespace ProductManagementSystem.Controllers
{
    //localhost:xxxx/api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        //We will make a method that will return the static list of Products
        public IActionResult GetAllProducts()
        {
          var allProducts =  dbContext.Products.ToList();
            return Ok(allProducts);
        }

        //Single Product Information
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetProductById(Guid id)
        {
          var product=  dbContext.Products.Find(id);
            if(product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //Functionality to Add a New Product

        [HttpPost]

        //DTO-> Data Transfer Objects-> They transfer the data from one operation to the Other
        public IActionResult AddProduct(AddProductDto addProductDto)
        {
            var productEntity = new Product()
            {
                Name = addProductDto.Name,
                Description = addProductDto.Description,
                Price = addProductDto.Price,
                StockQuantity = addProductDto.StockQuantity,

            };

            dbContext.Products.Add(productEntity);
            dbContext.SaveChanges();
            return Ok(productEntity);


        }

        //Update the Product
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateProduct(Guid id,UpdateProductDto updateProductDto)
        {
            var product = dbContext.Products.Find(id);
            if(product is null)
            {
                return NotFound();
            }

            product.Name = updateProductDto.Name;
            product.Description = updateProductDto.Description;
            product.Price = updateProductDto.Price;
            product.StockQuantity = updateProductDto.StockQuantity;

            dbContext.SaveChanges(); // It make sure that any changes made here, gets reflected in the Database

            return Ok(product);

        }

        //Delete the Product
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var product = dbContext.Products.Find(id);
            if(product is null)
            {
                return NotFound();
            }
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            return Ok("Product Deleted Successfully");

        }
    }
}
