namespace Lecture_18.Products
{
    public class Candy : Product
    {
        public Candy(int id, string name) : base(id, name)
        {
            _price = 8;
        }
    }
}