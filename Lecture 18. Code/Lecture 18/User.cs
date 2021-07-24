using Lecture_18.Products;

namespace Lecture_18
{
    public class User
    {
        private readonly Basket _basket;
        
        public User()
        {
            _basket = new Basket();
        }

        public void AddToBasket(Product product)
        {
            _basket.Add(product);
        }
    }
}