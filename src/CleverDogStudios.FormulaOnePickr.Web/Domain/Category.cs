using System.Collections.Generic;

namespace CleverDogStudios.FormulaOnePickr.Web.Domain
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}