using MyWildFarm.Interfaces;
namespace MyWildFarm.Food
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}
