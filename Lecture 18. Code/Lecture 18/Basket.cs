using System.Collections.Generic;
using Lecture_18.Products;

namespace Lecture_18
{
    public class Basket
    {
        private readonly List<Product> _products;

        public Basket()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}