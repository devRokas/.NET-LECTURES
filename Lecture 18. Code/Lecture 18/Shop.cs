using System;
using System.Collections.Generic;
using Lecture_18.Products;

namespace Lecture_18
{
    public class Shop
    {
        private readonly List<Product> _products;

        public Shop()
        {
            _products = new List<Product>
            {
                new Book(1, "Book"),
                new Candy(2, "Candy"),
                new Cup(3, "Cup"),
                new Candy(4, "Candy crush")
            };
        }
        
        public void Add(int productId, int qty)
        {
            var product = GetProductById(productId);
            
            product.IncreaseQty(qty);
        }

        public void Buy(int productId, int qty)
        {
            var product = GetProductById(productId);
            
            product.DecreaseQty(qty);
        }

        public void List()
        {
            foreach (var product in _products)
            {
                if (product.GetQty() != 0)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        
        private Product GetProductById(int id)
        {
            foreach (var product in _products)
            {
                if (product.GetId() == id)
                {
                    return product;
                }
            }

            return null;
        }
    }
}