using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchShopSolution.Database;

namespace WatchShopSolution.Application.Products
{
    public class GetProducts
    {
        private readonly ApplicationDbContext _context;
        public GetProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        // lấy ra product trong namespace WatchShopSolution.Application.Products
        public async Task<IEnumerable<ProductViewModel>> Do()
        {
            return await _context.Products.Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = x.Value.ToString("N2"),
            }).ToListAsync();
        }
    }
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
