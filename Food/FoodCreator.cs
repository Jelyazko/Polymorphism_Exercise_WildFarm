using System;
using MyWildFarm.Interfaces;
namespace MyWildFarm.Food
{
    public class FoodCreator
    {
        public static IFood CreateFood(string foodType, int foodQty)
        {
            IFood food = default;
            switch (foodType)
            {
                case "Vegetable":
                    food = new Vegetable(foodQty);
                    break;
                case "Fruit":
                    food = new Fruit(foodQty);
                    break;
                case "Meat":
                    food = new Meat(foodQty);
                    break;
                case "Seeds":
                    food = new Seeds(foodQty);
                    break;
                default:
                    throw new ArgumentException("Invalid Food!");
            }
            return food;
        }
    }
}
