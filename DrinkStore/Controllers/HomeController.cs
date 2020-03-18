using DrinkStore.Data.Interfaces;
using DrinkStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepo _drinkRepository;

        public HomeController(IDrinkRepo drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}
