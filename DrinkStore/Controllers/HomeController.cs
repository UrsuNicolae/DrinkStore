using DrinkStore.Data.Interfaces;
using DrinkStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IDrinkRepo _drinkRepo;

        public HomeController(ICategoryRepo categoryRepo, IDrinkRepo drinkRepo)
        {
            _categoryRepo = categoryRepo;
            _drinkRepo = drinkRepo;
        }

        public ViewResult List()
        {
            DrinkListViewModel drinks = new DrinkListViewModel();
            drinks.Drinks = _drinkRepo.Drinks;
            drinks.CurrentCategory = "DrinkCategory";
            return View(drinks);
        }
        
    }
}
