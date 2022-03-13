using System;
using MyWildFarm.Interfaces;

namespace MyWildFarm.Animals
{
    public class Owl : Bird
    {
        private const double increaseWeigh = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Meat")
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
            return "Hoot Hoot";
        }
    }
}
