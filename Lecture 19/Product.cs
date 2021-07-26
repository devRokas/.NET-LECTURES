using System;

namespace Lecture_19
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Price { get; set; }

        private readonly int _qty;
        private readonly int _expirationDate;

        public Product(int qty, int expirationDate)
        {
            _qty = qty;
            _expirationDate = expirationDate;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public bool CheckIfExpired()
        {
            return _expirationDate > 0;
        }
    }
}