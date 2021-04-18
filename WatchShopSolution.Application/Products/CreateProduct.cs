using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WatchShopSolution.Database;
using WatchShopSolution.Domain.Models;

namespace WatchShopSolution.Application.Products
{
    public class CreateProduct
    {
        private readonly ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }


        // truyền vào 1 product viewmodel và tạo mới 
        // = namespace WatchShopSolution.Application.ViewModels
        public async Task Create(ViewModels.ProductViewModel productViewModel)
        {
            _context.Products.Add(new Product
            {
                Name = productViewModel.Name,
                Description = productViewModel.Description,
                Value = productViewModel.Value
            });
            await _context.SaveChangesAsync();
        }   
    }
}
