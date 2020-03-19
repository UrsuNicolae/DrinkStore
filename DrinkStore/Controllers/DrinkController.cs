using DrinkStore.Data.Interfaces;
using DrinkStore.Data.Models;
using DrinkStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinkStore.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IDrinkRepo _drinkRepo;

        public DrinkController(ICategoryRepo categoryRepo, IDrinkRepo drinkRepo)
        {
            _categoryRepo = categoryRepo;
            _drinkRepo = drinkRepo;
        }
       
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;

            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepo.Drinks.OrderBy(n=>n.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepo.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic"));
                }
                else 
                {
                    drinks = _drinkRepo.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic"));
                }
                currentCategory = category;
            }

            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };

            return View(drinkListViewModel);
        }
        
    }
}
