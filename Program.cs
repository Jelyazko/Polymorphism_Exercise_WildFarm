using System;
using MyWildFarm.Animals;
using MyWildFarm.Food;
using System.Collections.Generic;
using MyWildFarm.Interfaces;
namespace MyWildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            string input = Console.ReadLine();

            while (true)
            {
                string[] animalInfo = input
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] foodInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);

                try
                {
                    Animal animal = AnimalCreator.CreateAnimal(animalInfo, animalType, animalName, animalWeight);
                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);

                    string foodType = foodInfo[0];
                    int foodQty = int.Parse(foodInfo[1]);

                    IFood food = FoodCreator.CreateFood(foodType, foodQty);
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
                if (input == "End") break;
            }

            foreach (var beast in animals)
            {
                Console.WriteLine(beast.ToString());
            }
        }

    }
}
