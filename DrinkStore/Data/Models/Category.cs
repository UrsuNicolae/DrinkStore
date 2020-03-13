using System.Collections.Generic;

namespace DrinkStore.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public IList<Drink> Drinks { get; set; }
    }
}
