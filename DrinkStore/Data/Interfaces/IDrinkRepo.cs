using System.Collections.Generic;

namespace DrinkStore.Data.Models
{
    interface IDrinkRepo
    {
        IEnumerable<Drink> Drink { get; set; }

        IEnumerable<Drink> PreferredDrinks { get; set; }

        Drink GetDrinkById(int drinkId);
    }
}
