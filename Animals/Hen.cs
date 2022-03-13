using MyWildFarm.Interfaces;

namespace MyWildFarm.Animals
{
    public class Hen : Bird
    {
        private const double increaseWeigh = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            Weight += increaseWeigh * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
