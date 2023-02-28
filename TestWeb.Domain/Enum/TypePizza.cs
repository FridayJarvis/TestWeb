using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeb.Domain.Enum
{
    public enum TypePizza
    {
        [Display(Name = "Мясная")]
        MeatPizza = 0,
        [Display(Name = "Грибная")]
        MushroomPizza = 1,
        [Display(Name = "Овощная")]
        VegetablePizza = 2,
        [Display(Name = "Сырная")]
        CheesyPizza = 3,
        [Display(Name = "Экзотическая")]
        ExoticPizza = 4,
        [Display(Name = "С морепродуктами")]
        SeafoodPizza = 5,
        [Display(Name = "Колбасная")]
        SausagePizza = 6

    }
}
