using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tunzking.DataAccess.Data;
using Tunzking.DataAccess.Repository.IRepository;
using Tunzking.Models;

namespace Tunzking.DataAccess.Repository
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.Gender = product.Gender;
                objFromDb.Brand = product.Brand;
                objFromDb.Price = product.Price;
                objFromDb.CurrentPrice = product.CurrentPrice;
                objFromDb.CategoryId = product.CategoryId;
                if (objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }

            }
        }
    }
}
