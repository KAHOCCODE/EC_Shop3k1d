using EC_Shop3k1d.Data;
using EC_Shop3k1d.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EC_Shop3k1d.Controllers
{
	public class HomeController : Controller
	{
		private readonly Shop3k1dContext _context;

		public HomeController(Shop3k1dContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
            var products = _context.ShopProducts
                .Include(p => p.ShopProductImages) 
                .Include(p => p.Category)           
                .Include(p => p.Supplier)           
                .ToList();

            return View(products);
        }

        //thêm sản phẩm mới 
        // GET: Create
        public IActionResult Create()
        {
            // Populate categories and suppliers for the dropdown
            ViewData["Categories"] = new SelectList(_context.ShopCategories, "Id", "CategoryName");
            ViewData["Suppliers"] = new SelectList(_context.ShopSuppliers, "Id", "SupplierName");

            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopProduct product, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                // Lưu sản phẩm
                _context.ShopProducts.Add(product);
                await _context.SaveChangesAsync();

                // Lưu hình ảnh sản phẩm (nếu có)
                if (imageFile != null && imageFile.Length > 0)
                {
                    var fileName = $"{product.Id}_{imageFile.FileName}";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    // Lưu đường dẫn hình ảnh vào cơ sở dữ liệu
                    var productImage = new ShopProductImage
                    {
                        ProductId = product.Id,
                        ImageUrl = $"/images/products/{fileName}"
                    };
                    _context.ShopProductImages.Add(productImage);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }

            // If the model state is invalid, pass the SelectLists again
            ViewData["Categories"] = new SelectList(_context.ShopCategories, "Id", "CategoryName", product.CategoryId);
            ViewData["Suppliers"] = new SelectList(_context.ShopSuppliers, "Id", "SupplierName", product.SupplierId);

            return View(product);
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
