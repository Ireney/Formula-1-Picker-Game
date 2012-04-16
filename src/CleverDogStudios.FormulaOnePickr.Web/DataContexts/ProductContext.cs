using System.Data.Entity;
using System.Diagnostics;
using CleverDogStudios.FormulaOnePickr.Data;
using CleverDogStudios.FormulaOnePickr.Web.Domain;

namespace CleverDogStudios.FormulaOnePickr.Web.DataContexts
{
    public class ProductContext : DbContext, ISeedable<ProductContext>
    {
        public ProductContext() : base("Products"){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public void Seed(ProductContext context)
        {
            var food = new Category { CategoryId = "FOOD", Name = "Foods" };
            var wood = new Category { CategoryId = "WOOD", Name = "Woods" };
            
            context.Categories.Add(food);
            context.Categories.Add(wood);

            var bacon = new Product {Category = food, Name = "Bacon"};
            var sushi = new Product {Category = food, Name = "Sushi"};
            var log = new Product {Category = wood, Name = "Fire Log"};
            var christmasTree = new Product {Category = wood, Name = "Christmas Tree"};

            context.Products.Add(bacon);
            context.Products.Add(sushi);
            context.Products.Add(log);
            context.Products.Add(christmasTree);
            
            var recordsAffected = context.SaveChanges();

            Debug.WriteLine("Saved {0} entities to the database.", recordsAffected);
        }
    }
}