using DrinkStore.Data.Models;
using System.Collections.Generic;

namespace DrinkStore.Data.Interfaces
{
    public interface IDrinkRepo
    {
        IEnumerable<Drink> Drinks { get; }

        IEnumerable<Drink> PreferredDrinks { get; }

        Drink GetDrinkById(int drinkId);
    }
}
