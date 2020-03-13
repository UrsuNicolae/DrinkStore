using DrinkStore.Data.Models;
using System.Collections.Generic;

namespace DrinkStore.Data.Interfaces
{
    public interface IDrinkRepo
    {
        IEnumerable<Drink> Drinks { get; set; }

        IEnumerable<Drink> PreferredDrinks { get; set; }

        Drink GetDrinkById(int drinkId);
    }
}
