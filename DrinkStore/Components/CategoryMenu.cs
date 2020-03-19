using DrinkStore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStore.Components
{
    public class CategoryMenu : ViewComponent
    {

        private readonly ICategoryRepo _categoryRepository;

        public CategoryMenu(ICategoryRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}
