using System;
using System.Collections.Generic;
using System.Text;
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
        public void Create(int id,string name, string description)
        {
            _context.Products.Add(new Product
            {
                Id = id,
                Description = description,
                Name = name

            });
        }
    }
}
