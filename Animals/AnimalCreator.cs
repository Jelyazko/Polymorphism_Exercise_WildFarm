using System;
namespace MyWildFarm.Animals
{
    public class AnimalCreator
    {
        public static Animal CreateAnimal(string[] animalInfo, string animalType, string animalName, double animalWeight)
        {
            Animal animal = default;
            switch (animalType)
            {
                case "Hen":
                    double animalWingSize = double.Parse(animalInfo[3]);
                    animal = new Hen(animalName, animalWeight, animalWingSize);
                    break;
                case "Owl":
                    animalWingSize = double.Parse(animalInfo[3]);
                    animal = new Owl(animalName, animalWeight, animalWingSize);
                    break;
                case "Mouse":
                    string animalLivingRegion = animalInfo[3];
                    animal = new Mouse(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Dog":
                    animalLivingRegion = animalInfo[3];
                    animal = new Dog(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Cat":
                    animalLivingRegion = animalInfo[3];
                    string animalBreed = animalInfo[4];
                    animal = new Cat(animalName, animalWeight, animalLivingRegion, animalBreed);
                    break;
                case "Tiger":
                    animalLivingRegion = animalInfo[3];
                    animalBreed = animalInfo[4];
                    animal = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                    break;
                default:
                    throw new ArgumentException("Invalid Animal!");
            }

            return animal;
        }
    }
}
