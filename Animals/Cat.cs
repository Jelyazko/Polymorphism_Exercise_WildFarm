using System;
using MyWildFarm.Interfaces;

namespace MyWildFarm.Animals
{
    public class Cat : Feline
    {
        private const double increaseWeigh = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Meat" || food.GetType().Name == "Vegetable")
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
            return "Meow";
        }
    }
}
