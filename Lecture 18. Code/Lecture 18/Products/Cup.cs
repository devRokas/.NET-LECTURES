namespace Lecture_18.Products
{
    public class Cup : Product
    {
        public Cup(int id, string name) : base(id, name)
        {
            _price = 15;
        }
    }
}