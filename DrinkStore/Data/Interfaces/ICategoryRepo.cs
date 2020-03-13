using DrinkStore.Data.Models;
using System.Collections.Generic;

namespace DrinkStore.Data.Interfaces
{
    interface ICategoryRepo
    {
        IEnumerable<Category> Categories { get; set; }
    }
}
