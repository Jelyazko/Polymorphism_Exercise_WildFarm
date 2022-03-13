using System;
using MyWildFarm.Interfaces;

namespace MyWildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double increaseWeigh = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }
    }
}
