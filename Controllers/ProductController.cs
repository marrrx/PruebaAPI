using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAPI.db;
using PruebaAPI.Dtos;
using PruebaAPI.models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats;

namespace PruebaAPI.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products = await _db.Products
                .Include(p => p.ProductImages)
                .Include(p => p.Category)
                .ToListAsync();

            var productDtos = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Category = new CategoryDto
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                },
                ProductImages = p.ProductImages.Select(pi => new ProductImageDto
                {
                    Id = pi.Id,
                    Url = pi.Url
                }).ToList()
            }).ToList();

            return Ok(productDtos);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct([FromForm] ProductDto productDto, [FromForm] List<IFormFile> images)
        {
            var imageUrls = new List<string>();
            var supportedTypes = new[] { "image/jpeg", "image/png", "image/gif" };

            if (images != null && images.Count > 0)
            {
                foreach (var image in images)
                {
                    // Validar el tipo de archivo
                    if (!supportedTypes.Contains(image.ContentType))
                    {
                        return BadRequest($"El tipo de archivo {image.ContentType} no es soportado. Solo se permiten JPEG, PNG, y GIF.");
                    }

                    if (image.Length > 0)
                    {
                        using var imageStream = image.OpenReadStream();
                        using var img = await Image.LoadAsync(imageStream);

                        img.Mutate(x => x.Resize(new ResizeOptions
                        {
                            Mode = ResizeMode.Max,
                            Size = new Size(800, 600) 
                        }));

                        var fileName = $"{Guid.NewGuid()}.jpg"; 
                        var filePath = Path.Combine("wwwroot/images", fileName); 

                        await img.SaveAsJpegAsync(filePath); 

                        var imageUrl = $"http://localhost:5042/images/{fileName}";
                        imageUrls.Add(imageUrl);
                    }
                }
                }

                var product = new Product
                {
                    Name = productDto.Name,
                    Description = productDto.Description,
                    Price = productDto.Price,
                    CategoryId = productDto.Category.Id,
                    ProductImages = imageUrls.Select(url => new ProductImage { Url = url }).ToList()
                };

                _db.Products.Add(product);
                await _db.SaveChangesAsync();

                var createdProductDto = new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Category = new CategoryDto
                    {
                        Id = product.CategoryId,
                        Name = (await _db.Categories.FindAsync(product.CategoryId)).Name 
                    },
                    ProductImages = product.ProductImages.Select(pi => new ProductImageDto
                    {
                        Id = pi.Id,
                        Url = pi.Url
                    }).ToList()
                };

                return CreatedAtAction(nameof(GetProducts), new { id = createdProductDto.Id }, createdProductDto);
            }


            [HttpGet("{id}")]
            public async Task<ActionResult<ProductDto>> GetProductById(int id)
            {
                var product = await _db.Products
                    .Include(p => p.Category)
                    .Include(p => p.ProductImages)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (product == null)
                {
                    return NotFound();
                }

                var productDto = new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Category = new CategoryDto
                    {
                        Id = product.Category.Id,
                        Name = product.Category.Name
                    },
                    ProductImages = product.ProductImages.Select(pi => new ProductImageDto
                    {
                        Id = pi.Id,
                        Url = pi.Url
                    }).ToList()
                };

                return Ok(productDto);
            }

            [HttpDelete]
            public async Task<ActionResult> DeleteProduct(int id)
            {
                var product = await _db.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                _db.Products.Remove(product);
                await _db.SaveChangesAsync();

                return Ok("Product removed");
            }

        }
    }