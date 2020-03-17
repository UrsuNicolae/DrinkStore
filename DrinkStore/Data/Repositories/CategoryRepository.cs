using DrinkStore.Data.Interfaces;
using DrinkStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStore.Data.Repositories
{
    public class CategoryRepository:ICategoryRepo
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
