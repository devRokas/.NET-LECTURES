namespace Lecture_18.Products
{
    public abstract class Product
    {
        protected readonly int _id;
        protected readonly string _name;
        protected int _price;
        protected int _qty;

        protected Product(int id, string name)
        {
            _id = id;
            _name = name;
            _qty = 100;
        }

        public void DecreaseQty(int qty)
        {
            _qty -= qty;
        }
        
        public void IncreaseQty(int qty)
        {
            _qty += qty;
        }

        public void ChangePrice(int newPrice)
        {
            _price = newPrice;
        }

        public int GetQty()
        {
            return _qty;
        }

        public int GetId()
        {
            return _id;
        }

        public override string ToString()
        {
            return $"Id: {_id}; Name: {_name}; Price: {_price}; Qty: {_qty}";
        }
    }
}