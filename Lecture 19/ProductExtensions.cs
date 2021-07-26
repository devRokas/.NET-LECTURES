using System;

namespace Lecture_19
{
    public static class ProductExtensions
    {
        public static void Print(this Product product)
        {
            Console.WriteLine($"{product.Id} {product.Name} {product.Type} {product.Price}");
        }

        public static void ChangeName(this Product product, string newName)
        {
            product.Name = newName;
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}