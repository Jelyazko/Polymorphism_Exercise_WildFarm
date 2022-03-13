using System;
using MyWildFarm.Food;
namespace MyWildFarm.Interfaces
{
    public interface IAnimal
    {

         string Name { get; set; }

         double Weight { get; set; }

         int FoodEaten { get; set; }

         string ProduceSound();

         void Eat(IFood food);

    }
}
