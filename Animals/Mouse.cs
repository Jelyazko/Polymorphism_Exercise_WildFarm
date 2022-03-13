using System;
using MyWildFarm.Interfaces;

namespace MyWildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double increaseWeigh = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                Weight += increaseWeigh * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
