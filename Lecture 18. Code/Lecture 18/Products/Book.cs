namespace Lecture_18.Products
{
    public class Book: Product
    {
        public Book(int id, string name) : base(id, name)
        {
            _price = 5;
        }
    }
}