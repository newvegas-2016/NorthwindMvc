using System.Collections.Generic;
using Packt.Shared;

namespace NorthwindMvc.Models
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }
        public IList<Product> Products { get; set; }
    }
}