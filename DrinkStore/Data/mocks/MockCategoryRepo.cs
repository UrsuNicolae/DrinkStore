﻿using DrinkStore.Data.Interfaces;
using DrinkStore.Data.Models;
using System.Collections.Generic;

namespace DrinkStore.Data.mocks
{
    public class MockCategoryRepo : ICategoryRepo
    {
    
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Alcoholic", Description = "All alcoholic drinks"},
                    new Category{CategoryName = "Non alcoholic", Description = "All non alcoholic drinks"}
                };
            }
            set
            {

            }
        }
    }
}
