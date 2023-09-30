using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tunzking.Models;

namespace Tunzking.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Shirt",
                    Description = "A T-shirt, or tee for short, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean. The T-shirt evolved from undergarments used in the 19th century and, in the mid-20th century, transitioned from undergarment to general-use casual clothing.",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Shoes",
                    Description = "A shoe is an item of footwear intended to protect and comfort the human foot. Though the human foot can adapt to varied terrains and climate conditions, it is vulnerable, and shoes provide protection. Form was originally tied to function but over time shoes also became fashion items. Some shoes are worn as safety equipment, such as steel-toe boots, which are required footwear at industrial worksites.",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Skirt",
                    Description = "In modern times, skirts are very commonly worn by women and girls. Some exceptions include the izaar, worn by many Muslim cultures, and the kilt, a traditional men's garment in Scotland, Ireland, and sometimes England. Fashion designers such as Jean Paul Gaultier, Vivienne Westwood, Kenzo and Marc Jacobs have also shown men's skirts. Transgressing social codes, Gaultier frequently introduces the skirt into his men's wear collections as a means of injecting novelty into male attire, most famously the sarong seen on David Beckham.",
                    DisplayOrder = 3
                },
                new Category
                {
                    Id = 4,
                    Name = "Short",
                    Description = "Shorts are a garment worn over the pelvic area, circling the waist and splitting to cover the upper part of the legs, sometimes extending down to the knees but not covering the entire length of the leg. They are called \"shorts\" because they are a shortened version of trousers, which cover the entire leg, but not the foot. Shorts are typically worn in warm weather or in an environment where comfort and airflow are more important than the protection of the legs.",
                    DisplayOrder = 4
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Air Jordan XXXVIII \"FIBA\"",
                    Description = "When it comes to hoops, Jordan Brand has earned its global reputation as innovator and collaborator. This AJ XXXVIII honors the International Basketball Federation—the governing body for basketball worldwide. Like white light containing every possible color, the striking outer conceals an insole decorated with all the hues of the vibrant FIBA logo. Boldness, from the inside out.",
                    Gender = "Men",
                    Brand = "Jordan",
                    Price = 400,
                    CurrentPrice = 200,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Check Collar Cotton Polo Shirt",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                    Gender = "Men",
                    Brand = "Gucci",
                    Price = 500,
                    CurrentPrice = 250,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "WOMEN'S GUCCI JORDAAN LOAFER",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                    Gender = "Women",
                    Brand = "Gucci",
                    Price = 900,
                    CurrentPrice = 700,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Slit denim skirt",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                    Gender = "Women",
                    Brand = "Zara",
                    Price = 800,
                    CurrentPrice = 250,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "YOGA TRAINING SHORTS",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                    Gender = "Men",
                    Brand = "Nike",
                    Price = 100,
                    CurrentPrice = 90,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Mixed-materials Daymaster sneakers",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                    Gender = "Women",
                    Brand = "Dolce",
                    Price = 820,
                    CurrentPrice = 200,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
            modelBuilder.Entity<ShoppingCart>().HasData(
                new ShoppingCart
                {
                    Id = 1,
                    ProductId = 1,
                    Count = 1,
                    ApplicationUserId = Guid.NewGuid(),
                }
                );
        }
    }
}
