using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast_Club
{
    class Menu
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Menu(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }
        static public List<Menu> MenuItems()
        {

            string item1Detail = "Stuffed  with ripe avocado, lean bacon, bell pepper, a blend of Monterey Jack and Cheddar cheeses and topped with sour cream and chives. Served with our homemade salsa. ";
            Menu item1 = new Menu("AWESOME AVOCADO", "Omelette", item1Detail, 15.10);

            string item2Detail = "Egg whites, fresh green pepper, zucchini, mushrooms, onions, tomatoes, a blend of Monterey Jack and Cheddar cheeses and topped with chives.";
            Menu Item2 = new Menu("VEGGIE DELIGHT", "Omelette", item2Detail, 10.30);

            string item3Detail = "Egg whites, spinach, turkey sausage and diced tomato. Served with our homemade salsa.";
            Menu Item3 = new Menu("LEAN & GREEN", "Sandwish", item3Detail, 13.00);

            string item4Detail = "Seasoned chicken breast, bell peppers, onions, diced tomatoes, a blend of Monterey Jack and Cheddar cheeses and topped with sour cream and chives. Served with our homemade salsa. ";
            Menu Item4 = new Menu("CHICKEN FAJITA ", "Omelette", item4Detail, 10.00);

            string item5Detail = "This one’s got the works! Sausage, ham, bacon, bell peppers, zucchini, diced onions, mushrooms, diced tomatoes, chives, a blend of Monterey Jack and Cheddar cheeses and topped with sour cream.  ";
            Menu Item5 = new Menu("THE ULTIMATE ", "Omelette", item5Detail, 13.50);

            string item6Detail = "A helthier version of the tradisional English Breakfast: Tomato, turkey bacon, turkey ham, turkey sousage and eggs.";
            Menu Item6 = new Menu("THE HEALTHIER ENGLISHMAN ", "Combo", item6Detail, 12.50);

            string item7Detail = "Three eggs* any style, choice of tureky bacon,  chicken sausage links and served with a cup of fresh fruit and your choice of potato chunks or hash browns";
            Menu Item7 = new Menu("THE AMERICAN", "Combo", item7Detail, 14.50);

            string item8Detail = "Our traditional malted waffle topped with whipped cream and a dusting of powdered sugar. Served with a side of whipped butter and fresh seasonal fruit.";
            Menu Item8 = new Menu("GOLDEN WAFFLE", " Pancakes", item8Detail, 11.50);

            string item9Detail = "Yogourt with oats, honey and raspberry ";
            Menu Item9 = new Menu("PARFAIT", "Yogurt", item9Detail, 5.50);

            string item10Detail = "Assortments of Teas: Green, English Breakfast, Oolong, LimePie";
            Menu Item10 = new Menu("TEA", "Beverage", item10Detail, 1.00);

            string item11Detail = "Freshly squeezed orange juice";
            Menu Item11 = new Menu("Orange Juice", "Beverage", item11Detail, 2.00);

            string item12Detail = "Colombian Dark roast Coffee";
            Menu Item12 = new Menu("Coffee", "Beverage", item12Detail, 1.25);

            List<Menu> menu = new List<Menu>();

            // menu.Add(item0);
            menu.Add(item1);
            menu.Add(Item2);
            menu.Add(Item3);
            menu.Add(Item4);
            menu.Add(Item5);
            menu.Add(Item6);
            menu.Add(Item7);
            menu.Add(Item8);
            menu.Add(Item9);
            menu.Add(Item10);
            menu.Add(Item11);
            menu.Add(Item12);
            return menu;
        }

    }
}

